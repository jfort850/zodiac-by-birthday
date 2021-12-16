using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacFinderByBirthday
{
    public partial class frmSignUp : Form
    {
        List<PersonModel> Person1 = new List<PersonModel>();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void txtNewUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginUI = new frmLogin();
            loginUI.Show();

            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.Username = txtNewUserName.Text;
            p.Email = txtEmail.Text;
            p.Password = txtNewPassword.Text;

            DataBase.SaveAccount(p);





            
        }
    }
}
