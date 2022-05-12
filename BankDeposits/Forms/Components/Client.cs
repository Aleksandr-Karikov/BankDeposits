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
    public partial class Client : UserControl
    {
        User User;
        Action Update;
        public Client(User user,Action Update)
        {
            User = user; 
            this.Update = Update;
            InitializeComponent();
            fio.Text = user.FullName;
            email.Text = user.Email;
            phone.Text = user.Phone;
            if (user.IsConfirmed)
            {
                button1.Text = "Подтвержден";
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseHelper.ConfirmUser(User.ID);
            button1.Text = "Подтвержден";
            button1.Enabled = false;
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseHelper.DeleteUser(User.ID);
            Update();
        }

        private void fio_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(User);
            clientForm.ShowDialog();
            Update();
        }
    }
}
