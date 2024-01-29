using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial
{
    public partial class frmNotification : Form
    {
        public frmNotification()
        {
            InitializeComponent();
            timer1.Start();
        }
        public void ShowNotification(string title, string message, string Icon)
        {
            try
            {
                if (Icon.ToLower() == "error")
                {
                    pictureBox1.Image = Properties.Resources.warning;
                    panelColor.BackColor = Color.FromArgb(247, 64, 94);
                    lblTitle.Text = title;
                    lblMessage.Text = message;
                    this.ShowDialog();
                }
                else if (Icon.ToLower() == "info")
                {
                    pictureBox1.Image = Properties.Resources.info;
                    //panelColor.BackColor = Color.FromArgb(239, 243, 244);
                    lblTitle.Text = title;
                    lblMessage.Text = message;
                    this.ShowDialog();
                }
                else if (Icon.ToLower() == "question")
                {
                    pictureBox1.Image = Properties.Resources.Question;
                    //panelColor.BackColor = Color.FromArgb(239, 243, 244);
                    lblTitle.Text = title;
                    lblMessage.Text = message;
                    this.ShowDialog();
                }
                else
                {
                    this.Dispose();
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
