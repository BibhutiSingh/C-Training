using ADO_NET_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_Example
{
    public partial class frmEditStudent : Form
    {
        private Student student;
        public frmEditStudent(Student currentStudent)
        {
            this.student = currentStudent;
            InitializeComponent();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));

            txtName.Text = student.Name;
            txtDob.Value = student.DOB;
            cmbGender.SelectedIndex = (int)student.Gender;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Model Creation
            student.Name = txtName.Text;
            student.DOB = txtDob.Value;
            student.Gender = Enum.Parse<Gender>(cmbGender.SelectedItem.ToString());
          
            //Validation

            if (string.IsNullOrEmpty(student.Name) || student.Name.Length < 3)
            {
                MessageBox.Show("Name is not valid.");
            }


            using (var connection = new SQLiteConnection($"Data Source={Program.DatabasePath};Version=3;"))
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "UPDATE Student SET Name=@p1, DOB=@p2, Gender=@p3 Where Id=@p0";

                command.Parameters.AddWithValue("@p1", student.Name);
                command.Parameters.AddWithValue("@p2", student.DOB);
                command.Parameters.AddWithValue("@p3", student.Gender);

                command.Parameters.AddWithValue("@p0", student.Id);

                try
                {
                    var res = command.ExecuteNonQuery();
                    MessageBox.Show("Records Updated.");
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
