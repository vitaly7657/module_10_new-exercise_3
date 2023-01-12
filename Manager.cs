using module_10_new_exercise_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace module_10_new_exercise_3
{
    class Manager : Clients
    {
        public Manager(int ID, string Surname, string Name, string Patronymic, string PhoneNumber, string Passport, string ChangeTime, string DataChange, string TypeChange, string User)
            : base(ID, Surname, Name, Patronymic, PhoneNumber, Passport, ChangeTime, DataChange, TypeChange, User)
        {

        }        
        public Manager() : this(2, "manager", "manager", "manager", "2", "2", "manager", "manager", "manager", "manager") //автозаполнение пустого нового класса
        {

        }
    }
}
