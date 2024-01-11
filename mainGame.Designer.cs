namespace Mastermind_WindowsForms
{
    partial class mainGame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGame));
            this.boxRedSelect = new System.Windows.Forms.Button();
            this.boxGreenSelect = new System.Windows.Forms.Button();
            this.boxBlueSelect = new System.Windows.Forms.Button();
            this.boxYellowSelect = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.checkCode = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.boxLightSkyBlueSelect = new System.Windows.Forms.Button();
            this.boxOrangeSelect = new System.Windows.Forms.Button();
            this.boxPurpleSelect = new System.Windows.Forms.Button();
            this.lblExplain1 = new System.Windows.Forms.Button();
            this.lblExplain2 = new System.Windows.Forms.Button();
            this.lblExplain3 = new System.Windows.Forms.Button();
            this.lblTxtExplain1 = new System.Windows.Forms.Label();
            this.lblTxtExplain2 = new System.Windows.Forms.Label();
            this.lblTxtExplain3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxRedSelect
            // 
            this.boxRedSelect.BackColor = System.Drawing.Color.Red;
            this.boxRedSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxRedSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxRedSelect.ForeColor = System.Drawing.Color.Red;
            this.boxRedSelect.Location = new System.Drawing.Point(308, 45);
            this.boxRedSelect.Name = "boxRedSelect";
            this.boxRedSelect.Size = new System.Drawing.Size(21, 21);
            this.boxRedSelect.TabIndex = 7;
            this.boxRedSelect.UseVisualStyleBackColor = false;
            this.boxRedSelect.Click += new System.EventHandler(this.boxRedSelect_Click);
            // 
            // boxGreenSelect
            // 
            this.boxGreenSelect.BackColor = System.Drawing.Color.Lime;
            this.boxGreenSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxGreenSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxGreenSelect.ForeColor = System.Drawing.Color.Lime;
            this.boxGreenSelect.Location = new System.Drawing.Point(335, 31);
            this.boxGreenSelect.Name = "boxGreenSelect";
            this.boxGreenSelect.Size = new System.Drawing.Size(21, 21);
            this.boxGreenSelect.TabIndex = 8;
            this.boxGreenSelect.UseVisualStyleBackColor = false;
            this.boxGreenSelect.Click += new System.EventHandler(this.boxGreenSelect_Click);
            // 
            // boxBlueSelect
            // 
            this.boxBlueSelect.BackColor = System.Drawing.Color.Blue;
            this.boxBlueSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxBlueSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxBlueSelect.ForeColor = System.Drawing.Color.Blue;
            this.boxBlueSelect.Location = new System.Drawing.Point(362, 31);
            this.boxBlueSelect.Name = "boxBlueSelect";
            this.boxBlueSelect.Size = new System.Drawing.Size(21, 21);
            this.boxBlueSelect.TabIndex = 9;
            this.boxBlueSelect.UseVisualStyleBackColor = false;
            this.boxBlueSelect.Click += new System.EventHandler(this.boxBlueSelect_Click);
            // 
            // boxYellowSelect
            // 
            this.boxYellowSelect.BackColor = System.Drawing.Color.Yellow;
            this.boxYellowSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxYellowSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxYellowSelect.ForeColor = System.Drawing.Color.Gold;
            this.boxYellowSelect.Location = new System.Drawing.Point(335, 58);
            this.boxYellowSelect.Name = "boxYellowSelect";
            this.boxYellowSelect.Size = new System.Drawing.Size(21, 21);
            this.boxYellowSelect.TabIndex = 10;
            this.boxYellowSelect.UseVisualStyleBackColor = false;
            this.boxYellowSelect.Click += new System.EventHandler(this.boxYellowSelect_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(392, 69);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(48, 24);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Location = new System.Drawing.Point(392, 39);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(48, 24);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // checkCode
            // 
            this.checkCode.AutoSize = true;
            this.checkCode.Location = new System.Drawing.Point(271, 356);
            this.checkCode.Name = "checkCode";
            this.checkCode.Size = new System.Drawing.Size(51, 17);
            this.checkCode.TabIndex = 16;
            this.checkCode.Text = "Code";
            this.checkCode.UseVisualStyleBackColor = true;
            this.checkCode.CheckedChanged += new System.EventHandler(this.checkCode_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // boxLightSkyBlueSelect
            // 
            this.boxLightSkyBlueSelect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.boxLightSkyBlueSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxLightSkyBlueSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLightSkyBlueSelect.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.boxLightSkyBlueSelect.Location = new System.Drawing.Point(308, 72);
            this.boxLightSkyBlueSelect.Name = "boxLightSkyBlueSelect";
            this.boxLightSkyBlueSelect.Size = new System.Drawing.Size(21, 21);
            this.boxLightSkyBlueSelect.TabIndex = 23;
            this.boxLightSkyBlueSelect.UseVisualStyleBackColor = false;
            this.boxLightSkyBlueSelect.Click += new System.EventHandler(this.boxSkyBlueSelect_Click);
            // 
            // boxOrangeSelect
            // 
            this.boxOrangeSelect.BackColor = System.Drawing.Color.Orange;
            this.boxOrangeSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxOrangeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxOrangeSelect.ForeColor = System.Drawing.Color.Orange;
            this.boxOrangeSelect.Location = new System.Drawing.Point(362, 85);
            this.boxOrangeSelect.Name = "boxOrangeSelect";
            this.boxOrangeSelect.Size = new System.Drawing.Size(21, 21);
            this.boxOrangeSelect.TabIndex = 24;
            this.boxOrangeSelect.UseVisualStyleBackColor = false;
            this.boxOrangeSelect.Click += new System.EventHandler(this.boxOrangeSelect_Click);
            // 
            // boxPurpleSelect
            // 
            this.boxPurpleSelect.BackColor = System.Drawing.Color.Purple;
            this.boxPurpleSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxPurpleSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxPurpleSelect.ForeColor = System.Drawing.Color.Purple;
            this.boxPurpleSelect.Location = new System.Drawing.Point(335, 85);
            this.boxPurpleSelect.Name = "boxPurpleSelect";
            this.boxPurpleSelect.Size = new System.Drawing.Size(21, 21);
            this.boxPurpleSelect.TabIndex = 25;
            this.boxPurpleSelect.UseVisualStyleBackColor = false;
            this.boxPurpleSelect.Click += new System.EventHandler(this.boxPurpleSelect_Click);
            // 
            // lblExplain1
            // 
            this.lblExplain1.BackColor = System.Drawing.Color.Green;
            this.lblExplain1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExplain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExplain1.ForeColor = System.Drawing.Color.Green;
            this.lblExplain1.Location = new System.Drawing.Point(335, 192);
            this.lblExplain1.Name = "lblExplain1";
            this.lblExplain1.Size = new System.Drawing.Size(21, 21);
            this.lblExplain1.TabIndex = 26;
            this.lblExplain1.UseVisualStyleBackColor = false;
            // 
            // lblExplain2
            // 
            this.lblExplain2.BackColor = System.Drawing.Color.Red;
            this.lblExplain2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExplain2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExplain2.ForeColor = System.Drawing.Color.Red;
            this.lblExplain2.Location = new System.Drawing.Point(335, 138);
            this.lblExplain2.Name = "lblExplain2";
            this.lblExplain2.Size = new System.Drawing.Size(21, 21);
            this.lblExplain2.TabIndex = 27;
            this.lblExplain2.UseVisualStyleBackColor = false;
            // 
            // lblExplain3
            // 
            this.lblExplain3.BackColor = System.Drawing.Color.Gold;
            this.lblExplain3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExplain3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExplain3.ForeColor = System.Drawing.Color.Orange;
            this.lblExplain3.Location = new System.Drawing.Point(335, 165);
            this.lblExplain3.Name = "lblExplain3";
            this.lblExplain3.Size = new System.Drawing.Size(21, 21);
            this.lblExplain3.TabIndex = 28;
            this.lblExplain3.UseVisualStyleBackColor = false;
            // 
            // lblTxtExplain1
            // 
            this.lblTxtExplain1.AutoSize = true;
            this.lblTxtExplain1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtExplain1.Location = new System.Drawing.Point(362, 140);
            this.lblTxtExplain1.Name = "lblTxtExplain1";
            this.lblTxtExplain1.Size = new System.Drawing.Size(45, 16);
            this.lblTxtExplain1.TabIndex = 29;
            this.lblTxtExplain1.Text = "Wrong";
            // 
            // lblTxtExplain2
            // 
            this.lblTxtExplain2.AutoSize = true;
            this.lblTxtExplain2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtExplain2.Location = new System.Drawing.Point(362, 167);
            this.lblTxtExplain2.Name = "lblTxtExplain2";
            this.lblTxtExplain2.Size = new System.Drawing.Size(37, 16);
            this.lblTxtExplain2.TabIndex = 30;
            this.lblTxtExplain2.Text = "Exist";
            // 
            // lblTxtExplain3
            // 
            this.lblTxtExplain3.AutoSize = true;
            this.lblTxtExplain3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtExplain3.Location = new System.Drawing.Point(362, 194);
            this.lblTxtExplain3.Name = "lblTxtExplain3";
            this.lblTxtExplain3.Size = new System.Drawing.Size(49, 16);
            this.lblTxtExplain3.TabIndex = 31;
            this.lblTxtExplain3.Text = "Correct";
            // 
            // mainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 413);
            this.Controls.Add(this.lblTxtExplain3);
            this.Controls.Add(this.lblTxtExplain2);
            this.Controls.Add(this.lblTxtExplain1);
            this.Controls.Add(this.lblExplain3);
            this.Controls.Add(this.lblExplain2);
            this.Controls.Add(this.lblExplain1);
            this.Controls.Add(this.boxPurpleSelect);
            this.Controls.Add(this.boxOrangeSelect);
            this.Controls.Add(this.boxLightSkyBlueSelect);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkCode);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.boxYellowSelect);
            this.Controls.Add(this.boxBlueSelect);
            this.Controls.Add(this.boxGreenSelect);
            this.Controls.Add(this.boxRedSelect);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainGame";
            this.Text = "𝗠𝗮𝘀𝘁𝗲𝗿𝗠𝗶𝗻𝗱";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGame_FormClosing);
            this.Load += new System.EventHandler(this.mainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button boxRedSelect;
        private System.Windows.Forms.Button boxGreenSelect;
        private System.Windows.Forms.Button boxBlueSelect;
        private System.Windows.Forms.Button boxYellowSelect;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.CheckBox checkCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button boxLightSkyBlueSelect;
        private System.Windows.Forms.Button boxOrangeSelect;
        private System.Windows.Forms.Button boxPurpleSelect;
        private System.Windows.Forms.Button lblExplain1;
        private System.Windows.Forms.Button lblExplain2;
        private System.Windows.Forms.Button lblExplain3;
        private System.Windows.Forms.Label lblTxtExplain1;
        private System.Windows.Forms.Label lblTxtExplain2;
        private System.Windows.Forms.Label lblTxtExplain3;
    }
}

