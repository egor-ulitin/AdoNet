using System;
using System.Collections.Generic;
using System.IO;

namespace Task2_Ado
{
    class FileManager
    {
        public bool IsWord(string word) //Проверка: отстутствуют ли в слове знаки препинания или цифры 
        {

            foreach (char ch in word)
                if (!char.IsLetter(ch))
                    return false;
            return true;
        }
        public void Reader(string path, List<User> persons)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                char[] definitions = { ',', ' ',':'};
                while (!sr.EndOfStream)
                {
                    String[] temp = sr.ReadLine().Split(definitions, StringSplitOptions.RemoveEmptyEntries);
                    int requiredCountOfWordForNewUser = 5;
                    int requiredCountOfWordForNewEmployee = 7;
                    if (temp.Length != requiredCountOfWordForNewEmployee && temp.Length != requiredCountOfWordForNewUser)
                    {
                        throw new Exception("Count of words is not correct");
                    }
                    if (IsWord(temp[0]))
                    {
                        if (IsWord(temp[1]))
                        {
                            if (IsWord(temp[2]))
                            {
                                String[] data = temp[3].Split('.'); //разбиваем дату рождения формата дд.мм.гггг 
                                if (data.Length == 3)
                                {
                                    if (int.TryParse(data[0], out int day) && int.TryParse(data[1], out int month) &&
                                        (int.TryParse(data[2], out int year))) // проверяем являются ли поля числами
                                    {
                                        if ((day <= 31 && day > 0) && (month <= 12 && month > 0) && (year > 1900 && year < 2021))//проверяем корректность даты рождения
                                        {
                                            if (int.TryParse(temp[4], out int age))
                                            {
                                                if (temp.Length == 5)//если temp разбился на 5 элементов, то значит мы создаем юзера
                                                {
                                                    persons.Add(new User(temp[0], temp[1], temp[2], temp[3], age));//создаем сотрудника
                                                }
                                                else //если temp разбился на 5 элементов, то значит мы создаем сотрудника 
                                                {
                                                    if (IsWord(temp[5])) //проверяем является ли словом название должности
                                                    {
                                                        if (int.TryParse(temp[6], out int experience))
                                                            persons.Add(new Employee(temp[0], temp[1], temp[2], temp[3], age, temp[5], experience));// создаем сотрудника
                                                        else throw new Exception("Опыт работы указан в неверном формате");
                                                    }
                                                    else throw new Exception("Должность указана в неверном формате");
                                                }
                                            }
                                            else throw new Exception("Возраст указан в неверном формате");
                                        }
                                        else throw new Exception("Дата рождения указана в неверном формате");
                                    }
                                    else throw new Exception("Дата рождения указана в неверном формате");
                                }
                                else throw new Exception("Дата рождения указана в неверном формате");
                            }
                            else throw new Exception("Отчество указано в неверном формате");
                        }
                        else throw new Exception("Имя указано в неверном формате");
                    }
                    else throw new Exception("Фамилия указана в неверном формате");
                }
            }
        }
    }
}
        
