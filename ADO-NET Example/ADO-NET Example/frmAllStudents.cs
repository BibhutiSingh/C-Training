using ADO_NET_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_Example
{
    public partial class frmAllStudents : Form
    {
        private Student currentStudent;

        public frmAllStudents()
        {
            InitializeComponent();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection($"Data Source={Program.DatabasePath};Version=3;"))
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "select * from Student";

                List<Student> allStudents = new List<Student>();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = reader.GetInt32("Id");
                    student.Name = reader.GetString("Name");
                    student.DOB = Convert.ToDateTime(reader.GetString("DOB"));
                    student.Gender = (Gender)(reader.GetInt32("Gender"));

                    allStudents.Add(student);
                }


                dgStudent.DataSource = allStudents;


            }
        }

        private void dgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentStudent = dgStudent.Rows[e.RowIndex].DataBoundItem as Student;

            lblId.Text = $"Id : {currentStudent.Id}";
            lblName.Text = $"Name : {currentStudent.Name}";
            lblDOB.Text = $"DOB : {currentStudent.DOB.ToShortDateString()}";
            lblGender.Text = $"Gender : {currentStudent.Gender}";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditStudent frmEditStudent = new frmEditStudent(currentStudent);
            frmEditStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection($"Data Source={Program.DatabasePath};Version=3;"))
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM Student  Where Id=@p0";

                command.Parameters.AddWithValue("@p0", currentStudent.Id);

                try
                {
                    var res = command.ExecuteNonQuery();
                    MessageBox.Show("Records Deleted.");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error in saving student record \n {ex.Message}");
                }



            }
        }
    }
}
