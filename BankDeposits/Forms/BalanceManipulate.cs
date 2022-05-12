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
    public enum TypeManipulate
    {
        withdraw,
        tolUp
    }
    public partial class BalanceManipulate : Form
    {
        TypeManipulate typeManipulate;
        int id;
        int depId;
        Action update;
        public BalanceManipulate(TypeManipulate typeManipulate,int id,int depID,Action update)
        {
            InitializeComponent();
            this.update = update;
            this.id = id;
            this.depId = depID;
            this.typeManipulate = typeManipulate; 
            if (typeManipulate == TypeManipulate.withdraw)
            {
                button1.Text = "Снять со счета";
            } else
            {
                button1.Text = "Пополнить счет";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool res = Decimal.TryParse(textBox1.Text, out var money);
            if (res)
            {
                if (typeManipulate == TypeManipulate.withdraw)
                {
                    DataBaseHelper.TransferFromDepositToBalance(depId, id, -money,true);
                }
                else
                {
                    DataBaseHelper.TransferFromDepositToBalance(depId, id, money,true);
                }
                update();
            }
            else MessageBox.Show("Некорректный ввод");
        }
    }
}
