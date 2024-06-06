using System;

namespace ClsDataType
{
    public class ClsDataType
    {
        public struct StPerson
        {
            public int Id;
            public string NationalNo;
            public string FirstName;
            public string SecondName;
            public string ThirdName;
            public string LastName;
            public DateTime BirthDate;
            public short Gender;
            public string Address;
            public string Phone;
            public string Email;
            public int NationalityCountryId;
            public string ImagePath;
            private readonly string _CountryName;
            private readonly ICountryDataAccess _CountryDataAccess;

            public StPerson(ICountryDataAccess countryDataAccess)
            {
                Id = -1;
                NationalNo = string.Empty;
                FirstName = string.Empty;
                SecondName = string.Empty;
                ThirdName = string.Empty;
                LastName = string.Empty;
                BirthDate = DateTime.MinValue;
                Gender = 0;
                Address = string.Empty;
                Phone = string.Empty;
                Email = string.Empty;
                NationalityCountryId = 0;
                ImagePath = string.Empty;
                _CountryDataAccess = countryDataAccess;
                _CountryName = _CountryDataAccess.GetCountryName(NationalityCountryId);
            }

            // Method to retrieve the country name
            public string GetCountryName()
            {
                return _CountryDataAccess?.GetCountryName(NationalityCountryId) ?? "Unknown";
            }
        }
    }

    public interface ICountryDataAccess
    {
        string GetCountryName(int countryId);
    }
}
