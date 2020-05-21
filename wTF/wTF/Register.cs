using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet.Security.Cryptography;

namespace wTF
{
    public partial class Register : Form
    {

         static string connect = @"server=localhost;userid=root;password=;database=bank";
         static MySqlConnection con = new MySqlConnection(connect);
         
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            try
            {
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            int username = rand.Next(100000,999999);
            int password = rand.Next(100000,999999);
            int otp = rand.Next(10000,99999);

            con.Open();
            string expression = "INSERT INTO users(name,surname,username,password,otp,balance) values('"+textBox1.Text+"','"+textBox2.Text+"','"+username.ToString()+"','"+password.ToString()+"','"+otp+"','"+0+"')";
            MySqlCommand cmd = new MySqlCommand(expression,con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            con.Close();
            rdr.Close();
            MessageBox.Show(username.ToString()+" - USERNAME " + password.ToString()+" - PASSWORD" ,"");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }
    }
}
