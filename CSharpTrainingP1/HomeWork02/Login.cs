using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    public class Login
    {
        //        4. Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
        //выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
        //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
        //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
        //цикла do while ограничить ввод пароля тремя попытками.


        public static void Do()
        {
            int i = 0;
            bool isCorrect;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                if (CorrectLogin(login) && CorrectPassword(password))
                {
                    Console.WriteLine("Все верно");
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Неправильный логин или пароль");
                    isCorrect = false;
                    i++;
                }
            } while (i < 3);

            if (isCorrect) Console.WriteLine("Вход выполнен");
            else Console.WriteLine("Доступ закрыт");
        }

        static bool CorrectLogin(string login)
        {
            if (login == "root") return true;
            else return false;
        }

        static bool CorrectPassword(string password)
        {
            if (password == "GeekBrains") return true;
            else return false;
        }
    }
}
