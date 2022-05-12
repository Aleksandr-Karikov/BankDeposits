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
    public partial class ManagerDeposit : UserControl
    {
        private Deposit deposit;
        private Action update;
        public ManagerDeposit(Deposit deposit,Action action)
        {
            InitializeComponent();
            update = action;
            this.deposit = deposit;
            var types = DataBaseHelper.GetDepositTypeById(deposit.TypeID);
            TypeDep.Text = types.Name;
            StartBalance.Text = ((int)deposit.StartBalance).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseHelper.DeleteDeposit(deposit.ID);
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseHelper.ConfirmDeposit(deposit.ID);
            update();
        }
    }
}
