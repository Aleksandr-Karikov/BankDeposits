using BankDeposits.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        string name = reader.GetString(1);
                        DateTime birth = reader.GetDateTime(2);
                        string Role = reader.GetString(3);
                        string Email = reader.GetString(4);
                        string Phone = reader.GetString(5);
                        string AccountNumber = reader.GetString(6);
                        Decimal Balance = reader.GetDecimal(7);
                        DateTime DateCreate = reader.GetDateTime(8);
                        string series = reader.GetString(9);
                        string passNumber = reader.GetString(10);
                        bool isConf = reader.GetBoolean(11);
                        int managerId = reader.GetInt32(12);
                        string password = reader.GetString(13);
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
                            Password = password
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
                        int managerId = reader.GetInt32(12);
                        string password_ = reader.SafeGetString(13);
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
                            Password = password_
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
            string sqlExpression = $"INSERT INTO Deposits.[User] (FullName, Birtthday,Role,Email,Phone,password,Balance,ManagerID,DateCreate)" +
                $" VALUES ('{user.FullName}', '{user.Birthday}','{user.Role}','{user.Email}','{user.Phone}','{user.Password}',{user.Balance},{user.ManageID},'{user.DateCreate}')";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteReader();
            }
        }

    }
}
