﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wTF
{
    //To ADD: ADD OPTION TO SEND/RECIEVE MONEY
    //To ADD: BETTER GRAPHICS AND PAYMENT SYSTEM
    public partial class UserPanel : Form
    {
        private Form1 f1 = (Form1)Form1.ActiveForm;
        string connect = Form1.connect;
        string usr = Form1.usr;
        string pass= Form1.pass;
        string expression = "SELECT * FROM users where password="; 
        int otp = 0;
        int recBalance = 0;
        int userBalance = 0;
        MySqlConnection con = Form1.con;
        
        public UserPanel()
        {
            InitializeComponent();
            RefreshBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userBalance = SenderBalance();
            if (userBalance >= Convert.ToInt32(transferAmmount.Text))
            {


                recBalance = RecieverBalance();
                con.Open();
                otp = Convert.ToInt32(otpBox.Text);
                expression = "SELECT * FROM users where otp=";
                MySqlCommand cmd = new MySqlCommand(expression + otp, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    int ammount = Convert.ToInt32(transferAmmount.Text);
                    expression = $"UPDATE users SET balance = {(recBalance + ammount).ToString()} where otp =" + otp;
                    rdr.Close();
                    cmd = new MySqlCommand(expression, con);
                    cmd.ExecuteNonQuery();
                }
                rdr.Close();
                con.Close();

                con.Open();
              
                expression = "SELECT * FROM users where password=";
                cmd = new MySqlCommand(expression + pass, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    
                    int ammount = Convert.ToInt32(transferAmmount.Text);
                    expression = $"UPDATE users SET balance = {(userBalance - ammount).ToString()} where password=" + pass;
                    rdr.Close();
                    cmd = new MySqlCommand(expression, con);
                    cmd.ExecuteNonQuery();
                }
                rdr.Close();
                con.Close();
                RefreshBalance();
                MessageBox.Show(this, "Succesfull Transaction", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(this, "Failed Transaction", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private int RecieverBalance() {

            con.Open();
            otp = Convert.ToInt32(otpBox.Text);
            expression = "SELECT balance FROM users WHERE otp=";
            MySqlCommand cmd = new MySqlCommand(expression + otp, con);                      
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()){
                int ret = rdr.GetInt32(0);
                rdr.Close();
                con.Close();
                return ret;
            }
            else
            {
                
                MessageBox.Show("CANNOT FIND USER FROM OTP","ERROR");
                rdr.Close();
                con.Close();
                return 0;
            }
          

        }
        private int SenderBalance() {

            
            otp = Convert.ToInt32(otpBox.Text);
            expression = "SELECT balance FROM users WHERE password=";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(expression + pass, con);                      
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                int ret = rdr.GetInt32(0);
                rdr.Close();
                con.Close();
                return ret;
            }
            else
            {
                rdr.Close();
                con.Close();
                MessageBox.Show("CANNOT FIND USER FROM PASS", "ERROR");
                return 0;
            }


         
        }
        private void RefreshBalance() {
            expression = "SELECT * FROM users where password=";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(expression + pass, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                label5.Text = rdr.GetString(1);
                Surname.Text = rdr.GetString(2);
                Balance.Text = rdr.GetInt32(6).ToString() + " $";

            }
            rdr.Close();
            con.Close();
        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Close();
        }
    }

    
}
