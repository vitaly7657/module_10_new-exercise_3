using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10_new_exercise_3
{
    class Clients: Interface1
    {
        int id;
        string surname;
        string name;
        string patronymic;
        string phoneNumber;
        string passport;
        string changeTime;
        string dataChange;
        string typeChange;
        string user;
        public Clients(int ID, string Surname, string Name, string Patronymic, string PhoneNumber, string Passport, string ChangeTime, string DataChange, string TypeChange, string User)
        {
            this.id = ID;
            this.surname = Surname;
            this.name = Name;
            this.patronymic = Patronymic;
            this.phoneNumber = PhoneNumber;
            this.passport = Passport;
            this.changeTime = ChangeTime;
            this.dataChange = DataChange;
            this.typeChange = TypeChange;
            this.user = User;
        }
        public string SurnameCnangeMethod(string SurnameChange)
        {
            this.Surname = SurnameChange;
            return SurnameChange;
        }
        public string NameCnangeMethod(string NameChange)
        {
            this.Name = NameChange;
            return NameChange;
        }
        public string PatronymicCnangeMethod(string PatronymicChange)
        {
            this.Patronymic = PatronymicChange;
            return PatronymicChange;
        }
        public string PhoneNumberCnangeMethod(string PhoneNumberChange)
        {
            this.PhoneNumber = PhoneNumberChange;
            return PhoneNumberChange;
        }
        public string PassportCnangeMethod(string PassportNumberChange)
        {
            this.Passport = PassportNumberChange;
            return PassportNumberChange;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public string ChangeTime
        {
            get { return changeTime; }
            set { changeTime = value; }
        }
        public string DataChange
        {
            get { return dataChange; }
            set { dataChange = value; }
        }
        public string TypeChange
        {
            get { return typeChange; }
            set { typeChange = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Print() //вывод на печать класса через метод
        {
            return String.Format("{0,3}{1,12}{2,12}{3,15}{4,15}{5,12}{6,20}{7,20}{8,20}{9,20}",
                this.ID,
                this.Surname,
                this.Name,
                this.Patronymic,
                this.PhoneNumber,
                this.Passport,
                this.ChangeTime,
                this.DataChange,
                this.TypeChange,
                this.User
                );
        }

        public Clients() : this(1, "client", "client", "client", "1", "1", "client", "client", "client", "client") //автозаполнение пустого нового класса
        {

        }
    }
}

