using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace personel_organizer_ilk
{
    public static class GlobalAlarmService
    {
        private static Timer alarmTimer;
        private static List<Alarm> activeAlarms = new List<Alarm>();
        private static string path = Alarm.path;
        private static string currentUser = LoginedUser.getInstance().UserGetSet.Username;

        public static void Start()
        {
            Util.LoadReminder(activeAlarms, path);

            alarmTimer = new Timer();
            alarmTimer.Interval = 1000;
            alarmTimer.Tick += AlarmTimer_Tick;
            alarmTimer.Start();
        }

        private static void AlarmTimer_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm");
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");

            foreach (var alarm in activeAlarms.ToList())
            {
                if (!alarm.IsTriggered &&
                    alarm.User == currentUser &&
                    alarm.Day == currentDate &&
                    alarm.Time == currentTime)
                {
                    alarm.IsTriggered = true;

                    foreach (Form frm in Application.OpenForms)
                    {
                        Util.Shake(frm); // tüm açık formlar sallar
                    }

                    MessageBox.Show($"🔔 {alarm.Type}: {alarm.Summary}\n{alarm.Description}",
                                    "Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Util.SaveReminder(activeAlarms, path);
                    break;
                }
            }
        }
    }
}