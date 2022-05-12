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
    public partial class ManagerControl : UserControl
    {
        List<User> users;
        User Manager;
        public ManagerControl(User user)
        {
            Manager = user;
            InitializeComponent();
            UpdateClients();
        }
        public void UpdateClients()
        {
            if (textBox1.Text!="")
                users = DataBaseHelper.GetClientsWithSearch(Manager.ID, textBox1.Text);
            else users = DataBaseHelper.GetClients(Manager.ID);
            if (users.Count == 0)
            {
                label3.Visible = true;
                return;
            }
            int count = 0;

            panel1.Controls.Clear();
            foreach (var user in users)
            {
                var control = new Client(user,UpdateClients);
                control.Location = new Point(0, count * control.Height);
                control.Width = panel1.Width;
                panel1.Controls.Add(control);
                count++;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateClients();
        }
    }
}
