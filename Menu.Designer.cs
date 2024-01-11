namespace Mastermind_WindowsForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.gameBtn = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBtn
            // 
            this.gameBtn.BackColor = System.Drawing.SystemColors.Control;
            this.gameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameBtn.Location = new System.Drawing.Point(133, 303);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(200, 48);
            this.gameBtn.TabIndex = 0;
            this.gameBtn.Text = "Start";
            this.gameBtn.UseVisualStyleBackColor = false;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.InitialImage")));
            this.pctLogo.Location = new System.Drawing.Point(22, -6);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(439, 264);
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 413);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.gameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "𝗠𝗮𝘀𝘁𝗲𝗿𝗠𝗶𝗻𝗱";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gameBtn;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}