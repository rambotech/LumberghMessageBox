using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOG.LumberghMessageBox
{
    public partial class frmLumbergMessageBox : Form
    {
        string _Message = string.Empty;
        int _InitialTimeout = 10000;
        int _FinalTimeout = 10000;

        bool IsClosing = false;
        bool HadWhatDoYaSay = false;
        bool UseFinalTimeOut = false;
        System.ComponentModel.ComponentResourceManager resources;

        public frmLumbergMessageBox(string message)
        {
            _Message = message;
            FormInitialize();
        }
        public frmLumbergMessageBox(string message, int initialTimeoutMS, int FinalTimeoutMS)
        {
            _Message = message;
            _InitialTimeout = initialTimeoutMS;
            _FinalTimeout = FinalTimeoutMS;
            FormInitialize();
        }

        private void FormInitialize()
        {
            InitializeComponent();
            resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLumbergMessageBox));
            this.txtMessage.Text = string.Format(
                "If you could just {0}{1}, that would be great!\r\n\r\nOkay?",
                _Message.Length == 0 ? string.Empty : _Message.Substring(0,1).ToLower(),
				_Message.Length == 1 ? string.Empty : _Message.Substring(1));
            this.pictureBox1.Image = imageList1.Images["LumberghArrives"];
            timer2.Interval = _InitialTimeout;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLumbergMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (! IsClosing)
            {
                timer2.Stop();
                timer2.Enabled = false;
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    this.Width = this.ClientSize.Width - this.txtMessage.Location.X;
                    this.Height = (this.Height - this.ClientSize.Height) + this.btnOK.Location.Y;
                    if (UseFinalTimeOut)
                    {
                        this.pictureBox1.Image = imageList1.Images["LumberghTimeout"];
                        this.Text = "Yaaaaaaaaahhhh ...";
						this.timer1.Interval = 5000;
					}
					else
                    {
                        this.pictureBox1.Image = imageList1.Images["LumberghOK"];
                        this.Text = "OK ... Thanks ...";
						this.timer1.Interval = 2000;
					}
					this.btnOK.Visible = false;
                    this.txtMessage.Visible = false;
                    IsClosing = true;
                    e.Cancel = true;
                    this.timer1.Start();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLumbergMessageBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Enabled = false;
            if (HadWhatDoYaSay)
            {
                UseFinalTimeOut = true;
                this.Close();
                return;
            }
            this.Text = "?";
			this.txtMessage.Text = "So what do ya say, Peter? ...\r\n\r\n" + this.txtMessage.Text;
			this.pictureBox1.Image = imageList1.Images["LumberghNoResponse"];
			HadWhatDoYaSay = true;
            timer2.Interval = _FinalTimeout;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            if (IsClosing)
            {
                // close the form, which will start the shutdown of the application.
                this.Close();
                return;
            }
        }
    }
}
