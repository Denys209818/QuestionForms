using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.WindowsForm
{
    public partial class ResultForm : Form
    {
        private int MaxQuest { get; set; }
        private int TrueQuest { get; set; }
        private int Mark { get; set; }

        public ResultForm(int maxQuest, int trueQuest)
        {
            this.Mark = (int)Math.Ceiling(((double)trueQuest / maxQuest)*12);
            this.MaxQuest = maxQuest;
            this.TrueQuest = trueQuest;
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.lblAllQuest.Text += " " + MaxQuest;
            this.lblTrueQuest.Text += " " + TrueQuest;
            this.lblMark.Text += " " + Mark;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;

            settings.Clear();
            settings.Add("mark", this.Mark.ToString());
            config.Save();
            MessageBox.Show("Оцінку збережено!");
        }
    }
}
