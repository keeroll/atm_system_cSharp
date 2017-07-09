using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Configuration;

namespace atm_system
{
    public partial class ATM : MetroFramework.Forms.MetroForm
    {
        //DB connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\C#\atm_system_cSharp\db.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd;

        ATM_account atm_acc = new ATM_account();

        public ATM()
        {
            InitializeComponent();
        }

        // number buttons to enter pin-code
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "0";
        }

        //Sign in confirmation
        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "Select * from [Table] Where Card_number = '" + tb_card.Text.Trim() + "' AND Pin_code = '" + tb_pin.Text.Trim() + "'";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                TakeUserData();
                ClearTextBoxes();
                this.Hide();
                atm_acc.Show();
            }
            else
            {
                label3.Text = "Wrong card or pin-code! Please, try again!";
                label3.ForeColor = Color.DarkRed;
                ClearTextBoxes();
            }

            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length > 0)
                tb_pin.Text = tb_pin.Text.Remove(tb_pin.Text.Length - 1);
        }

        private void ClearTextBoxes()
        {
            tb_card.Clear();
            tb_pin.Clear();
        }

        //Replace welcome text to default
        private void ATM_Load(object sender, EventArgs e)
        {
            label3.Text = "Welcome! Please, insert your card and enter your pin code!";
            label3.ForeColor = Color.Black;
        }

        //Temporary saves user info to use it in other forms
        private void TakeUserData()
        {
            MinUserData.CardData = tb_card.Text;
            MinUserData.PinData = tb_pin.Text;
        }

        //Event that allow you to enter only numbers
        private void tb_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //Close application
        private void ATM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
