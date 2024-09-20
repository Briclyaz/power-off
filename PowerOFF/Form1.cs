using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace PowerOFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = null;
            button1.Visible = false;
            checkedListBox1.ItemCheck += new ItemCheckEventHandler(CheckedListBox_ItemCheck);
            checkedListBox2.ItemCheck += new ItemCheckEventHandler(CheckedListBox_ItemCheck);
            notifyIcon1.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        public int timetopoweroff = 0;
        public bool btnclck = false;

        private void button1_Click(object sender, EventArgs e)
        {
            btnclck = false;
            if (checkedListBox1.CheckedItems != null || checkedListBox2.CheckedItems != null)
            {
                // записываем данные элементов в переменные
                var weekdays = checkedListBox1.CheckedItems.Cast<string>().ToList();
                var weekendDays = checkedListBox2.CheckedItems.Cast<string>().ToList();
                var weekdayTime = dateTimePicker1.Value.TimeOfDay;
                var weekendTime = dateTimePicker2.Value.TimeOfDay;
                var autoApply = checkBox1.Checked;
                var minimizeToTray = checkBox2.Checked;

                var settings = new
                {
                    // переносим значения переменных в конфигурационный файл settings.json
                    Weekdays = weekdays,
                    WeekendDays = weekendDays,
                    WeekdayTime = weekdayTime,
                    WeekendTime = weekendTime,
                    AutoApply = autoApply,
                    MinimizeToTray = minimizeToTray
                };

                // создаём тот самый конфигурационный файл
                var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText("settings.json", json);

                MessageBox.Show("Готово! Компьютер будет выключен в соответствии с заданными параметрами даты и времени.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclck = true;

                if (autoApply)
                {
                    // если поставили галочку, вызвать функцию
                    ApplySettings();
                }

                else
                {
                    try
                    {
                        // выполнится в том случае, если textbox1 != нулю
                        var times = Convert.ToInt32(textBox1.Text);
                        timetopoweroff = (times * 3600);
                        Process.Start("shutdown", "/s /f /t " + timetopoweroff);
                        MessageBox.Show("Компьютер выключится через " + times + " часов!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Пожалуйста, введите значение в часах. Например, 5", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // автоприменение параметров при запуске программы
        private void ApplySettings()
        {
            var settings = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("settings.json"));

            var weekdayTime = (TimeSpan)settings.WeekdayTime;
            var weekendTime = (TimeSpan)settings.WeekendTime;
            var weekdays = ((JArray)settings.Weekdays).ToObject<List<string>>();
            var weekendDays = ((JArray)settings.WeekendDays).ToObject<List<string>>();

            SetShutdownTimers(weekdays, weekdayTime);
            SetShutdownTimers(weekendDays, weekendTime);
        }

        // отключение компьютера если текущее время компьютера совпадает с заданным
        private void SetShutdownTimers(List<string> days, TimeSpan time)
        {
            if (checkedListBox1.CheckedItems != null || checkedListBox2.CheckedItems != null && btnclck == true)
            {
                foreach (var day in days)
                {
                    var shutdownTime = GetNextOccurrence(day, time);
                    var interval = (shutdownTime - DateTime.Now).TotalMilliseconds;

                    if (interval > 0)
                    {
                        var timer = new System.Timers.Timer
                        {
                            Interval = interval,
                            AutoReset = false
                        };
                        timer.Elapsed += (s, e) => ShutdownComputer();
                        timer.Start();
                    }
                    else
                    {
                        MessageBox.Show("Время выключения уже прошло для дня: " + day, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //русские наименования дней недели
        public enum RussianDayOfWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }

        // отслеживаем время на компьютере
        private DateTime GetNextOccurrence(string day, TimeSpan time)
        {
            var today = DateTime.Today;
            var targetDay = (RussianDayOfWeek)Enum.Parse(typeof(RussianDayOfWeek), day, true);
            var daysUntilTarget = ((int)targetDay - (int)today.DayOfWeek + 7) % 7;

            // Если целевой день совпадает с сегодняшним, но время уже прошло, берем следующий день
            if (daysUntilTarget == 0 && time < DateTime.Now.TimeOfDay)
            {
                daysUntilTarget = 7;
            }

            var nextOccurrence = today.AddDays(daysUntilTarget).Add(time);
            return nextOccurrence;
        }

        private void ShutdownComputer()
        {
            Process.Start("shutdown", "/s /f /t 60");
        }

        // при запуске если активна галочка автоприменения применит параметры и запустит таймер
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.json"))
            {
                var json = File.ReadAllText("settings.json");
                var settings = JsonConvert.DeserializeObject<dynamic>(json);

                foreach (var day in settings.Weekdays)
                {
                    int index = checkedListBox1.Items.IndexOf((string)day);
                    if (index != -1)
                    {
                        checkedListBox1.SetItemChecked(index, true);
                    }
                }

                foreach (var day in settings.WeekendDays)
                {
                    int index = checkedListBox2.Items.IndexOf((string)day);
                    if (index != -1)
                    {
                        checkedListBox2.SetItemChecked(index, true);
                    }
                }

                dateTimePicker1.Value = DateTime.Today.Add((TimeSpan)settings.WeekdayTime);
                dateTimePicker2.Value = DateTime.Today.Add((TimeSpan)settings.WeekendTime);
                checkBox1.Checked = settings.AutoApply;
                checkBox2.Checked = settings.MinimizeToTray;

                if (settings.AutoApply)
                {
                    ApplySettings();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox2.Checked)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            Application.Exit();
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Используем BeginInvoke, чтобы обновить состояние после изменения
            this.BeginInvoke((MethodInvoker)delegate
            {
                // Проверяем количество выделенных элементов в обоих списках
                bool anyChecked = checkedListBox1.CheckedItems.Count > 0 || checkedListBox2.CheckedItems.Count > 0;

                // Показываем или скрываем элементы в зависимости от результата
                button1.Visible = anyChecked;
                dateTimePicker1.Visible = anyChecked;
                dateTimePicker2.Visible = anyChecked;
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (textBox1.Text != null)
            {
                button1.Visible = true;
            }
        }
    }
}
