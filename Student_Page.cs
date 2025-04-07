using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Use MySQL library

namespace StudentManagementApp.Forms
{
    public partial class Student_Page : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StudentDBConnection"].ConnectionString;

        public Student_Page()
        {
            InitializeComponent();
            this.Load += new EventHandler(Student_Page_Load); // Subscribe to Load event
        }

        private void Student_Page_Load(object sender, EventArgs e)
        {
            // Add the VIEW button column
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
            {
                Name = "ViewButton",
                HeaderText = "Action",
                Text = "VIEW",
                UseColumnTextForButtonValue = true
            };
            studentDataGridView.Columns.Add(viewButtonColumn);

            // Load student records
            LoadStudentRecords();
        }

        private void LoadStudentRecords()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS FullName FROM StudentRecordTB";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable studentTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(studentTable);
                    studentDataGridView.DataSource = studentTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student records: " + ex.Message);
                }
            }
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && studentDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int studentId = Convert.ToInt32(studentDataGridView.Rows[e.RowIndex].Cells["studentId"].Value);
                StudentPage_Individual individualPage = new StudentPage_Individual(studentId);
                individualPage.Show();
            }
        }
    }
}