using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ado_2
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
        public void Reader(string path, List<Ring> rings)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                char[] definitions = { ',', ' ', ':' };
                while (!sr.EndOfStream)
                {
                    String[] temp = sr.ReadLine().Split(definitions, StringSplitOptions.RemoveEmptyEntries);
                    int requiredCounWordtOfRing = 4;
                    if (temp.Length != requiredCounWordtOfRing)
                    {
                        throw new Exception("Count of words is not correct");
                    }
                    if (int.TryParse(temp[0], out int x))
                    {
                        if (int.TryParse(temp[1], out int y))
                        {
                            if (int.TryParse(temp[2], out int innerradius))
                            {
                                if (int.TryParse(temp[3], out int outherRadius))
                                {
                                    if (innerradius < outherRadius)
                                    {
                                        if (innerradius > 0 && outherRadius > 0)
                                        {
                                            rings.Add(new Ring(x, y, innerradius, outherRadius));
                                        }
                                        else
                                        {
                                            throw new Exception("Радиус не может быть отрицательным");

                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Внутренний радиус должен быть не должен быть больше внешнего радиуса");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Ошибка");
                                }
                            }
                            else
                            {
                                throw new Exception("Ошибка");
                            }
                        }
                        else
                        {
                            throw new Exception("Ошибка");
                        }
                    }
                    else
                    {
                        throw new Exception("Ошибка");
                    }
                }
            }
        }
    }
}
