namespace LibraryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            UserPhoneCheckBox = new CheckBox();
            UserSurnameCheckBox = new CheckBox();
            UserNameCheckBox = new CheckBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            DeleteUserButton = new Button();
            SearchUserButton = new Button();
            UserPhoneLabel = new Label();
            UserPhoneTextBox = new TextBox();
            AddUserButton = new Button();
            UserSurnameLabel = new Label();
            UserSurnameTextBox = new TextBox();
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            checkBoxAutoRefresh = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(-7, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 573);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBoxAutoRefresh);
            tabPage1.Controls.Add(UserPhoneCheckBox);
            tabPage1.Controls.Add(UserSurnameCheckBox);
            tabPage1.Controls.Add(UserNameCheckBox);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(DeleteUserButton);
            tabPage1.Controls.Add(SearchUserButton);
            tabPage1.Controls.Add(UserPhoneLabel);
            tabPage1.Controls.Add(UserPhoneTextBox);
            tabPage1.Controls.Add(AddUserButton);
            tabPage1.Controls.Add(UserSurnameLabel);
            tabPage1.Controls.Add(UserSurnameTextBox);
            tabPage1.Controls.Add(UserNameLabel);
            tabPage1.Controls.Add(UserNameTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(886, 545);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Czytelnik";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // UserPhoneCheckBox
            // 
            UserPhoneCheckBox.AutoSize = true;
            UserPhoneCheckBox.Location = new Point(581, 509);
            UserPhoneCheckBox.Name = "UserPhoneCheckBox";
            UserPhoneCheckBox.Size = new Size(111, 19);
            UserPhoneCheckBox.TabIndex = 13;
            UserPhoneCheckBox.Text = "Numer Telefonu";
            UserPhoneCheckBox.UseVisualStyleBackColor = true;
            UserPhoneCheckBox.CheckedChanged += UserPhoneCheckBox_CheckedChanged;
            // 
            // UserSurnameCheckBox
            // 
            UserSurnameCheckBox.AutoSize = true;
            UserSurnameCheckBox.Location = new Point(499, 509);
            UserSurnameCheckBox.Name = "UserSurnameCheckBox";
            UserSurnameCheckBox.Size = new Size(76, 19);
            UserSurnameCheckBox.TabIndex = 12;
            UserSurnameCheckBox.Text = "Nazwisko";
            UserSurnameCheckBox.UseVisualStyleBackColor = true;
            UserSurnameCheckBox.CheckedChanged += UserSurnameCheckBox_CheckedChanged;
            // 
            // UserNameCheckBox
            // 
            UserNameCheckBox.AutoSize = true;
            UserNameCheckBox.Location = new Point(444, 509);
            UserNameCheckBox.Name = "UserNameCheckBox";
            UserNameCheckBox.Size = new Size(49, 19);
            UserNameCheckBox.TabIndex = 11;
            UserNameCheckBox.Text = "Imię";
            UserNameCheckBox.UseVisualStyleBackColor = true;
            UserNameCheckBox.CheckedChanged += UserNameCheckBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(698, 505);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 10;
            button1.Text = "Wyświetl Użytkowników";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(266, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(596, 478);
            dataGridView1.TabIndex = 9;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Location = new Point(15, 196);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(154, 23);
            DeleteUserButton.TabIndex = 8;
            DeleteUserButton.Text = "Usuń Użytkownika";
            DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // SearchUserButton
            // 
            SearchUserButton.Location = new Point(15, 167);
            SearchUserButton.Name = "SearchUserButton";
            SearchUserButton.Size = new Size(154, 23);
            SearchUserButton.TabIndex = 7;
            SearchUserButton.Text = "Wyszukaj Użytkownika";
            SearchUserButton.UseVisualStyleBackColor = true;
            // 
            // UserPhoneLabel
            // 
            UserPhoneLabel.AutoSize = true;
            UserPhoneLabel.Location = new Point(15, 91);
            UserPhoneLabel.Name = "UserPhoneLabel";
            UserPhoneLabel.Size = new Size(91, 15);
            UserPhoneLabel.TabIndex = 6;
            UserPhoneLabel.Text = "Numer telefonu";
            // 
            // UserPhoneTextBox
            // 
            UserPhoneTextBox.Location = new Point(15, 109);
            UserPhoneTextBox.Name = "UserPhoneTextBox";
            UserPhoneTextBox.Size = new Size(154, 23);
            UserPhoneTextBox.TabIndex = 5;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(15, 138);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(154, 23);
            AddUserButton.TabIndex = 4;
            AddUserButton.Text = "Dodaj Użytkownika";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // UserSurnameLabel
            // 
            UserSurnameLabel.AutoSize = true;
            UserSurnameLabel.Location = new Point(15, 47);
            UserSurnameLabel.Name = "UserSurnameLabel";
            UserSurnameLabel.Size = new Size(57, 15);
            UserSurnameLabel.TabIndex = 3;
            UserSurnameLabel.Text = "Nazwisko";
            // 
            // UserSurnameTextBox
            // 
            UserSurnameTextBox.Location = new Point(15, 65);
            UserSurnameTextBox.Name = "UserSurnameTextBox";
            UserSurnameTextBox.Size = new Size(154, 23);
            UserSurnameTextBox.TabIndex = 2;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(15, 3);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(30, 15);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Imię";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(15, 21);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(154, 23);
            UserNameTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(886, 545);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ksiazka";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(886, 545);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Autor";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(886, 545);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Wypozycz";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(886, 545);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Pracownik";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(886, 545);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Wydawnictwo";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(886, 545);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Adres";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(886, 545);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Filia";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoRefresh
            // 
            checkBoxAutoRefresh.AutoSize = true;
            checkBoxAutoRefresh.Location = new Point(266, 509);
            checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            checkBoxAutoRefresh.Size = new Size(172, 19);
            checkBoxAutoRefresh.TabIndex = 14;
            checkBoxAutoRefresh.Text = "Automatyczne Odświeżanie";
            checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            checkBoxAutoRefresh.CheckedChanged += checkBoxAutoRefresh_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "LibraryApp";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TextBox UserNameTextBox;
        private Label UserNameLabel;
        private Label UserSurnameLabel;
        private TextBox UserSurnameTextBox;
        private Button DeleteUserButton;
        private Button SearchUserButton;
        private Label UserPhoneLabel;
        private TextBox UserPhoneTextBox;
        private Button AddUserButton;
        private DataGridView dataGridView1;
        private Button button1;
        private CheckBox UserPhoneCheckBox;
        private CheckBox UserSurnameCheckBox;
        private CheckBox UserNameCheckBox;
        private CheckBox checkBoxAutoRefresh;
    }
}