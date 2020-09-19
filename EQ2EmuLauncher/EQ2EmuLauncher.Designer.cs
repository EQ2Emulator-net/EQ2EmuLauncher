namespace EQ2EmuLauncher
{
    partial class EQ2EmuLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQ2EmuLauncher));
            this.btnEmu = new System.Windows.Forms.Button();
            this.btnLive = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.cbUseLauncher = new System.Windows.Forms.CheckBox();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmu
            // 
            this.btnEmu.Location = new System.Drawing.Point(310, 187);
            this.btnEmu.Name = "btnEmu";
            this.btnEmu.Size = new System.Drawing.Size(52, 23);
            this.btnEmu.TabIndex = 3;
            this.btnEmu.Text = "Emu";
            this.btnEmu.UseVisualStyleBackColor = true;
            this.btnEmu.Click += new System.EventHandler(this.btnEmu_Click);
            // 
            // btnLive
            // 
            this.btnLive.Location = new System.Drawing.Point(368, 187);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(49, 23);
            this.btnLive.TabIndex = 4;
            this.btnLive.Text = "Live";
            this.btnLive.UseVisualStyleBackColor = true;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonTest;
            this.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaunch.FlatAppearance.BorderSize = 0;
            this.btnLaunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Menuetto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaunch.Location = new System.Drawing.Point(657, 575);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(205, 47);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbClients
            // 
            this.cmbClients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(310, 162);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(239, 21);
            this.cmbClients.TabIndex = 5;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(423, 187);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(65, 23);
            this.btnLocal.TabIndex = 6;
            this.btnLocal.Text = "Localhost";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(494, 187);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(55, 23);
            this.btnCustom.TabIndex = 7;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::EQ2EmuLauncher.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(837, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(564, 162);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(145, 21);
            this.cmbAccounts.TabIndex = 9;
            this.cmbAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbAccounts_SelectedIndexChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::EQ2EmuLauncher.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(806, 31);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // cbUseLauncher
            // 
            this.cbUseLauncher.AutoSize = true;
            this.cbUseLauncher.BackColor = System.Drawing.Color.Transparent;
            this.cbUseLauncher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbUseLauncher.Location = new System.Drawing.Point(657, 552);
            this.cbUseLauncher.Name = "cbUseLauncher";
            this.cbUseLauncher.Size = new System.Drawing.Size(205, 17);
            this.cbUseLauncher.TabIndex = 13;
            this.cbUseLauncher.Text = "Use launcher when connecting to live";
            this.cbUseLauncher.UseVisualStyleBackColor = false;
            this.cbUseLauncher.CheckedChanged += new System.EventHandler(this.cbUseLauncher_CheckedChanged);
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(717, 162);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(145, 21);
            this.cmbCharacters.TabIndex = 17;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.BackgroundImage = global::EQ2EmuLauncher.Resources.options;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(310, 540);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(59, 32);
            this.btnOptions.TabIndex = 18;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // EQ2EmuLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(897, 667);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.cmbCharacters);
            this.Controls.Add(this.cbUseLauncher);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.btnLive);
            this.Controls.Add(this.btnEmu);
            this.Controls.Add(this.btnLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EQ2EmuLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQ2Emu Launcher";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(220)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EQ2EmuLauncher_FormClosed);
            this.Load += new System.EventHandler(this.EQ2EmuLauncher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EQ2EmuLauncher_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnEmu;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.CheckBox cbUseLauncher;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Button btnOptions;
    }
}

