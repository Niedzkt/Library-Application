using System.Data;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer refreshTimer;

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridViewBook.BackgroundColor = Color.White;
            this.dataGridViewWorker.BackgroundColor = Color.White;
            this.dataGridViewBorrow.BackgroundColor = Color.White;
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

            if (tabControl1.SelectedTab == tabPage1)
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

                var dataTable = DatabaseAccess.ExecuteQuery(query);
                dataGridView1.DataSource = dataTable;
            }

            if (tabControl1.SelectedTab == tabPage5)
            {
                string query = "SELECT ";
                if (checkBoxWorkerName.Checked) query += "imie, ";
                if (checkBoxWorkerSurname.Checked) query += "nazwisko, ";
                if (checkBoxWorkerPosition.Checked) query += "stanowisko, ";
                query = query.TrimEnd(',', ' ') + " FROM PRACOWNIK";

                if (!checkBoxWorkerName.Checked && !checkBoxWorkerSurname.Checked && !checkBoxWorkerPosition.Checked)
                {
                    query = "SELECT imie, nazwisko, stanowisko FROM PRACOWNIK";
                }

                var dataTable = DatabaseAccess.ExecuteQuery(query);
                dataGridViewWorker.DataSource = dataTable;
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                string query = "SELECT ";
                if (checkBoxBookName.Checked) query += "tytul, ";
                if (checkBoxBookYear.Checked) query += "rok_wydania, ";
                if (checkBoxBookCategory.Checked) query += "kategoria, ";
                if (checkBoxBookAmount.Checked) query += "dostepnosc, ";
                query = query.TrimEnd(',', ' ') + " FROM KSIAZKA";

                if (!checkBoxBookName.Checked && !checkBoxBookYear.Checked && !checkBoxBookCategory.Checked && !checkBoxBookAmount.Checked)
                {
                    query = "SELECT tytul, rok_wydania, kategoria, dostepnosc FROM KSIAZKA";
                }

                var dataTable = DatabaseAccess.ExecuteQuery(query);
                dataGridViewBook.DataSource = dataTable;
            }

            if (tabControl1.SelectedTab == tabPage4)
            {
                var dataTable = DatabaseAccess.ShowBorrows();
                dataGridViewBorrow.DataSource = dataTable;
            }

            if (tabControl1.SelectedTab == tabPage3)
            {
                string query = "SELECT ";
                if (checkBoxBookName.Checked) query += "imie, ";
                if (checkBoxBookYear.Checked) query += "nazwisko, ";
                if (checkBoxBookCategory.Checked) query += "data_urodzenia, ";
                query = query.TrimEnd(',', ' ') + " FROM AUTOR";

                if (!checkBoxAutorName.Checked && !checkBoxAutorSurname.Checked && !checkBoxAutorDateOfBirth.Checked)
                {
                    query = "SELECT imie, nazwisko, data_urodzenia FROM AUTOR";
                }

                var dataTable = DatabaseAccess.ExecuteQuery(query);
                dataGridViewAutor.DataSource = dataTable;
            }
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

            DatabaseAccess.AddUser(name, surname, phoneNumber);

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

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            string name = UserNameTextBox.Text;
            string surname = UserSurnameTextBox.Text;
            string phoneNumber = UserPhoneTextBox.Text;

            DatabaseAccess.DeleteUser(name, surname, phoneNumber);

            RefreshData(null, null);
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            string name = UserNameTextBox.Text;
            string surname = UserSurnameTextBox.Text;
            string phoneNumber = UserPhoneTextBox.Text;

            var dataTable = DatabaseAccess.SearchUser(name, surname, phoneNumber);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBoxWorkerName.Text;
            string surname = textBoxWorkerSurname.Text;
            string position = textBoxWorkerPosition.Text;

            DatabaseAccess.AddWorker(name, surname, position);

            RefreshData(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBoxWorkerName.Text;
            string surname = textBoxWorkerSurname.Text;
            string position = textBoxWorkerPosition.Text;

            var dataTable = DatabaseAccess.SearchWorker(name, surname, position);
            dataGridViewWorker.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBoxWorkerName.Text;
            string surname = textBoxWorkerSurname.Text;
            string position = textBoxWorkerPosition.Text;

            DatabaseAccess.DeleteWorker(name, surname, position);

            RefreshData(null, null);
        }

        private void buttonShowWorkers_Click(object sender, EventArgs e)
        {
            RefreshData(null, null);
        }

        private void checkBoxWorkerAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWorkerAutoRefresh.Checked)
            {
                refreshTimer.Start();
            }
            else { refreshTimer.Stop(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBookAddBook_Click(object sender, EventArgs e)
        {
            string name = textBoxBookName.Text;
            string year = textBoxBookYear.Text;
            string category = textBoxBookCategory.Text;
            string amount = textBoxBookAmount.Text;
            string publisher = textBoxBookFKPublisher.Text;


            DatabaseAccess.AddBook(name, year, category, amount);

            RefreshData(null, null);
        }

        private void buttonBookSearchBook_Click(object sender, EventArgs e)
        {
            string name = textBoxBookName.Text;
            string year = textBoxBookYear.Text;
            string category = textBoxBookCategory.Text;
            string amount = textBoxBookAmount.Text;
            string publisher = textBoxBookFKPublisher.Text;


            DatabaseAccess.SearchBook(name, year, category, amount);
        }

        private void buttonBookDeleteBook_Click(object sender, EventArgs e)
        {
            string name = textBoxBookName.Text;
            string year = textBoxBookYear.Text;
            string category = textBoxBookCategory.Text;
            string amount = textBoxBookAmount.Text;
            string publisher = textBoxBookFKPublisher.Text;


            DatabaseAccess.DeleteBook(name, year, category, amount);

            RefreshData(null, null);
        }

        private void buttonBookShowBooks_Click(object sender, EventArgs e)
        {
            RefreshData(null, null);
        }

        private void checkBoxBookRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBookRefresh.Checked)
            {
                refreshTimer.Start();
            }
            else { refreshTimer.Stop(); }
        }

        private void dataGridViewBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBorrowShowBorrows_Click(object sender, EventArgs e)
        {
            RefreshData(null, null);
        }

        private void buttonBorrowBorrowBook_Click(object sender, EventArgs e)
        {
            string name = textBoxBorrowCustomerName.Text;
            string surname = textBoxBorrowCustomerSurname.Text;
            string phoneNumber = textBoxBorrowCustomerPhone.Text;
            string bookName = textBoxBorrowBookName.Text;

            DateTime borrowDate;
            DateTime returnDate;

            bool isBorrowDateValid = DateTime.TryParse(textBoxBorrowDate.Text, out borrowDate);
            bool isReturnDateValid = DateTime.TryParse(textBoxBorrowReturnDate.Text, out returnDate);

            if (!isBorrowDateValid)
            {
                MessageBox.Show("Data wypo¿yczenia jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!isReturnDateValid)
            {
                MessageBox.Show("Data zwrotu jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            DatabaseAccess.BorrowBook(phoneNumber, name, surname, bookName, borrowDate, returnDate);

            RefreshData(null, null);
        }

        private void buttonBorrowDeleteBorrow_Click(object sender, EventArgs e)
        {
            bool isConversionSuccessful = int.TryParse(textBoxBorrowID.Text, out int borrowId);
            if (!isConversionSuccessful)
            {
                MessageBox.Show("Wprowadzony identyfikator wypo¿yczenia jest nieprawid³owy.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DatabaseAccess.ReturnBook(borrowId);
            RefreshData(null, null);
        }

        private void buttonBorrowNewReturnDate_Click(object sender, EventArgs e)
        {
            DateTime returnDate;
            bool isConversionSuccessful = int.TryParse(textBoxBorrowID.Text, out int borrowId);
            bool isReturnDateValid = DateTime.TryParse(textBoxRealReturnDate.Text, out returnDate);
            if (!isConversionSuccessful)
            {
                MessageBox.Show("Wprowadzony identyfikator wypo¿yczenia jest nieprawid³owy.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!isReturnDateValid)
            {
                MessageBox.Show("Data zwrotu jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DatabaseAccess.NewReturnDate(borrowId, returnDate);
            RefreshData(null, null);
        }

        private void buttonAutorAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxAutorName.Text;
            string surname = textBoxAutorSurname.Text;
            DateTime dateOfBirth;
            bool isDateOfBirthValid = DateTime.TryParse(textBoxAutorBirth.Text, out dateOfBirth);
            if (!isDateOfBirthValid)
            {
                MessageBox.Show("Data urodzenia jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DatabaseAccess.AddAutor(name, surname, dateOfBirth);
            RefreshData(null, null);
        }

        private void buttonAutorSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxAutorName.Text;
            string surname = textBoxAutorSurname.Text;
            DateTime dateOfBirth;
            bool isDateOfBirthValid = DateTime.TryParse(textBoxAutorBirth.Text, out dateOfBirth);
            if (!isDateOfBirthValid)
            {
                MessageBox.Show("Data urodzenia jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var dataTable = DatabaseAccess.SearchAutor(name, surname, dateOfBirth);
            dataGridViewAutor.DataSource = dataTable;
        }

        private void buttonAutorDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxAutorName.Text;
            string surname = textBoxAutorSurname.Text;
            DateTime dateOfBirth;
            bool isDateOfBirthValid = DateTime.TryParse(textBoxAutorBirth.Text, out dateOfBirth);
            if (!isDateOfBirthValid)
            {
                MessageBox.Show("Data urodzenia jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DatabaseAccess.DeleteAutor(name, surname, dateOfBirth);
            RefreshData(null, null);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RefreshData(null, null);
        }

        private void buttonAddBookToAutor_Click(object sender, EventArgs e)
        {
            string bookName = textBoxAutorBookName.Text;
            string bookYear = textBoxAutorBookYear.Text;
            string name = textBoxAutorName.Text;
            string surname = textBoxAutorSurname.Text;
            DateTime dateOfBirth;
            bool isDateOfBirthValid = DateTime.TryParse(textBoxAutorBirth.Text, out dateOfBirth);
            if (!isDateOfBirthValid)
            {
                MessageBox.Show("Data urodzenia jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DatabaseAccess.AddRelationAutorBook(bookName, bookYear, name, surname, dateOfBirth);
        }

        private void textBoxAutorBookYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBookFromAutor_Click(object sender, EventArgs e)
        {
            string bookName = textBoxAutorBookName.Text;
            string bookYear = textBoxAutorBookYear.Text;
            string name = textBoxAutorName.Text;
            string surname = textBoxAutorSurname.Text;
            DateTime dateOfBirth;
            bool isDateOfBirthValid = DateTime.TryParse(textBoxAutorBirth.Text, out dateOfBirth);
            if (!isDateOfBirthValid)
            {
                MessageBox.Show("Data urodzenia jest nieprawid³owa. Proszê wprowadziæ datê w formacie 'RRRR-MM-DD'.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DatabaseAccess.RemoveRelationAutorBook(bookName, bookYear, name, surname, dateOfBirth);
        }

        private void buttonAutorSearchWithBooks_Click(object sender, EventArgs e)
        {
            var dataTable = DatabaseAccess.GetAuthorAndBookDetails();
            dataGridViewAutor.DataSource = dataTable;
        }

        private void buttonBookGroupByYear_Click(object sender, EventArgs e)
        {
            string year = textBoxBookYear.Text;
            var dataTable = DatabaseAccess.GetBooksCountByYear(year);
            dataGridViewBook.DataSource = dataTable;
        }

        private void buttonAutorAVGCheck_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrowGetTotalBorrows_Click(object sender, EventArgs e)
        {
            var dataTable = DatabaseAccess.GetTotalBorrowsByReader();
            dataGridViewBorrow.DataSource = dataTable;
        }
    }
}