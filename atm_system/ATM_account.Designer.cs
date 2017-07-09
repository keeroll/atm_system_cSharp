namespace atm_system
{
    partial class ATM_account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.tb_withdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_transfer_next = new System.Windows.Forms.Button();
            this.tb_transfer_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_b_card = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your balance:";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balance.Location = new System.Drawing.Point(133, 60);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(19, 19);
            this.lb_balance.TabIndex = 1;
            this.lb_balance.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_withdraw);
            this.groupBox1.Controls.Add(this.tb_withdraw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Withdraw";
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.Location = new System.Drawing.Point(111, 77);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(75, 23);
            this.btn_withdraw.TabIndex = 2;
            this.btn_withdraw.Text = "Confirm";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // tb_withdraw
            // 
            this.tb_withdraw.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_withdraw.Location = new System.Drawing.Point(111, 38);
            this.tb_withdraw.Name = "tb_withdraw";
            this.tb_withdraw.Size = new System.Drawing.Size(269, 21);
            this.tb_withdraw.TabIndex = 1;
            this.tb_withdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_withdraw_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount of cash:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_transfer_next);
            this.groupBox2.Controls.Add(this.tb_transfer_amount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_b_card);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 156);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer";
            // 
            // btn_transfer_next
            // 
            this.btn_transfer_next.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer_next.Location = new System.Drawing.Point(111, 104);
            this.btn_transfer_next.Name = "btn_transfer_next";
            this.btn_transfer_next.Size = new System.Drawing.Size(75, 23);
            this.btn_transfer_next.TabIndex = 3;
            this.btn_transfer_next.Text = "Next";
            this.btn_transfer_next.UseVisualStyleBackColor = true;
            this.btn_transfer_next.Click += new System.EventHandler(this.btn_transfer_next_Click);
            // 
            // tb_transfer_amount
            // 
            this.tb_transfer_amount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_transfer_amount.Location = new System.Drawing.Point(111, 68);
            this.tb_transfer_amount.Name = "tb_transfer_amount";
            this.tb_transfer_amount.Size = new System.Drawing.Size(269, 21);
            this.tb_transfer_amount.TabIndex = 4;
            this.tb_transfer_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_transfer_amount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transfer amount:";
            // 
            // tb_b_card
            // 
            this.tb_b_card.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_b_card.Location = new System.Drawing.Point(111, 36);
            this.tb_b_card.MaxLength = 16;
            this.tb_b_card.Name = "tb_b_card";
            this.tb_b_card.Size = new System.Drawing.Size(269, 21);
            this.tb_b_card.TabIndex = 2;
            this.tb_b_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_b_card_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Beneficiary card:";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(10, 271);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.Color.Black;
            this.lb_welcome.Location = new System.Drawing.Point(6, 20);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(88, 19);
            this.lb_welcome.TabIndex = 5;
            this.lb_welcome.Text = "Welcome!";
            // 
            // ATM_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 317);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ATM_account";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ATM_account_FormClosed);
            this.Load += new System.EventHandler(this.ATM_account_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_withdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_transfer_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_b_card;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_transfer_next;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_welcome;
    }
}