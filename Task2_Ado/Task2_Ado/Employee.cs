using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ado
{
    class Employee : User
    {
        protected int _experience;
        protected string _position;
        public Employee(string _surname, string _name, string _fatherName, string _birthday, int _age, string _position, int _experience)
            : base(_surname, _name, _fatherName, _birthday, _age)
        {
            this._position = _position;
            this._experience = _experience;
        }
        public void Show()
        {
            Console.WriteLine("ФИО: {0} {1} {2} \nДень рождение: {3} \nВозраст: {4} \nДолжность: {5} \nОпыт работы: {6} года/лет",
                _surname, _name, _fatherName, _birthday, _age, _position, _experience);
        }
    }
}
