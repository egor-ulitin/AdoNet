using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ado
{
    class User
    {
        protected string _surname;
        protected string _name;
        protected string _fatherName;
        protected string _birthday;
        protected int _age;
        public User(string _surname, string _name, string _fatherName, string _birthday, int _age)
        {
            this._surname = _surname;
            this._name = _name;
            this._fatherName = _fatherName;
            this._birthday = _birthday;
            this._age = _age;
        }
        public void Show()
        {
            Console.WriteLine("ФИО: {0} {1} {2} \nДень рождение: {3} \nВозраст {4}",
                _surname, _name, _fatherName, _birthday, _age);
        }
    }
}
