namespace BOG.LumberghMessageBox
{
    partial class frmLumbergMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLumbergMessageBox));
			this.btnOK = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(12, 214);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(580, 33);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "&Go Away";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(259, 183);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtMessage
			// 
			this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMessage.Location = new System.Drawing.Point(292, 12);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(300, 183);
			this.txtMessage.TabIndex = 4;
			this.txtMessage.Click += new System.EventHandler(this.txtMessage_Click);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "LumberghArrives");
			this.imageList1.Images.SetKeyName(1, "LumberghOK");
			this.imageList1.Images.SetKeyName(2, "LumberghTimeout");
			this.imageList1.Images.SetKeyName(3, "LumberghNoResponse");
			// 
			// frmLumbergMessageBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(599, 253);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLumbergMessageBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Hello there, Peter..";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLumbergMessageBox_FormClosing);
			this.Click += new System.EventHandler(this.frmLumbergMessageBox_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList1;
    }
}