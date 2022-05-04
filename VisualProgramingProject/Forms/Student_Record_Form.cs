using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VisualProgramingProject.Connection;
using System.IO;

namespace VisualProgramingProject.Forms
{
    public partial class Student_Record_Form : Form
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Student";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Student_Record_Form()
        {
            InitializeComponent();
            connectionString = "Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        bool checkCon = false;
        private void SaveToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkCon == false)
                {
                    checkCon = true;
                    Connect connect = new Connect();
                    connect.db_ConnectionToDatabase(false, sqlConnection);
                }
                SqlCommand cmd = new SqlCommand("insert into StudentDetails(StudentID,StudentName,StudentAge,StudentAddress,Password,Gender) Values (@StudentID,@StudentName,@StudentAge,@StudentAddress,@Password,@Gender)", sqlConnection);
                cmd.Parameters.AddWithValue("@StudentID", int.Parse(studentId.Text));
                cmd.Parameters.AddWithValue("@StudentName", studentName.Text);
                cmd.Parameters.AddWithValue("@StudentAge", int.Parse(studentAge.Text));
                cmd.Parameters.AddWithValue("@StudentAddress", studentAddress.Text);
                cmd.Parameters.AddWithValue("@Password", int.Parse(studentPassword.Text));
                if (genderMale.Checked)
                {
                    cmd.Parameters.AddWithValue("@Gender", genderMale.Text);
                }
                else if (genderFemale.Checked)
                {
                    cmd.Parameters.AddWithValue("@Gender", genderFemale.Text);
                }
                cmd.ExecuteNonQuery();
                if (!Directory.Exists("img"))
                    Directory.CreateDirectory("img");
                picPerson.Image.Save("img/" + studentId.Text + ".jpg");
                MessageBox.Show("Your Account Created");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please, Fill the Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Student_Record_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = studentId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login_Form login = new Login_Form();
            login.ShowDialog();
        }
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp;*.jpeg";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                picPerson.Image = Image.FromFile(of.FileName);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            studentName.Text = "";
            studentId.Text = "";
            studentAge.Text = "";
            studentAddress.Text = "";
            studentPassword.Text = "";
            picPerson.Image = new PictureBox().Image;
        }


    }
}
