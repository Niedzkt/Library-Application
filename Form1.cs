namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private readonly DatabaseAccess dbAccess;
        private System.Windows.Forms.Timer refreshTimer;

        public Form1(DatabaseAccess dbAccess)
        {
            InitializeComponent();
            this.dbAccess = dbAccess;
            this.dataGridView1.BackgroundColor = Color.White;
            this.tabPage1.BackColor = Color.Gray;
            this.tabPage2.BackColor = Color.Blue;
            InitializeRefreshTimer();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void InitializeRefreshTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += RefreshData;
        }

        private void RefreshData(object sender, EventArgs e)
        {
            string query = "SELECT ";
            if (UserNameCheckBox.Checked) query += "imie, ";
            if (UserSurnameCheckBox.Checked) query += "nazwisko, ";
            if (UserPhoneCheckBox.Checked) query += "numer_telefonu, ";
            query = query.TrimEnd(',', ' ') + " FROM CZYTELNIK";

            if (!UserNameCheckBox.Checked && !UserSurnameCheckBox.Checked && !UserPhoneCheckBox.Checked)
            {
                query = "SELECT imie, nazwisko, numer_telefonu FROM CZYTELNIK";
            }

            var dataTable = dbAccess.ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (refreshTimer != null)
            {
                refreshTimer.Stop();
                refreshTimer.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData(null, null);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string name = UserNameTextBox.Text;
            string surname = UserSurnameTextBox.Text;
            string phoneNumber = UserPhoneTextBox.Text;

            dbAccess.AddUser(name, surname, phoneNumber);

            RefreshData(null, null);
        }

        private void UserNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserSurnameCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserPhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoRefresh.Checked)
            {
                refreshTimer.Start();
            }
            else { refreshTimer.Stop(); }
        }
    }
}