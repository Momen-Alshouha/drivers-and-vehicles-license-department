using System;
using System.Data;

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

        public static bool AddNewUser(ClsDataType.ClsDataType.StUser user)
        {
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

        public static bool ChangePassword(int UserID,string NewPasssword)
        {
            return DataAccess.ClsUser.ChangePassword(UserID, NewPasssword);
        }
    }
}
