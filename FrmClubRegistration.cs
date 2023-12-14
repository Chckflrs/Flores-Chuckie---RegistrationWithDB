using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationWithDB
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, Count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember openfrm = new FrmUpdateMember();
            openfrm.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            StudentID = Convert.ToInt64(TBStudentID.Text);
            FirstName = TBFirstName.Text;   
            MiddleName = TBMiddleName.Text;
            LastName = TBLastName.Text;
            Age = Convert.ToInt32(TBAge.Text);
            Gender = CBGender.Text;
            Program = CBProgram.Text;
            clubRegistrationQuery.RegisterStudent(RegistrationID(), StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);
            RefreshListOfClubMembers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private long StudentID;
        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();

        }
        void RefreshListOfClubMembers() {
            clubRegistrationQuery.DisplayList();
            DataClubMembersView.DataSource = clubRegistrationQuery.bindingSource;
        }
        int RegistrationID() {
            Count++;
            return Count;
        }
    }
}
