using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace LogInForm_Guinanao_Agapito_Cornita_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Please log in.");
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        public void Clr()
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            picPass.BackgroundImage = Properties.Resources.password1;
            panel2.BackColor = SystemColors.Window;
            picUser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = SystemColors.Window;
            txtPassword.UseSystemPasswordChar = true;

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
            txtUsername.ForeColor = SystemColors.Window;
            picUser.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.SpringGreen;

            picPass.BackgroundImage = Properties.Resources.password1;
            panel2.BackColor = SystemColors.Window;


            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = true;

            }
            if (txtPassword.Text == "Password")
            {
                eye.Enabled = false;
            }


        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";


            }

            txtPassword.ForeColor = SystemColors.Window;
            picPass.BackgroundImage = Properties.Resources.password2;
            panel2.BackColor = Color.SpringGreen;

            picUser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = SystemColors.Window;
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
            if (txtPassword.Text == "Password")
            {
                eye.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            eye.Enabled = true;
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                eye.BackgroundImage = Properties.Resources.eye1;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                eye.BackgroundImage = Properties.Resources.eye2;
            }
        }

        private void btnexit_MouseHover(object sender, EventArgs e)
        {
            btnexit.BackgroundImage = Properties.Resources.exit1;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.BackgroundImage = Properties.Resources.exit2;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Are you really want to exit?");
            DialogResult dialog = MessageBox.Show("Are you really want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                Clr();
                logo.BackgroundImage = Properties.Resources.logo;

            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string[] user = { "rico_", "pauL", "Jeff" };
            string[] pass = { "rics", "aga", "jeff_" };
            if (txtUsername.Text == user[0] && txtPassword.Text == pass[0])
            {
                logo.BackgroundImage = Properties.Resources.logo2;
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("You have successfully logged in Rico");
                MessageBox.Show("You have successfully logged in Rico", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtUsername.Text == user[1] && txtPassword.Text == pass[1])
            {
                logo.BackgroundImage = Properties.Resources.logo2;
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("You have successfully logged in Paul");
                MessageBox.Show("You have successfully logged in Paul", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtUsername.Text == user[2] && txtPassword.Text == pass[2])
            {
                logo.BackgroundImage = Properties.Resources.logo2;
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("You have successfully logged in Jeff");
                MessageBox.Show("You have successfully logged in Jeff", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //else if (txtPassword.MaxLength <6)
            //{
            //    reader.Dispose();
            //    reader = new SpeechSynthesizer();
            //    reader.SelectVoiceByHints(VoiceGender.Female);
            //    reader.SpeakAsync("Enter 6 characters or above for password");
            //    MessageBox.Show("Enter 6 characters or above for password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            else if (txtUsername.Text != user[0] || txtUsername.Text != user[1] || txtUsername.Text !=
                user[2] && txtPassword.Text != pass[0] || txtPassword.Text != pass[1] || txtPassword.Text != pass[2])
            {
                logo.BackgroundImage = Properties.Resources.logo3;
                picUser.BackgroundImage = Properties.Resources.user3;
                picPass.BackgroundImage = Properties.Resources.password3;
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                txtUsername.ForeColor = Color.Red;
                txtPassword.ForeColor = Color.Red;
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Invalid username or password. Please try again");
                MessageBox.Show("Invalid username or password.\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clr();
                logo.BackgroundImage = Properties.Resources.logo;
            }
        }

        
    }
}

