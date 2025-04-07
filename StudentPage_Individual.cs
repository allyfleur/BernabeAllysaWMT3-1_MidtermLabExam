using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StudentManagementApp.Forms
{
    public partial class StudentPage_Individual : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StudentDBConnection"].ConnectionString;
        private int studentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

private void LoadStudentDetails()
{
    try
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM StudentRecordTB WHERE studentId = @studentId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                PopulateFields(reader);
            }
            else
            {
                MessageBox.Show("No student record found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close(); // Explicitly close the reader
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading student details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void PopulateFields(MySqlDataReader reader)
{
    txtFirstName.Text = reader["firstName"] != DBNull.Value ? reader["firstName"].ToString() : string.Empty;
    txtLastName.Text = reader["lastName"] != DBNull.Value ? reader["lastName"].ToString() : string.Empty;
    txtMiddleName.Text = reader["middleName"] != DBNull.Value ? reader["middleName"].ToString() : string.Empty;
    txtAddress.Text = $"{reader["houseNo"]}, {reader["brgyName"]}, {reader["municipality"]}, {reader["province"]}";
    txtBirthdate.Text = reader["birthdate"] != DBNull.Value ? reader["birthdate"].ToString() : string.Empty;
    txtAge.Text = reader["age"] != DBNull.Value ? reader["age"].ToString() : string.Empty;
    txtContactNo.Text = reader["studContactNo"] != DBNull.Value ? reader["studContactNo"].ToString() : string.Empty;
    txtEmail.Text = reader["emailAddress"] != DBNull.Value ? reader["emailAddress"].ToString() : string.Empty;
    txtGuardianName.Text = $"{reader["guardianFirstName"]} {reader["guardianLastName"]}";
    txtHobbies.Text = reader["hobbies"] != DBNull.Value ? reader["hobbies"].ToString() : string.Empty;
    txtNickname.Text = reader["nickname"] != DBNull.Value ? reader["nickname"].ToString() : string.Empty;
}
    }
}