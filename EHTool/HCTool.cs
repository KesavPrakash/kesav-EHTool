using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace EHTool
{
    public partial class HCTool : Form
    {
        public HCTool()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;
            Dictionary<string, string> dictConfig = settings.AllKeys.ToDictionary(key => key, key => settings[key].Value);


            for (int i = 0; i < dictConfig.Count; i++)
            {
                var btn = new Button();
                string val = "";
                val = dictConfig.ElementAt(i).Value == "false" ? "OFF" : "ON";

                btn.Text = dictConfig.ElementAt(i).Key + ":" + val;
                btn.Name = dictConfig.ElementAt(i).Value;
                btn.Size = new Size(300, 50);
                btn.Location = new Point(20, 50 * i + 10);
                btn.BackColor = System.Drawing.Color.Green;

                if (btn.Name == "true")
                {
                    btn.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    btn.BackColor = System.Drawing.Color.Red;
                }

                //Hook our button up to our generic button handler
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null)
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                string trimtext = b.Text.Substring(0, b.Text.IndexOf(":"));
                string val = "";
                string val_on_off = "";

                if (b.Name == "false")
                {
                    val_on_off = "ON";
                    b.Name = val = "true";
                    b.BackColor = System.Drawing.Color.Green;
                    b.Text = trimtext + ":" + val_on_off;

                }
                else
                {
                    val_on_off = "OFF";
                    b.BackColor = System.Drawing.Color.Red;
                    b.Name = val = "false";
                    b.Text = trimtext + ":" + val_on_off;
                }
                config.AppSettings.Settings[trimtext].Value = val;
                config.Save(ConfigurationSaveMode.Modified, true);
                config.SaveAs(@"C:\Users\ekesmxx\source\repos\TallinSample\TallinSample\App.config", ConfigurationSaveMode.Modified, true);

                ConfigurationManager.RefreshSection("appSettings");
                b.Refresh();
            }
        }
    }

}
