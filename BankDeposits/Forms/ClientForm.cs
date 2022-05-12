using BankDeposits.Forms.Components;
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

namespace BankDeposits.Forms
{
    public partial class ClientForm : Form
    {
        private User user;
        public ClientForm(User user)
        {
            this.user = user;
            InitializeComponent();
            UpdateUser();
        }
        private void UpdateUser()
        {
            user = DataBaseHelper.GetUserByNumber(user.Phone);
            fio.Text = user.FullName;
            Email.Text = user.Email;
            Phone.Text = user.Phone;
            birthday.Text = user.Birthday.Date.ToString();
            Balance.Text = ((int)user.Balance).ToString();
            List<Deposit> deposits = DataBaseHelper.GetDepositsToConfirm(user.ID);
            int count = 0;

            panel1.Controls.Clear();
            foreach (var deposit in deposits)
            {
                var control = new ManagerDeposit(deposit,UpdateUser);
                control.Location = new Point(0, count * control.Height);
                control.Width = panel1.Width;
                panel1.Controls.Add(control);
                count++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseHelper.ConfirmUser(user.ID);
            UpdateUser();
            MessageBox.Show("Пользователь подтвержден");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseHelper.ConfirmAllDeposit(user.ID);
            UpdateUser();
            MessageBox.Show("Все заявки подтверждены");
        }
    }
}
