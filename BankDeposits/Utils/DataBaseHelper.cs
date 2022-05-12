using BankDeposits.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits.Utils
{
    public static  class DataBaseHelper
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public static User GetUserByNumber(string number)
        {
            string sqlExpression = $"SELECT * FROM Deposits.[User] where Phone='{number}'";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.SafeGetString(1);
                        DateTime birth = reader.GetDateTime(2);
                        string Role = reader.SafeGetString(3);
                        string Email = reader.SafeGetString(4);
                        string Phone = reader.SafeGetString(5);
                        string AccountNumber = reader.SafeGetString(6);
                        Decimal Balance = reader.GetDecimal(7);
                        DateTime DateCreate = reader.GetDateTime(8);
                        string series = reader.SafeGetString(9);
                        string passNumber = reader.SafeGetString(10);
                        bool isConf = reader.GetBoolean(11);
                        int managerId = reader.GetInt32(12);
                        string password = reader.SafeGetString(13);
                        bool isDel = reader.GetBoolean(14);
                        return new User()
                        {
                            ID = id,
                            FullName = name,
                            Birthday = birth,
                            Role = Role,
                            Email = Email,
                            Phone = Phone,
                            AccountNumber = AccountNumber,
                            Balance = Balance,
                            DateCreate = DateCreate,
                            SeriesPassport = series,
                            PassportNumber = passNumber,
                            IsConfirmed = isConf,
                            ManageID = managerId,
                            Password = password,
                            IsDeleted = isDel
                        };
                    }
                }
            }
            return null;
        }
        public static User GetUserByID(int userID)
        {
            string sqlExpression = $"SELECT * FROM Deposits.[User] where ID={userID}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.SafeGetString(1);
                        DateTime birth = reader.GetDateTime(2);
                        string Role = reader.SafeGetString(3);
                        string Email = reader.SafeGetString(4);
                        string Phone = reader.SafeGetString(5);
                        string AccountNumber = reader.SafeGetString(6);
                        Decimal Balance = reader.GetDecimal(7);
                        DateTime DateCreate = reader.GetDateTime(8);
                        string series = reader.SafeGetString(9);
                        string passNumber = reader.SafeGetString(10);
                        bool isConf = reader.GetBoolean(11);
                        int managerId = reader.GetInt32(12);
                        string password = reader.SafeGetString(13);
                        bool isDel = reader.GetBoolean(14);
                        return new User()
                        {
                            ID = id,
                            FullName = name,
                            Birthday = birth,
                            Role = Role,
                            Email = Email,
                            Phone = Phone,
                            AccountNumber = AccountNumber,
                            Balance = Balance,
                            DateCreate = DateCreate,
                            SeriesPassport = series,
                            PassportNumber = passNumber,
                            IsConfirmed = isConf,
                            ManageID = managerId,
                            Password = password,
                            IsDeleted = isDel
                        };
                    }
                }
            }
            return null;
        }
        public static User GetUserByNumberXPassword(string number,string password)
        {
            string sqlExpression = $"SELECT * FROM Deposits.[User] where Phone='{number}' and password ='{password}'";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.SafeGetString(1);
                        DateTime birth = reader.GetDateTime(2);
                        string Role = reader.SafeGetString(3);
                        string Email = reader.SafeGetString(4);
                        string Phone = reader.SafeGetString(5);
                       string AccountNumber = reader.SafeGetString(6);
                        Decimal Balance = reader.GetDecimal(7);
                        DateTime DateCreate = reader.GetDateTime(8);
                        string series = reader.SafeGetString(9);
                        string passNumber = reader.SafeGetString(10);
                        bool isConf = reader.GetBoolean(11);
                        int managerId = reader.IsDBNull(12) ? 0 : reader.GetInt32(12);
                        string password_ = reader.SafeGetString(13);
                        bool isDel = reader.GetBoolean(14);

                        return new User()
                        {
                            ID = id,
                            FullName = name,
                            Birthday = birth,
                            Role = Role,
                            Email = Email,
                            Phone = Phone,
                            AccountNumber = AccountNumber,
                            Balance = Balance,
                            DateCreate = DateCreate,
                            SeriesPassport = series,
                            PassportNumber = passNumber,
                            IsConfirmed = isConf,
                            ManageID = managerId,
                            Password = password_,
                            IsDeleted = isDel
                        };
                    }
                }
            }
            return null;
        }
        public static string SafeGetString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }
        public static void AddUser(User user)
        {
            string sqlExpression = $"INSERT INTO Deposits.[User] (FullName, Birtthday,Role,Email,Phone,password,Balance,ManagerID,DateCreate,IsConfirmed)" +
                $" VALUES ('{user.FullName}', '{user.Birthday}','{user.Role}','{user.Email}','{user.Phone}','{user.Password}',{user.Balance},{user.ManageID},'{user.DateCreate}','{user.IsConfirmed}')";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }

        public static void ConfirmUser(int id)
        {
            string sqlExpression = $"UPDATE Deposits.[User] SET IsConfirmed='true' where ID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }
        public static void ConfirmDeposit(int id)
        {
            string sqlExpression = $"UPDATE Deposits.[Deposit] SET IsConfirmed='true' where ID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }
        public static void ConfirmAllDeposit(int id)
        {
            string sqlExpression = $"UPDATE Deposits.[Deposit] SET IsConfirmed='true' where UserID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }
        public static void DeleteUser(int id)
        {
            string sqlExpression = $"UPDATE Deposits.[User] SET IsDeleted='true' where ID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }
        public static void DeleteDeposit(int id)
        {
            string sqlExpression = $"UPDATE Deposits.[Deposit] SET IsDeleted='true' where ID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }
        public static void DropDeposit(int id)
        {
            string sqlExpression = $"DELETE FROM Deposits.[Deposit] where ID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }
        public static List<User> GetClients(int ManagerId,string customQuery="")
        {
            string sqlExpression = "";
            if (customQuery != "")
            {
                sqlExpression = customQuery;
            }
            else
                sqlExpression = $"Select * from Deposits.[User] where ManagerID={ManagerId} and IsDeleted='False'";
            List<User> users = new List<User>();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.SafeGetString(1);
                        DateTime birth = reader.GetDateTime(2);
                        string Role = reader.SafeGetString(3);
                        string Email = reader.SafeGetString(4);
                        string Phone = reader.SafeGetString(5);
                        string AccountNumber = reader.SafeGetString(6);
                        Decimal Balance = reader.GetDecimal(7);
                        DateTime DateCreate = reader.GetDateTime(8);
                        string series = reader.SafeGetString(9);
                        string passNumber = reader.SafeGetString(10);
                        bool isConf = reader.GetBoolean(11);
                        int managerId = reader.GetInt32(12);
                        string password_ = reader.SafeGetString(13);
                        bool isDel = reader.GetBoolean(14);
                        var user = new User()
                        {
                            ID = id,
                            FullName = name,
                            Birthday = birth,
                            Role = Role,
                            Email = Email,
                            Phone = Phone,
                            AccountNumber = AccountNumber,
                            Balance = Balance,
                            DateCreate = DateCreate,
                            SeriesPassport = series,
                            PassportNumber = passNumber,
                            IsConfirmed = isConf,
                            ManageID = managerId,
                            Password = password_,
                            IsDeleted = isDel
                        };
                        users.Add(user);
                    }
                }
            }
            
            return users;
            
        }
        public static List<User> GetClientsWithSearch(int ManagerId,string search)
        {
            string sqlExpression = $"Select * from Deposits.[User] where ManagerID={ManagerId} and IsDeleted='False' and FullName LIKE '{search}%'";
            return GetClients(ManagerId,sqlExpression); 
        }

        public static List<Deposit> GetDeposits(int userId, string customQuery = "")
        {
            string sqlExpression = "";
            if (customQuery != "")
            {
                sqlExpression = customQuery;
            }
            else
                sqlExpression = $"Select * from Deposits.[Deposit] where UserID={userId}";
            List<Deposit> deposits = new List<Deposit>();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        int typeID = reader.GetInt32(1);
                        int userID = reader.GetInt32(2);
                        Decimal Balance = reader.GetDecimal(3);
                        int currencyId = reader.GetInt32(4);
                        bool isConf = reader.GetBoolean(5);
                        DateTime date = reader.GetDateTime(6);
                        Decimal currentBalance = reader.GetDecimal(7);
                        var deposit = new Deposit()
                        {
                            ID = id,
                            TypeID = typeID,
                            UserID = userID,
                            CurrencyID = currencyId,
                            CurrentBalance = currentBalance,
                            StartBalance = Balance,
                            DateCreate = date,
                            isConfirmed = isConf
                        };
                        deposits.Add(deposit);
                    }
                }
            }
            return deposits;
        }
        public static Deposit GetDepositById(int depId)
        {
            string sqlExpression = $"Select * from Deposits.[Deposit] where ID={depId}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        int typeID = reader.GetInt32(1);
                        int userID = reader.GetInt32(2);
                        Decimal Balance = reader.GetDecimal(3);
                        int currencyId = reader.GetInt32(4);
                        bool isConf = reader.GetBoolean(5);
                        DateTime date = reader.GetDateTime(6);
                        Decimal currentBalance = reader.GetDecimal(7);
                        var deposit = new Deposit()
                        {
                            ID = id,
                            TypeID = typeID,
                            UserID = userID,
                            CurrencyID = currencyId,
                            CurrentBalance = currentBalance,
                            StartBalance = Balance,
                            DateCreate = date,
                            isConfirmed = isConf
                        };
                        return deposit;
                    }
                }
            }
            return null;
        }
        public static List<Deposit> GetDepositsToConfirm(int userId)
        {
            string query = $"Select * from Deposits.[Deposit] where UserID={userId} and IsConfirmed='False'";
            return GetDeposits(userId, query);
        }
        public static DepositType GetDepositTypeById(int? Id)
        {
            string sqlExpression = $"select * from [Deposits].DepositTypes where id = {Id}";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.SafeGetString(1);
                        bool isRef = reader.GetBoolean(2);
                        bool isWith = reader.GetBoolean(3);
                        int term = reader.GetInt32(4);
                        int rate = reader.GetInt32(5);
                        int minDep = reader.GetInt32(6);
                        int minWith = reader.GetInt32(7);
                        int Acces = reader.GetInt32(8);

                        var deposit = new DepositType()
                        {
                            ID = id,
                            Name = name,
                            IsRefilable=isRef,
                            IsWithdrawable=isWith,
                            Term = term,
                            InterestRate = rate,
                            MinimumDeposit=minDep,
                            MinimumWithdraw=minWith,
                            AccrualFrequency=Acces
                        };
                        return deposit;
                    }
                }
            }
            return null;
        }
        public static void CreateDeposit(Deposit deposit)
        {
            string sqlExpression = $"INSERT INTO Deposits.[Deposit] (TypeID, UserID,Balance,CurrencyID,IsConfirmed,DateCreate,CurrentBalance)" +
               $" VALUES ({deposit.TypeID}, {deposit.UserID},{deposit.StartBalance},{deposit.CurrencyID},'{deposit.isConfirmed}','{deposit.DateCreate}',{deposit.CurrentBalance})";
            var money = GetUserBalance(deposit.UserID);
            if (money < deposit.StartBalance)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }
            AddUserMoney(deposit.UserID,(decimal) -deposit.StartBalance);
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
            }
            MessageBox.Show("Заявка на вклад создана");
        }
        public static void AddUserMoney(int? id,Decimal money)
        {
            string sqlExpression = $"UPDATE Deposits.[User] SET Balance=Balance+{(int)money} where ID={id}";
            var balance = GetUserBalance(id);
            if (money < 0)
            {
                if (balance < Math.Abs(money))
                {
                    MessageBox.Show("Недостаточно средств");
                    return;
                }
            }
            
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
            }
        }
        public static Decimal GetUserBalance(int? id)
        {
            string sqlExpression = $"select Balance from Deposits.[User] where ID={id}";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        return reader.GetDecimal(0);
                    }
                }
            }
            return 0;
        }
        public static void UpdateBalanceDeposit(int depositId, Decimal money,bool withStart=false)
        {
            string sqlExpression = $"update Deposits.[Deposit] SET CurrentBalance=CurrentBalance+{(int)money} where ID={depositId}";
            var balance = GetDepositById(depositId).CurrentBalance;
            if (money < 0)
            {
                if (balance < Math.Abs(money))
                {
                    MessageBox.Show("Недостаточно средств для снятия");
                    return;
                }
            }
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                if (withStart)
                {
                    sqlExpression = $"update Deposits.[Deposit] SET Balance=Balance+{money} where ID={depositId}";
                    command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void TransferFromDepositToBalance(int depId,int userId,decimal sum,bool withStart = false)
        {
            if (sum < 0)
            {
                var dep = GetDepositById(depId);
                if (dep.CurrentBalance < Math.Abs(sum))
                {
                    MessageBox.Show("На депозите недостаточно средств");
                    return;
                }
            } else
            {
                var userbalance = GetUserBalance(userId);
                if (userbalance < sum)
                {
                    MessageBox.Show("На счете недостаточно средств");
                    return;
                }
            }
            UpdateBalanceDeposit(depId, sum, withStart);
            AddUserMoney(userId, -sum);
            MessageBox.Show("Выполнено!");
        }
    }
}
