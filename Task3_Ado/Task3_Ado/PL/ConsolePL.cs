using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.BLL;
using Task3_Ado.Entities;

namespace Task3_Ado.PL
{
    public class ConsolePL
    {
        UserService _userService;
        AwardService _awardService;
        public ConsolePL()
        {
            _userService = new UserService();
            _awardService = new AwardService();
        }
        public void ShowMainMenu()
        {
            bool correctly = false;
            while(!correctly)
            {
                Console.WriteLine("1 - Добавить пользователя\n2 - Удалить пользователя\n3 - Просмотреть список всех пользователей и их награды\n" +
                    "4 - Наградить пользователя\n" + "5 - Добавить новую награду\n" +
                    "6 - Удалить награду\n7 - Просмотреть список всех наград\n8 - Закрыть приложение");
                int number = int.Parse(Console.ReadLine());
                switch(number)
                {
                    case 1:
                        Console.WriteLine("Введите имя");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения");
                        DateTime.TryParse(Console.ReadLine(), out var birthday);
                        Console.WriteLine("Введите возраст");
                        int.TryParse(Console.ReadLine(), out var age);
                        bool checkAddUser = _userService.Add(new User(name, birthday, age));
                        if (checkAddUser)
                        {
                            Console.WriteLine("Пользователь успешно добавлен");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка при добавлении");
                        }    
                        break;
                    case 2:
                        Console.WriteLine("Введите ID пользователя, которого хотите удалить");
                        int.TryParse(Console.ReadLine(), out var idUserForDelete);
                        bool checkDelete = _userService.Delete(idUserForDelete);
                        if (checkDelete)
                        {
                            Console.WriteLine("Пользователь удален");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                        break;
                    case 3:
                        List<string> users = _userService.GetListUsersAndAwards();
                        foreach(var item in users)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите ID пользователя, которого хотите наградить");
                        int.TryParse(Console.ReadLine(), out var idUser);
                        Console.WriteLine("Введите ID награды");
                        int.TryParse(Console.ReadLine(), out var idAward);
                        _awardService.AddAwardForUser(idUser,idAward);
                        break;
                    case 5:
                        Console.WriteLine("Введите название награды");
                        string title = Console.ReadLine();
                        bool addAward = _awardService.Add(new Award(title));
                        if (addAward)
                        {
                            Console.WriteLine("Награда добавлена");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Введите ID награды, которую хотите удалить");
                        int.TryParse(Console.ReadLine(), out var idAwardForDelete);                  
                        bool awardForDelete = _awardService.Delete(idAwardForDelete);
                        if (awardForDelete)
                        {
                            Console.WriteLine("Награда удалена");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                        break;
                    case 7:
                        List<Award> awards = _awardService.GetListAwards();
                        Console.WriteLine("ID   Title");
                        foreach (var item in awards)
                        {
                            Console.WriteLine(item.ID + "    " + item.Title);
                        }
                 
                        break;
                    case 8:
                        correctly = true;
                        break;

                }
            }
        }
    }
}
