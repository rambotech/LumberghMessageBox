namespace BOG.LumberghMessageBox
{
    partial class Form1
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
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblLumbergh = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnLumbergh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Location = new System.Drawing.Point(27, 23);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(267, 15);
            this.lblNormal.TabIndex = 0;
            this.lblNormal.Text = "Your standard message box just looks like this...";
            // 
            // lblLumbergh
            // 
            this.lblLumbergh.AutoSize = true;
            this.lblLumbergh.Location = new System.Drawing.Point(27, 195);
            this.lblLumbergh.Name = "lblLumbergh";
            this.lblLumbergh.Size = new System.Drawing.Size(166, 15);
            this.lblLumbergh.TabIndex = 1;
            this.lblLumbergh.Text = "But if you add a little Bill to it...";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(66, 95);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(176, 33);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.Text = "&Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnLumbergh
            // 
            this.btnLumbergh.Location = new System.Drawing.Point(66, 280);
            this.btnLumbergh.Name = "btnLumbergh";
            this.btnLumbergh.Size = new System.Drawing.Size(176, 33);
            this.btnLumbergh.TabIndex = 3;
            this.btnLumbergh.Text = "&Lumbergh";
            this.btnLumbergh.UseVisualStyleBackColor = true;
            this.btnLumbergh.Click += new System.EventHandler(this.btnLumbergh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 398);
            this.Controls.Add(this.btnLumbergh);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.lblLumbergh);
            this.Controls.Add(this.lblNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblLumbergh;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnLumbergh;
    }
}

