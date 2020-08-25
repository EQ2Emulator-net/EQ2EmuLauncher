namespace EQ2EmuLauncher
{
    partial class CharacterSettings
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(330, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonGreen;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(76, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonGreen;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(20, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Location = new System.Drawing.Point(20, 20);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(375, 21);
            this.cmbCharacter.TabIndex = 0;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(20, 233);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(375, 20);
            this.txtCharacterName.TabIndex = 6;
            this.txtCharacterName.Visible = false;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacterName.Location = new System.Drawing.Point(16, 211);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(113, 19);
            this.lblCharacterName.TabIndex = 17;
            this.lblCharacterName.Text = "Character Name:";
            this.lblCharacterName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(16, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAccount.Location = new System.Drawing.Point(16, 165);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(63, 19);
            this.lblAccount.TabIndex = 13;
            this.lblAccount.Text = "Account:";
            this.lblAccount.Visible = false;
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(20, 187);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(375, 21);
            this.cmbAccounts.TabIndex = 5;
            this.cmbAccounts.Visible = false;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(20, 278);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(375, 20);
            this.txtServer.TabIndex = 7;
            this.txtServer.Visible = false;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Transparent;
            this.lblServer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblServer.Location = new System.Drawing.Point(16, 256);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(52, 19);
            this.lblServer.TabIndex = 20;
            this.lblServer.Text = "Server:";
            this.lblServer.Visible = false;
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSave.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonGreen;
            this.btnAddSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSave.FlatAppearance.BorderSize = 0;
            this.btnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSave.Location = new System.Drawing.Point(345, 331);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(50, 30);
            this.btnAddSave.TabIndex = 9;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Visible = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonRed;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(20, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSave.BackgroundImage = global::EQ2EmuLauncher.Resources.ButtonGreen;
            this.btnEditSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSave.FlatAppearance.BorderSize = 0;
            this.btnEditSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditSave.Location = new System.Drawing.Point(345, 331);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(50, 30);
            this.btnEditSave.TabIndex = 10;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = false;
            this.btnEditSave.Visible = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // CharacterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EQ2EmuLauncher.Resources.news_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.cmbCharacter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "CharacterSettings";
            this.Size = new System.Drawing.Size(415, 381);
            this.Load += new System.EventHandler(this.CharacterSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCharacter;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditSave;
    }
}
