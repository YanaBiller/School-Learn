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
	public partial class Form1 : Form
	{
       
		public Form1()
		{
			InitializeComponent();
		}

        private void disableEnableAllButtons(bool enable = false)
        {
            ViewButton.Enabled = enable;
            ClientRecord.Enabled = enable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.schoolDataSet.Service);

            disableEnableAllButtons();
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text == "0000")
            {
                disableEnableAllButtons(true);
            } else
            {
                MessageBox.Show("Incorrect passoword!");
            } 
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            View viewForm  = new View();

            viewForm.Show();

            this.Hide();
        }

        private void ClientRecord_Click(object sender, EventArgs e)
        {
            Record clientRecordView = new Record();

            clientRecordView.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();

            editForm.Show();

            this.Hide();
        }
    }
}
