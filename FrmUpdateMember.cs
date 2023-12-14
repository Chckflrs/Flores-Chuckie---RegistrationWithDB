using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationWithDB
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }
        private int Age, Count;
        private long studentID;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE ClubMembers SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName, Age = @age, Gender = @gender, Program = @program WHERE StudentId = @ID";

            con.ConnectionString = sqlCon;
            using (con)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", studentID);
                    cmd.Parameters.AddWithValue("@firstName", firstNameTB.Text);
                    cmd.Parameters.AddWithValue("@middleName", middleNameTB.Text);
                    cmd.Parameters.AddWithValue("@lastName", lastnameTB.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(ageTB.Text));
                    cmd.Parameters.AddWithValue("@gender", GenderCB.Text);
                    cmd.Parameters.AddWithValue("@program", ProgramCB.Text);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Success");
        }

        private void CBStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ClubMembers WHERE StudentId = @ID";
            con.ConnectionString = sqlCon;
            using (con)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", CBStudentID.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        studentID = dr.GetInt64(1);
                        FirstName = dr.GetString(2);
                        MiddleName = dr.GetString(3);
                        LastName = dr.GetString(4);
                        Age = dr.GetInt32(5);
                        Gender = dr.GetString(6);
                        Program = dr.GetString(7);

                        fillData();
                        dr.Close();
                    }
                }
                con.Close();
            }
        }

        SqlConnection con;

        String sqlCon;

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mj\\source\\repos\\RegistrationWithDB\\ClubDB.mdf;Integrated Security=True";
            con = new SqlConnection(sqlCon);

            String query = "SELECT * FROM ClubMembers";

            con.ConnectionString = sqlCon;
            using (con)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", CBStudentID.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CBStudentID.Items.Add(dr.GetInt64(1));
                    }
                    dr.Close();
                }
                con.Close();
            }
        }
        void fillData() {
            CBStudentID.Text = studentID.ToString();
            firstNameTB.Text = FirstName;
            lastnameTB.Text = LastName;
            middleNameTB.Text = MiddleName;
            ProgramCB.Text = Program;
            ageTB.Text = Age.ToString();
            GenderCB.Text = Gender;
        }
    }
}
