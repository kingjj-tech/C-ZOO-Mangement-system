using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zoo_management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<string, string> validUsers = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" },
        { "user3", "password3" },
        { "user4", "password4" },
        { "user5", "password5" }
    };

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (validUsers.ContainsKey(username) && validUsers[username] == password)
            {
                Form1 menuForm = new Form1();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
