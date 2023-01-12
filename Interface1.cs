using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10_new_exercise_3
{
    internal interface Interface1
    {
        string SurnameCnangeMethod(string SurnameChange); //метод изменения фамилии
        string NameCnangeMethod(string NameChange); //метод изменения имени
        string PatronymicCnangeMethod(string PatronymicChange);  //метод изменения отчества
        string PhoneNumberCnangeMethod(string PhoneNumberChange); //метод изменения номера телефона
        string PassportCnangeMethod(string PassportNumberChange); //метод изменения серии, номера паспорта
    }
}
