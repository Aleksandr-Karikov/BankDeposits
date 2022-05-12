
namespace BankDeposits.Forms
{
    partial class ClientForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ФИО = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.Баланас = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подтвердить аккаунт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(128, 47);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(35, 13);
            this.fio.TabIndex = 1;
            this.fio.Text = "label1";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(128, 70);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "label2";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(128, 96);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(35, 13);
            this.birthday.TabIndex = 3;
            this.birthday.Text = "label3";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(128, 123);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(35, 13);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "label4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Подтвердить все заявки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ФИО
            // 
            this.ФИО.AutoSize = true;
            this.ФИО.Location = new System.Drawing.Point(13, 47);
            this.ФИО.Name = "ФИО";
            this.ФИО.Size = new System.Drawing.Size(34, 13);
            this.ФИО.TabIndex = 7;
            this.ФИО.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер телефона";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(128, 155);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(35, 13);
            this.Balance.TabIndex = 11;
            this.Balance.Text = "label4";
            // 
            // Баланас
            // 
            this.Баланас.AutoSize = true;
            this.Баланас.Location = new System.Drawing.Point(13, 155);
            this.Баланас.Name = "Баланас";
            this.Баланас.Size = new System.Drawing.Size(44, 13);
            this.Баланас.TabIndex = 12;
            this.Баланас.Text = "Баланс";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(235, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 151);
            this.panel1.TabIndex = 13;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Баланас);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ФИО);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.button1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ФИО;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Баланас;
        private System.Windows.Forms.Panel panel1;
    }
}