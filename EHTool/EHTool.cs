using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace EHTool
{
    public partial class EHTool : Form
    {
        public EHTool()
        {
            InitializeComponent();
        }

        static string defaultSysConfigFilePath = AppDomain.CurrentDomain.BaseDirectory;
        static string SysConfigFilePath = defaultSysConfigFilePath.Substring(0, defaultSysConfigFilePath.IndexOf("bin\\Debug")) + "App.config";
        public static Configuration config { get; set; }
        public static Dictionary<string, string> dictConfig { get; set; }
        string configkey { get; set; }
        string configvalue { get; set; }
        string setbuttontext { get; set; }

        #region Privatemethods
        public List<Control> GetAllControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type).ToList();
        }

        public void loadbuttons()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;
            dictConfig = settings.AllKeys.ToDictionary(key => key, key => settings[key].Value);

            for (int i = 0; i < dictConfig.Count; i++)
            {
                configkey = dictConfig.ElementAt(i).Key;
                configvalue = dictConfig.ElementAt(i).Value;

                List<Control> btnproperties = GetAllControls(this, typeof(Button));

                for (int j = 0; j < btnproperties.Count; j++)
                {
                    if (btnproperties[j].Text.Contains(configkey))
                    {
                        setbuttontext = configvalue == "false" ? "OFF" : "ON";
                        btnproperties[j].Text = configkey + ": " + setbuttontext;
                        if (configvalue == "true")
                        {
                            btnproperties[j].BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            btnproperties[j].BackColor = System.Drawing.Color.Red;
                        }
                    }
                }

            }
        }

        public void updateconfigfile(string sconfigKey, string sconfigValue, string btntext = null)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (sconfigKey == null && sconfigValue == null)
            {
                config.AppSettings.Settings.Add(btntext, "true");
            }
            else
            {
                string configvalupdate = sconfigValue == "true" ? "false" : "true";
                config.AppSettings.Settings[sconfigKey].Value = configvalupdate;
            }
            config.Save(ConfigurationSaveMode.Modified, true);
            config.SaveAs(SysConfigFilePath, ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void openConfigurarionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            while (!String.Equals(Path.GetExtension(filename), ".config", StringComparison.OrdinalIgnoreCase))
            {
                openFileDialog1.Title = "Browse config Files";
                openFileDialog1.ShowDialog();
                filename = openFileDialog1.FileName;

                if (!String.Equals(Path.GetExtension(filename), ".config", StringComparison.OrdinalIgnoreCase))
                    MessageBox.Show("Choose config files only.");
            }

            string xmlString = System.IO.File.ReadAllText(filename);
            File.WriteAllText(SysConfigFilePath, xmlString);

            string localconfigpath = defaultSysConfigFilePath.Substring(0, defaultSysConfigFilePath.IndexOf("bin\\Debug")) + "\\configfiles\\EH.config";
            File.WriteAllText(localconfigpath, xmlString);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("File saved path :" + localconfigpath + "              Please re-run the appliaction to view result", "Are you sure", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        KeyValuePair<string, string> btntexttrimed(string btnTexts)
        {
            string trimtext = "";
            if (btnTexts.Contains(":"))
            {
                trimtext = btnTexts.Substring(0, btnTexts.IndexOf(":"));
            }
            else
            {
                trimtext = btnTexts;
            }

            var val = dictConfig.Where(a => a.Key == trimtext).SingleOrDefault();
            return val;
        }

        #endregion

        #region Formmethods

        private void EHTool_Load(object sender, EventArgs e)
        {
            string dd = Path.GetDirectoryName(Application.ExecutablePath);


            loadbuttons();
        }

        private void btn1Abort_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn1Abort.Text);
            updateconfigfile(val.Key, val.Value, btn1Abort.Text);

            loadbuttons();
        }

        private void btn2Startautomation_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn2Startautomation.Text);
            updateconfigfile(val.Key, val.Value, btn2Startautomation.Text);

            loadbuttons();
        }

        private void btn3Pause_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn3Pause.Text);
            updateconfigfile(val.Key, val.Value, btn3Pause.Text);

            loadbuttons();
        }

        private void btn4Continuemanual_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn4Continuemanual.Text);
            updateconfigfile(val.Key, val.Value, btn4Continuemanual.Text);

            loadbuttons();
        }

        private void btn5ValidateDutid_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn5ValidateDutid.Text);
            updateconfigfile(val.Key, val.Value, btn5ValidateDutid.Text);

            loadbuttons();
        }

        private void btn6Pauseonfailed_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn6Pauseonfailed.Text);
            updateconfigfile(val.Key, val.Value, btn6Pauseonfailed.Text);

            loadbuttons();
        }

        private void btn7Savetestrecord_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn7Savetestrecord.Text);
            updateconfigfile(val.Key, val.Value, btn7Savetestrecord.Text);

            loadbuttons();
        }

        private void btnManualmode_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btnManualmode.Text);
            updateconfigfile(val.Key, val.Value, btnManualmode.Text);

            loadbuttons();
        }

        private void btn9Startoperarator_Click(object sender, EventArgs e)
        {
            var val = btntexttrimed(btn9Startoperarator.Text);
            updateconfigfile(val.Key, val.Value, btn9Startoperarator.Text);
            loadbuttons();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HCTool hc = new HCTool();
            hc.Show();
        }
        #endregion
    }
}
