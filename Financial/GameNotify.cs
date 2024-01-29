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
    public partial class GameNotify : Form
    {
        string message;
        public GameNotify(string msg)
        {
            InitializeComponent();
            timer1.Start();
            message = msg;
            lblMessage.Text = message.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
