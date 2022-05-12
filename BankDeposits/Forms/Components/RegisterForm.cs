using BankDeposits.Models;
using BankDeposits.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits.Forms.Components
{
    public partial class RegisterForm : UserControl
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm parentForm = (this.Parent as MainForm);
            parentForm.SetActiveControl(parentForm.LoginControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumberTextBox.Text.Length > 15)
            {
                MessageBox.Show("Номер телефона не корректен");
                return;
            }
            var user = new User()
            {
                Balance = 0,
                DateCreate = DateTime.Now,
                Birthday = BirthdayDate.Value,
                Email = emailTextBox.Text,
                FullName = FIOTextBox.Text,
                IsConfirmed = false,
                ManageID = 1,
                Role = "Клиент",
                Phone = NumberTextBox.Text,
                Password = passwordTextBox.Text,
                IsDeleted = false,
            };
            if (AuthService.TryRegister(user))
            {
                MessageBox.Show("Заявка на создание счета отправлена");
            } else
            {
                MessageBox.Show("Возможно ваш аккаунт уже существует");
            }
        }
    }
}
