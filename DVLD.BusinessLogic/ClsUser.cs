using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace DVLD.BusinessLogic
{
    public class ClsUser
    {
        public static bool GetUserByUserID(int UserID, ref ClsDataType.ClsDataType.StUser user)
        {
            return DataAccess.ClsUser.GetUser(UserID, ref user);
        }

        public static bool GetUserByPersonID(int PersonID, ref ClsDataType.ClsDataType.StUser user)
        {
            return DataAccess.ClsUser.GetUserByPersonID(PersonID, ref user);
        }

        public static bool GetUserByCredentials(string UserName, string Password, ref ClsDataType.ClsDataType.StUser user)
        {
            return DataAccess.ClsUser.GetUser(UserName, Password, ref user);
        }

        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public static bool AddNewUser(ClsDataType.ClsDataType.StUser user)
        {
            user.Password = HashPassword(user.Password);

            return DataAccess.ClsUser.AddNewUser(user);
        }

        public static bool IsExist(int UserId)
        {
            return DataAccess.ClsUser.IsUserExist(UserId);
        }

        public static DataTable GetAllUsers()
        {
            return DataAccess.ClsUser.GetAllUsers();
        }

        public static bool UpdateUser(ClsDataType.ClsDataType.StUser user)
        {
            return DataAccess.ClsUser.UpdateUser(user);
        }

        public static void DeleteUser(int UserID)
        {
            DataAccess.ClsUser.DeleteUser(UserID);
        }

        public static bool ChangePassword(int UserID,string OldPassword,string NewPasssword)
        {
            return DataAccess.ClsUser.ChangePassword(UserID, OldPassword, NewPasssword);
        }
    }
}
