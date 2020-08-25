namespace EQ2EmuLauncher
{
    partial class Options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnCharacters = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClients.Location = new System.Drawing.Point(3, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(132, 32);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccounts.Location = new System.Drawing.Point(3, 50);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(132, 32);
            this.btnAccounts.TabIndex = 1;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnCharacters
            // 
            this.btnCharacters.BackColor = System.Drawing.Color.Transparent;
            this.btnCharacters.FlatAppearance.BorderSize = 0;
            this.btnCharacters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCharacters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCharacters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacters.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharacters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCharacters.Location = new System.Drawing.Point(3, 88);
            this.btnCharacters.Name = "btnCharacters";
            this.btnCharacters.Size = new System.Drawing.Size(144, 32);
            this.btnCharacters.TabIndex = 2;
            this.btnCharacters.Text = "Characters";
            this.btnCharacters.UseVisualStyleBackColor = false;
            this.btnCharacters.Click += new System.EventHandler(this.btnCharacters_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDone.Location = new System.Drawing.Point(3, 346);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(132, 32);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::EQ2EmuLauncher.Resources.action_menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCharacters);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnClients);
            this.DoubleBuffered = true;
            this.Name = "Options";
            this.Size = new System.Drawing.Size(150, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnCharacters;
        private System.Windows.Forms.Button btnDone;
    }
}
