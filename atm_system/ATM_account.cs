using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace atm_system
{
    public partial class ATM_account : MetroFramework.Forms.MetroForm
    {
        //DB connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\C#\atm_system_cSharp\db.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adt;
        DataSet dataset;
        SqlCommand cmd;

        string balance;
        string name;
        string surname;
        string tmpLbBalance;

        public ATM_account()
        {
            InitializeComponent();
        }

        private void ATM_account_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            TakeAccountInfo();
        }
        
        //Takes user info
        private void TakeAccountInfo()
        {
            con.Open();
            string query = "Select Name, Surname, Balance From [Table] Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";
            adt = new SqlDataAdapter(query, con);
            dataset = new DataSet();
            adt.Fill(dataset);
            
            //Takes first name, last name and balance
            foreach (DataRow dr in  dataset.Tables[0].Rows)
            {
                name += dataset.Tables[0].Rows[0]["Name"].ToString();
                surname += dataset.Tables[0].Rows[0]["Surname"].ToString();
                balance += dataset.Tables[0].Rows[0]["Balance"].ToString();
            }

            con.Close();
            lb_welcome.Text = "Welcome back, " + name + " " + surname + "!";
            lb_balance.Text = balance + " UAH";
            tmpLbBalance = balance;
        }
        

        private void ClearTextBoxes()
        {
            tb_b_card.Clear();
            tb_transfer_amount.Clear();
            tb_withdraw.Clear();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ATM atm_login = new ATM();
            this.Hide();
            atm_login.Show();
        }

        //Cash withdraw
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            //Checks balance
            if (Convert.ToDecimal(tmpLbBalance) >= Convert.ToDecimal(tb_withdraw.Text))
            {
                con.Open();
                string query_a = "Select Balance From [Table] Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";
                adt = new SqlDataAdapter(query_a, con);
                dataset = new DataSet();
                adt.Fill(dataset);

                //Cash withdraw (changing balance value)
                decimal tmpBalance = Convert.ToDecimal(dataset.Tables[0].Rows[0]["Balance"].ToString());
                tmpBalance = tmpBalance - Convert.ToDecimal(tb_withdraw.Text);

                //Updating old record
                string query_b = "Update [Table] Set Balance = '" + tmpBalance + "' Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";

                cmd = new SqlCommand(query_b, con);
                cmd.CommandText = query_b;
                cmd.ExecuteNonQuery();

                balance = tmpBalance.ToString();
                tmpLbBalance = balance;
                lb_balance.Text = balance + " UAH";
                tb_withdraw.Clear();
                con.Close();
            }
            else
                MessageBox.Show("There is not enough money on your account!");

        }

        //Transfer money
        private void btn_transfer_next_Click(object sender, EventArgs e)
        {
            //Checks balance
            if (Convert.ToDecimal(tmpLbBalance) >= Convert.ToDecimal(tb_transfer_amount.Text))
            {
                //Takes receiver info
                MinUserData.TransferCardData = tb_b_card.Text;
                MinUserData.TransferAmount = tb_transfer_amount.Text;

                //Transfer confirmation
                Transfer_confirm confirmTrForm = new Transfer_confirm();
                this.Hide();
                confirmTrForm.Show();
            }
            else
                MessageBox.Show("There is not enough money on your account!");

        }

        //Allows to enter only numbers
        private void tb_b_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        //Allows to enter only numbers (add later ch != 44 or 46 to add float values)
        private void tb_transfer_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        //Allows to enter only numbers (add later ch != 44 or 46 to add float values)
        private void tb_withdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        //Retunr to previous form
        private void ATM_account_FormClosed(object sender, FormClosedEventArgs e)
        {
            ATM atm_login = new ATM();
            this.Hide();
            atm_login.Show();
        }
    }
}
