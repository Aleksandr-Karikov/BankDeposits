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
    public partial class MainControl : UserControl
    {
        User _user;
        public MainControl(User user)
        {
            InitializeComponent();
            _user = user; 
            UpdateDepositsInfo();
            
        }
        private void UpdateUser()
        {
            _user = DataBaseHelper.GetUserByID(_user.ID);
            fio.Text = _user.FullName;
            balalnce.Text = _user.Balance.ToString();
            Profit.Text = "0";
        }
        private void UpdateDepositsInfo()
        {
            List<Deposit> deposits = DataBaseHelper.GetDeposits(_user.ID);
            
            int count = 0;
            panel1.Controls.Clear();
            decimal? sum = 0;
            foreach (Deposit deposit in deposits)
            {
                if (deposit.CurrentBalance - deposit.StartBalance>0)
                    sum += deposit.CurrentBalance - deposit.StartBalance;
                var control = new DepositControl(deposit, UpdateDepositsInfo);
                control.Location = new Point(0, count * control.Height);
                control.Width = panel1.Width;
                if (!deposit.isConfirmed)
                {
                    control.Hide();
                }
                if (deposit.CurrentBalance < deposit.StartBalance)
                {
                    control.HidePicture();
                }
                panel1.Controls.Add(control);
                count++;
            }
            if (sum > 0) ;
            Profit.Text = sum.ToString();
            UpdateUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDepositForm form = new CreateDepositForm(_user.ID);
            form.ShowDialog();
            UpdateDepositsInfo();
        }
    }
}
