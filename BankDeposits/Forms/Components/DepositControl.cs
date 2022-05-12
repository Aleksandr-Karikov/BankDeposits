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
    public partial class DepositControl : UserControl
    {
        Action action;
        Deposit deposit;
        public DepositControl(Deposit deposit, Action action)
        {
            InitializeComponent();
            this.deposit = deposit;
            Id.Text = deposit.ID.ToString();
            label2.Text = ((int)deposit.CurrentBalance).ToString();
            pictureBox1.Visible = false;
            if (deposit.CurrentBalance > deposit.StartBalance)
            {
                pictureBox1.Visible = true;
                up.Text = ((int)(deposit.CurrentBalance - deposit.StartBalance)).ToString();
            }
            var type = DataBaseHelper.GetDepositTypeById(deposit.TypeID);
            Type.Text =type.Name;
            if (!type.IsRefilable)
            {
                button2.Enabled = false;
            }
            if (!type.IsWithdrawable)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            if (!deposit.isConfirmed)
            {
                if (deposit.IsDeleted)
                {
                    message.Text = "Заявка отклоенена";
                    button3.Visible = true;

                }
                message.Visible = true;
            }
            this.action = action;
        }
        public void Hide()
        {
            button1.Visible= false; 
            button2.Visible= false;
            button3.Visible= false;
            message.Visible = true;
            pictureBox1.Visible = false;
        }
        public void HidePicture()
        {
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BalanceManipulate manipulate = new BalanceManipulate(TypeManipulate.withdraw,(int)deposit.UserID,deposit.ID, action);
            manipulate.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BalanceManipulate manipulate = new BalanceManipulate(TypeManipulate.tolUp, (int)deposit.UserID, deposit.ID, action);
            manipulate.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBaseHelper.TransferFromDepositToBalance(deposit.ID,(int)deposit.UserID,-(decimal)deposit.CurrentBalance);
            DataBaseHelper.DropDeposit(deposit.ID);
            MessageBox.Show("Депозит закрыт");
            action();
        }
    }
}
