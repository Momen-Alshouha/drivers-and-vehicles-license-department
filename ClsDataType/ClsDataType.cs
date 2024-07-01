using System;
using System.Runtime.InteropServices;

namespace ClsDataType
{
    public class ClsDataType
    {
        public struct StApplicationType
        {
            public int id { get; set; }
            public string title { get; set; }
            public decimal fee { get; set; }

            public StApplicationType()
            {
                id = -1;
                title ="";
                fee = 0;
            }
        }

        public enum EnMode
        {
            AddNew = 0 , Update =1
        }
        public struct StUser
        {
            public int UserID;
            public int PersonID;
            public string UserName;
            public string Password;
            public bool IsActive; 
        }

        public struct StPerson
        {
            public int Id;
            public string NationalNo;
            public string FirstName;
            public string SecondName;
            public string ThirdName;
            public string LastName;
            public string FullName;
            public DateTime BirthDate;
            public short Gender;
            public string Address;
            public string Phone;
            public string Email;
            public int NationalityCountryId;
            public string ImagePath;
            public string CountryName;


            public StPerson()
            {
                Id = -1;
                NationalNo = string.Empty;
                FirstName = string.Empty;
                SecondName = string.Empty;
                ThirdName = string.Empty;
                LastName = string.Empty;
                FullName = string.Empty;
                BirthDate = DateTime.MinValue;
                Gender = 0;
                Address = string.Empty;
                Phone = string.Empty;
                Email = string.Empty;
                NationalityCountryId = 0;
                ImagePath = string.Empty;
            }
        }
    }

}
