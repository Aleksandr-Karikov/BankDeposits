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
    public partial class CreateDepositForm : Form
    {
        int ID;
        public CreateDepositForm(int userId)
        {
            InitializeComponent();
            ID = userId;
        }

        private void CreateDepositForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907b1_Karikov_ASDataSet.DepositTypes". При необходимости она может быть перемещена или удалена.
            this.depositTypesTableAdapter.Fill(this._907b1_Karikov_ASDataSet.DepositTypes);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                var depositType = DataBaseHelper.GetDepositTypeById((int)comboBox1.SelectedValue);
                if (depositType != null)
                {
                    freq.Text = depositType.AccrualFrequency.ToString();
                    percents.Text = depositType.InterestRate.ToString();
                    srok.Text = depositType.Term.ToString();
                    numericUpDown1.Minimum = (Decimal)depositType.MinimumDeposit;
                    numericUpDown1.Maximum = (Decimal)depositType.MinimumDeposit;
                    checkBox1.Checked = depositType.IsRefilable;
                    checkBox2.Checked = depositType.IsWithdrawable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseHelper.CreateDeposit(new Deposit()
            {
                CurrencyID = 1,
                StartBalance = numericUpDown1.Value,
                CurrentBalance = numericUpDown1.Value,
                DateCreate = DateTime.Now,
                isConfirmed = false,
                TypeID = (int)comboBox1.SelectedValue,
                UserID = ID
            }) ;
            
        }
    }
}
