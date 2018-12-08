namespace TextFileChallenge
{
    partial class ChallengeForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.agePicker = new System.Windows.Forms.NumericUpDown();
            this.isAliveLabel = new System.Windows.Forms.Label();
            this.isAliveCheckbox = new System.Windows.Forms.CheckBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.saveListButton = new System.Windows.Forms.Button();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbAdvanced = new System.Windows.Forms.RadioButton();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(26, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(546, 69);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Text File Challenge";
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 36;
            this.usersListBox.Location = new System.Drawing.Point(465, 119);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(405, 364);
            this.usersListBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(34, 119);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(166, 36);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(188, 116);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(236, 41);
            this.firstNameText.TabIndex = 3;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(188, 181);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(236, 41);
            this.lastNameText.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(34, 184);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(164, 36);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(34, 250);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(77, 36);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age:";
            // 
            // agePicker
            // 
            this.agePicker.Location = new System.Drawing.Point(188, 248);
            this.agePicker.Name = "agePicker";
            this.agePicker.Size = new System.Drawing.Size(89, 41);
            this.agePicker.TabIndex = 7;
            // 
            // isAliveLabel
            // 
            this.isAliveLabel.AutoSize = true;
            this.isAliveLabel.Location = new System.Drawing.Point(34, 314);
            this.isAliveLabel.Name = "isAliveLabel";
            this.isAliveLabel.Size = new System.Drawing.Size(120, 36);
            this.isAliveLabel.TabIndex = 8;
            this.isAliveLabel.Text = "Is Alive:";
            // 
            // isAliveCheckbox
            // 
            this.isAliveCheckbox.AutoSize = true;
            this.isAliveCheckbox.Location = new System.Drawing.Point(188, 324);
            this.isAliveCheckbox.Name = "isAliveCheckbox";
            this.isAliveCheckbox.Size = new System.Drawing.Size(18, 17);
            this.isAliveCheckbox.TabIndex = 9;
            this.isAliveCheckbox.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(34, 385);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(390, 64);
            this.addUserButton.TabIndex = 10;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(34, 455);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(390, 64);
            this.saveListButton.TabIndex = 11;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(465, 497);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(157, 40);
            this.rbStandard.TabIndex = 12;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.policyRadioButtons_CheckedChanged);
            // 
            // rbAdvanced
            // 
            this.rbAdvanced.AutoSize = true;
            this.rbAdvanced.Location = new System.Drawing.Point(465, 543);
            this.rbAdvanced.Name = "rbAdvanced";
            this.rbAdvanced.Size = new System.Drawing.Size(170, 40);
            this.rbAdvanced.TabIndex = 13;
            this.rbAdvanced.TabStop = true;
            this.rbAdvanced.Text = "Advanced";
            this.rbAdvanced.UseVisualStyleBackColor = true;
            this.rbAdvanced.CheckedChanged += new System.EventHandler(this.policyRadioButtons_CheckedChanged);
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(465, 589);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(134, 40);
            this.rbSpecial.TabIndex = 14;
            this.rbSpecial.TabStop = true;
            this.rbSpecial.Text = "Special";
            this.rbSpecial.UseVisualStyleBackColor = true;
            this.rbSpecial.CheckedChanged += new System.EventHandler(this.policyRadioButtons_CheckedChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(34, 556);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(390, 72);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Reload List";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ChallengeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 676);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.rbSpecial);
            this.Controls.Add(this.rbAdvanced);
            this.Controls.Add(this.rbStandard);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.isAliveCheckbox);
            this.Controls.Add(this.isAliveLabel);
            this.Controls.Add(this.agePicker);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ChallengeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Challenge by Tim Corey";
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown agePicker;
        private System.Windows.Forms.Label isAliveLabel;
        private System.Windows.Forms.CheckBox isAliveCheckbox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button saveListButton;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbAdvanced;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.Button btnReload;
    }
}

