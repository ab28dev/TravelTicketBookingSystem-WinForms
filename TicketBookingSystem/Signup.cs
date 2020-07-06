using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingSystem
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        SignupClass c = new SignupClass();
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void button_Signup_Click(object sender, EventArgs e)
        {
            bool issuccess = false;
            if (textBox_userid.Text == "" || textBox_password.Text == "" || textBox_confirm_password.Text == "" || textBox_name.Text == "" || textBox_email.Text == "" || textBox_age.Text == "" || textBox_state.Text == "" || textBox_country.Text == "" || textBox_mobile.Text == "")
            {
                MessageBox.Show("All fields are mandatory. Kindly fill them before procedding further.");
            }
            else
            {
                if (textBox_password.Text == textBox_confirm_password.Text)
                {
                    SignupClass.userid = textBox_userid.Text;
                    SignupClass.password = textBox_password.Text;
                    SignupClass.name = textBox_name.Text;
                    SignupClass.email = textBox_email.Text;
                    SignupClass.age = int.Parse(textBox_age.Text);
                    SignupClass.state = textBox_state.Text;
                    SignupClass.country = textBox_country.Text;
                    SignupClass.mobile = textBox_mobile.Text;
                    c.signup();
                    issuccess = true;
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
            }
            
            if(issuccess == true)
            {
                MessageBox.Show("You will be redirected to homepage.");
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }

        }

        private void textBox_userid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
