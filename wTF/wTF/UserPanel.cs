using MySql.Data.MySqlClient;
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

    public partial class UserPanel : Form
    {
        string connect = Form1.connect;
        string usr = Form1.usr;
        string pass= Form1.pass;
        string expression = "SELECT * FROM users where password="; 
        MySqlConnection con = Form1.con;
        
        public UserPanel()
        {
            InitializeComponent();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(expression+pass,con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Name.Text = rdr.GetString(1);
                Surname.Text = rdr.GetString(2);
                Balance.Text = rdr.GetInt32(6).ToString();
            }
        }
    }

    
}
