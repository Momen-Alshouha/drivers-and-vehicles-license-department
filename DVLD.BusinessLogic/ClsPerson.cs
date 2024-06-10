using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDataType;
using DVLD.DataAccess;
using System.Data;
using System.Runtime.CompilerServices;

namespace DVLD.BusinessLogic
{
    public class ClsPerson
    {
        public enum EnMode
        {
            AddNew = 0,
            Update = 1,
        }
        public EnMode mode = EnMode.AddNew;
        public StPerson Person;
        public ClsPerson()
        {
            mode = EnMode.AddNew;
            Person = new StPerson();
        }
        public ClsPerson(EnMode mode, StPerson person)
        {
            this.mode = mode;
            this.Person = person;
        }
        private bool _AddNewPerson()
        {
            this.Person.Id = DataAccess.ClsPerson.AddNewPerson(this.Person);
            return (this.Person.Id != -1);
        }
        private bool _UpdatePerson()
        {
            return DataAccess.ClsPerson.UpdatePerson(this.Person);
        }
        public static StPerson? Find(int PersonId)
        {
            StPerson person = new StPerson();
            if (DataAccess.ClsPerson.GetPerson(PersonId,ref person))
            {
                if (person.Id!=-1)
                {
                    return person;
                }
            }
            return null;
        }
        public static StPerson? Find(string NationalNo)
        {
            StPerson person = new StPerson();
            if (DataAccess.ClsPerson.GetPerson(NationalNo, ref person))
            {
                if (person.Id != -1)
                {
                    return person;
                }
            }
            return null;
        }
        public bool Save()
        {
            switch (mode)
            {
                case EnMode.AddNew:
                    if (_AddNewPerson())
                    {
                        mode = EnMode.Update;
                        return true;
                    }
                    break;
                case EnMode.Update:
                    if (_UpdatePerson())
                    {
                        mode = EnMode.AddNew;
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return false;
        }
        public static DataTable GetPeople()
        {
            return DataAccess.ClsPerson.GetAllPeople();
        }
        public static bool IsPersonExist(int PersonId)
        {
            return DataAccess.ClsPerson.IsPersonExist(PersonId);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return IsPersonExist(NationalNo);
        }

        public static bool DeletePerson(int PersonId)
        {
            return (DataAccess.ClsPerson.DeletePerson(PersonId));
        }
    }
}
