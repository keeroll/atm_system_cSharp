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
    public partial class Transfer_confirm : MetroFramework.Forms.MetroForm
    {
        //DB connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\C#\atm_system_cSharp\db.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adt;
        DataSet dataset;
        SqlCommand cmd;

        string name_a;
        string name_b;
        string surname_a;
        string surname_b;

        public Transfer_confirm()
        {
            InitializeComponent();
        }

        //Back to account form
        private void btn_back_Click(object sender, EventArgs e)
        {
            ATM_account accForm = new ATM_account();
            this.Hide();
            accForm.Show();
        }

        //Transfer confirmation button
        private void btn_confirm_transfer_Click(object sender, EventArgs e)
        {
            //Takes money from owner account
            UpdateAccWallet();

            //Transfer money to receiver account
            TransferMoneyToReceiver();
            ATM_account accForm = new ATM_account();
            this.Hide();
            accForm.Show();
            MessageBox.Show("Succeeded!");

        }

        //Transfer info
        private void Transfer_confirm_Load(object sender, EventArgs e)
        {
            TakeConfirmInformation();
            TakeConfirmInformationReceiver();

            //Transfer summ
            lb_transfer_amount.Text = MinUserData.TransferAmount + " UAH";
        }

        //Takes owner info
        private void TakeConfirmInformation()
        {
            con.Open();
            string query = "Select Name, Surname From [Table] Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";
            adt = new SqlDataAdapter(query, con);
            dataset = new DataSet();
            adt.Fill(dataset);

            //Takes last name, first name and balance info
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                name_a += dataset.Tables[0].Rows[0]["Name"].ToString();
                surname_a += dataset.Tables[0].Rows[0]["Surname"].ToString();
            }

            con.Close();
            lb_card_from.Text = MinUserData.CardData;
            lb_name_from.Text = name_a + " " + surname_a;
        }

        //Takes receiver info
        private void TakeConfirmInformationReceiver()
        {
            con.Open();
            string query = "Select Name, Surname From [Table] Where Card_number = '" + MinUserData.TransferCardData + "'";
            adt = new SqlDataAdapter(query, con);
            dataset = new DataSet();
            adt.Fill(dataset);

            //Takes last name, first name and balance info
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                name_b += dataset.Tables[0].Rows[0]["Name"].ToString();
                surname_b += dataset.Tables[0].Rows[0]["Surname"].ToString();
            }

            con.Close();
            lb_card_to.Text = MinUserData.TransferCardData;
            lb_name_to.Text = name_b + " " + surname_b;
        }

        //Transfer money
        private void TransferMoneyToReceiver()
        {
            con.Open();
            string query_a = "Select Balance From [Table] Where Card_number = '" + MinUserData.TransferCardData + "'";
            adt = new SqlDataAdapter(query_a, con);
            dataset = new DataSet();
            adt.Fill(dataset);

            //Transfer money to receiver balance
            decimal tmpBalance = Convert.ToDecimal(dataset.Tables[0].Rows[0]["Balance"].ToString());
            tmpBalance = tmpBalance + Convert.ToDecimal(MinUserData.TransferAmount);

            //Updates receiver balance
            string query_b = "Update [Table] Set Balance = '" + tmpBalance + "' Where Card_number = '" + MinUserData.TransferCardData + "'";

            cmd = new SqlCommand(query_b, con);
            cmd.CommandText = query_b;
            cmd.ExecuteNonQuery();


            //Закрытие соединения с БД
            con.Close();
        }

        //Updates balance info
        private void UpdateAccWallet()
        {
            con.Open();
            string query_a = "Select Balance From [Table] Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";
            adt = new SqlDataAdapter(query_a, con);
            dataset = new DataSet();
            adt.Fill(dataset);

            decimal tmpBalance = Convert.ToDecimal(dataset.Tables[0].Rows[0]["Balance"].ToString());
            tmpBalance = tmpBalance - Convert.ToDecimal(MinUserData.TransferAmount);

            string query_b = "Update [Table] Set Balance = '" + tmpBalance + "' Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";

            cmd = new SqlCommand(query_b, con);
            cmd.CommandText = query_b;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        //Return to previous form
        private void Transfer_confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ATM_account accForm = new ATM_account();
            this.Hide();
            accForm.Show();
        }
    }
}
