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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADO_NET_Example
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Model Creation
            var stduent = new Student()
            {
                Name = txtName.Text,
                DOB = txtDob.Value,
                Gender = Enum.Parse<Gender>(cmbGender.SelectedItem.ToString())
            };
            //Validation

            if (string.IsNullOrEmpty(stduent.Name) || stduent.Name.Length < 3)
            {
                MessageBox.Show("Name is not valid.");
            }


            using (var connection = new SQLiteConnection($"Data Source={Program.DatabasePath};Version=3;"))
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO Student(Name,DOB,Gender) VALUES (@p1,@p2,@p3);";

                command.Parameters.AddWithValue("@p1", stduent.Name);
                command.Parameters.AddWithValue("@p2", stduent.DOB);
                command.Parameters.AddWithValue("@p3", stduent.Gender);

                try
                {
                    var res = command.ExecuteNonQuery();
                    MessageBox.Show("Records added.");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error in saving student record \n {ex.Message}");
                }



            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = Enum.GetValues(typeof(Gender))  ;
           

        }
    }
}
