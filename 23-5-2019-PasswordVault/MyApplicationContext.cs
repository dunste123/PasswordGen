using System;
using System.Windows.Forms;

namespace PasswordVault
{
    public class MyApplicationContext : ApplicationContext
    {
        private NotifyIcon notifyIcon;
        private Configuration configuration;

        public MyApplicationContext()
        {
            this.configuration = new Configuration();
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.Icon = Properties.Resources.favicon;

            MenuItem ExitMenu = new MenuItem("Exit program", (sender, e) => {
                this.notifyIcon.Visible = false;
                Application.Exit();
            });

            MenuItem config = new MenuItem("Configuration", (sender, e) => {
                Form1 configForm = new Form1(configuration);
                configForm.ShowDialog();
            });

            MenuItem gen = new MenuItem("Generate + copy to clipboard", (sender, e) => {
                PasswordGenerator generator = new PasswordGenerator(configuration);

                Timer timer = new Timer();
                timer.Interval = (int) TimeSpan.FromMinutes(1).TotalMilliseconds;

                timer.Tick += (s, ev) => {
                    Clipboard.Clear();
                };

                Clipboard.SetText(generator.generate());
                timer.Start();
            });

            MenuItem[] items = { config, gen, ExitMenu };
            ContextMenu menu = new ContextMenu(items);

            this.notifyIcon.ContextMenu = menu;
            this.notifyIcon.Visible = true;
        }

        private void LoadConfiguration(Configuration configuration)
        {
            //
        }
    }
}
