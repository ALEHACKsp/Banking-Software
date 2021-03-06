﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace wTF
{
    public partial class Form1 : Form
    {
        private UserPanel userPanel;
        private Register regPanel;

        public static string usr;
        public static string pass;
        public static string connect = @"server=localhost;userid=root;password=;database=bank";
        public static MySqlConnection con = new MySqlConnection(connect);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            con.Open();

            

            string expression = "SELECT * FROM users";

            var cmd = new MySqlCommand(expression, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) {
                if (rdr.GetString(3) == username.Text && rdr.GetString(4)==password.Text)
                {
                    con.Close();
                    usr = username.Text;
                    pass = password.Text;
                    MessageBox.Show(this,"Succesfull login","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    userPanel = new UserPanel();
                    userPanel.Show();
                    rdr.Close();
                    this.Hide();
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            MessageBox.Show(this,"The bank will contact you.","RESET REQUEST",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            // Add your own function here to handle this situation.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            regPanel = new Register();
            regPanel.Show();
        }
    }
}
