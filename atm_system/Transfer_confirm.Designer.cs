namespace atm_system
{
    partial class Transfer_confirm
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
            this.lb_from = new System.Windows.Forms.Label();
            this.lb_to = new System.Windows.Forms.Label();
            this.lb_card_from = new System.Windows.Forms.Label();
            this.lb_name_from = new System.Windows.Forms.Label();
            this.lb_card_to = new System.Windows.Forms.Label();
            this.lb_name_to = new System.Windows.Forms.Label();
            this.lb_transfer_amount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_confirm_transfer = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from.Location = new System.Drawing.Point(13, 75);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(56, 19);
            this.lb_from.TabIndex = 0;
            this.lb_from.Text = "From:";
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to.Location = new System.Drawing.Point(13, 146);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(36, 19);
            this.lb_to.TabIndex = 1;
            this.lb_to.Text = "To:";
            // 
            // lb_card_from
            // 
            this.lb_card_from.AutoSize = true;
            this.lb_card_from.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_card_from.Location = new System.Drawing.Point(98, 78);
            this.lb_card_from.Name = "lb_card_from";
            this.lb_card_from.Size = new System.Drawing.Size(40, 16);
            this.lb_card_from.TabIndex = 2;
            this.lb_card_from.Text = "0000";
            // 
            // lb_name_from
            // 
            this.lb_name_from.AutoSize = true;
            this.lb_name_from.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_from.Location = new System.Drawing.Point(98, 103);
            this.lb_name_from.Name = "lb_name_from";
            this.lb_name_from.Size = new System.Drawing.Size(43, 16);
            this.lb_name_from.TabIndex = 3;
            this.lb_name_from.Text = "name";
            // 
            // lb_card_to
            // 
            this.lb_card_to.AutoSize = true;
            this.lb_card_to.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_card_to.Location = new System.Drawing.Point(98, 149);
            this.lb_card_to.Name = "lb_card_to";
            this.lb_card_to.Size = new System.Drawing.Size(40, 16);
            this.lb_card_to.TabIndex = 4;
            this.lb_card_to.Text = "0000";
            // 
            // lb_name_to
            // 
            this.lb_name_to.AutoSize = true;
            this.lb_name_to.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_to.Location = new System.Drawing.Point(98, 174);
            this.lb_name_to.Name = "lb_name_to";
            this.lb_name_to.Size = new System.Drawing.Size(51, 16);
            this.lb_name_to.TabIndex = 5;
            this.lb_name_to.Text = "name2";
            // 
            // lb_transfer_amount
            // 
            this.lb_transfer_amount.AutoSize = true;
            this.lb_transfer_amount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transfer_amount.Location = new System.Drawing.Point(98, 218);
            this.lb_transfer_amount.Name = "lb_transfer_amount";
            this.lb_transfer_amount.Size = new System.Drawing.Size(40, 16);
            this.lb_transfer_amount.TabIndex = 6;
            this.lb_transfer_amount.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Amount:";
            // 
            // btn_confirm_transfer
            // 
            this.btn_confirm_transfer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_transfer.Location = new System.Drawing.Point(23, 279);
            this.btn_confirm_transfer.Name = "btn_confirm_transfer";
            this.btn_confirm_transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm_transfer.TabIndex = 8;
            this.btn_confirm_transfer.Text = "Confirm";
            this.btn_confirm_transfer.UseVisualStyleBackColor = true;
            this.btn_confirm_transfer.Click += new System.EventHandler(this.btn_confirm_transfer_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(273, 279);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Transfer_confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 348);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_confirm_transfer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_transfer_amount);
            this.Controls.Add(this.lb_name_to);
            this.Controls.Add(this.lb_card_to);
            this.Controls.Add(this.lb_name_from);
            this.Controls.Add(this.lb_card_from);
            this.Controls.Add(this.lb_to);
            this.Controls.Add(this.lb_from);
            this.Name = "Transfer_confirm";
            this.Resizable = false;
            this.Text = "Confirm transfer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Transfer_confirm_FormClosed);
            this.Load += new System.EventHandler(this.Transfer_confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label lb_card_from;
        private System.Windows.Forms.Label lb_name_from;
        private System.Windows.Forms.Label lb_card_to;
        private System.Windows.Forms.Label lb_name_to;
        private System.Windows.Forms.Label lb_transfer_amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_confirm_transfer;
        private System.Windows.Forms.Button btn_back;
    }
}