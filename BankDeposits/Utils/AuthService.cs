using BankDeposits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankDeposits.Utils.DataBaseHelper;
namespace BankDeposits.Utils
{
    public static class AuthService
    {
        public static bool TryRegister(User user)
        {
            var user_ = GetUserByNumber(user.Phone);
            if (user_ == null)
            {
                AddUser(user);
                return true;
            } else
            {
                return false;
            }
        }
        public static User TryLogin(string number, string password)
        {
            var _user = GetUserByNumberXPassword(number, password); 
            if (_user != null)
            {
                if (!_user.IsConfirmed)
                {
                    MessageBox.Show("Аккаунт не подтвержден менеджером");
                    return null;
                } else if (_user.IsDeleted){
                    MessageBox.Show("Аккаунт удален менеджером");
                    return null;
                } else
                {
                    return _user;
                }
                
            }
            MessageBox.Show("Неправильная комбинация логина и пароля");
            return null;
        }

    }
}
