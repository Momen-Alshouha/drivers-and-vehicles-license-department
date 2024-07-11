using System;
using System.Runtime.InteropServices;

namespace ClsDataType
{
    public class ClsDataType
    {

        public struct StTestType
        {
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public decimal fee { get; set; }
        }

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
            public int Id { set; get; }
            public string NationalNo { set; get; }
            public string FirstName { set; get; }
            public string SecondName { set; get; }
            public string ThirdName { set; get; }
            public string LastName { set; get; }
            public string FullName { set; get; }
            public DateTime BirthDate { set; get; }
            public short Gender { set; get; }
            public string Address { set; get; }
            public string Phone { set; get; }
            public string Email { set; get; }
            public int NationalityCountryId { set; get; }
            public string ImagePath { set; get; }
            public string CountryName { set; get; }


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
