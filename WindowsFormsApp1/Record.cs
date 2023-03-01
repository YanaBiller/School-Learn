using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.schoolDataSet.Service);
            this.clientTableAdapter.Fill(this.schoolDataSet1.Client);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];

            mainForm.Show();

            this.Close();
        }

        public int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60;
        }

        private void endLessonButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(startLessonHr.Text);
            min = Convert.ToInt32(startLessonMin.Text);
            sec = TimeInSeconds(ch, min);
            int dur = Convert.ToInt32(Duration.Text);
            sec = sec + dur;
            endLessonHr.Text = Convert.ToString((sec / 3600));
            sec = sec % 3600;
            endLessonMin.Text = Convert.ToString((sec / 60));
        }

    }
}
