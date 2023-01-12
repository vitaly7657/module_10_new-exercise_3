using module_10_new_exercise_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace module_10_new_exercise_3
{
    class Consultant : Clients
    {

        public Consultant(int ID, string Surname, string Name, string Patronymic, string PhoneNumber, string Passport, string ChangeTime, string DataChange, string TypeChange, string User) 
            : base(ID, Surname, Name, Patronymic,  PhoneNumber,  Passport, ChangeTime,  DataChange,  TypeChange,  User)
        {
            if (this.Passport != "") //проверка поля паспорта на заполнение
            {
                this.Passport = "*******";
            }
            else
            {
                this.Passport = "не задан";
            }

        }

        
        public new string Surname
        {
            get { return Surname; }
        }
        public new string Name
        {
            get { return Name; }
        }
        public new string Patronymic
        {
            get { return Patronymic; }
        }


        public Consultant() : this(2, "consultant", "consultant", "consultant", "2", "2", "consultant", "consultant", "consultant", "consultant") //автозаполнение пустого нового класса
        {

        }
    }
}

