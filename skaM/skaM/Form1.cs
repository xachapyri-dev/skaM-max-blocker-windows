using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace skaM
{
    public partial class Form1 : Form
    {
        private readonly List<string> ProcessNames = new List<string> { "max.exe" };
        private const string regditPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\";
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.IsOn == true)
            {
                this.BackgroundImage = Properties.Resources.Yes;
                guna2ToggleSwitch1.Checked = true;
                guna2HtmlLabel3.Text = "Приложение заблокировано!";
            }
            else
            {
                this.BackgroundImage = Properties.Resources.No;
                guna2ToggleSwitch1.Checked = false;
                guna2HtmlLabel3.Text = "За вами следят через MAX!";
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ToggleSwitch1_MouseClick(object sender, MouseEventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                this.BackgroundImage = Properties.Resources.Yes;
                Properties.Settings.Default.IsOn = true;
                Properties.Settings.Default.Save();
                guna2HtmlLabel3.Text = "Приложение заблокировано!";
                try
                {
                    foreach (var processName in ProcessNames)
                    {
                        string FullPathRegedit = regditPath + processName;

                        // Попробуйте использовать HKEY_LOCAL_MACHINE
                        using (RegistryKey key = Registry.LocalMachine.CreateSubKey(FullPathRegedit))
                        {
                            if (key != null)
                            {
                                key.SetValue("Debugger", "nuke.exe", RegistryValueKind.String);
                                MessageBox.Show($"Успешно установлен отладчик для {processName}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Не удалось создать раздел реестра для {processName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.BackgroundImage = Properties.Resources.No;
                                Properties.Settings.Default.IsOn = false;
                                Properties.Settings.Default.Save();
                                guna2HtmlLabel3.Text = "За вами следят через MAX!";
                                guna2ToggleSwitch1.Checked = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackgroundImage = Properties.Resources.No;
                    Properties.Settings.Default.IsOn = false;
                    Properties.Settings.Default.Save();
                    guna2HtmlLabel3.Text = "За вами следять через MAX!";
                    guna2ToggleSwitch1.Checked = false;
                }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.No;
                Properties.Settings.Default.IsOn = false;
                Properties.Settings.Default.Save();
                guna2HtmlLabel3.Text = "За вами следят через MAX!";
                try
                {
                    foreach (var processName in ProcessNames)
                    {
                        string FullPathRegedit = regditPath + processName;

                        // Попробуем открыть ключ. Если его нет, вернется null
                        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(FullPathRegedit, true))
                        {
                            if (key != null)
                            {
                                // Ключ найден. Теперь удаляем его.
                                key.Close(); // Закрываем ключ перед удалением
                                Registry.LocalMachine.DeleteSubKey(FullPathRegedit, false);
                                MessageBox.Show($"Успешно удалена блокировка для {processName}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Ключ не найден, значит, его и не нужно удалять
                                MessageBox.Show($"Блокировка для {processName} уже была удалена или не существовала.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackgroundImage = Properties.Resources.Yes;
                    Properties.Settings.Default.IsOn = true;
                    Properties.Settings.Default.Save();
                    guna2HtmlLabel3.Text = "Приложение заблокировано!";
                    guna2ToggleSwitch1.Checked = true;
                }
            }
        }
    }
}
/*MessageBox.Show($"Произошла ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/