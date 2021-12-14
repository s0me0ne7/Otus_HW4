using System;
using System.Collections.Generic;
using System.Linq;
using Otus_HW4.IO;

namespace Otus_HW4
{
    public class Program
    {
        //S:
        //program отвечает только за старт приложения больше в нем ничего не происходит.
        //    GetSecretValue - отвечает только реализацию генерации загадываемого числа.
        //    O:
        //Implementation.SecretValue закрыт для изменения, т.к.зависит от Abstraction.ISecretValue, но может быть расширен. 
        //    Мы можем создать новую реализацию, отнаследовать ее от Implementation.SecretValue и преобразовать метод GetSecretValue, чтобы, например,
        //для разных вариантов игры были разные варианты получения загадываемого числа
        //L: 
        //Implementation.AnotherSecretValue отвечает принципу подстановки Лисков, т.к.он не меняет поведения исходного Implementation.SecretValue, как возвращало загадываемое число, так и возвращает.
        //    Но добавляет нам возможностей по-разному строить алгоритм получения числа
        //    I:
        //В игре нам нужен и вывод и ввод интформации.Но так же предусмотрена возможность пользоваться отдельно выводом и отдельно вводом.
        //    Именно то как реализованы интерфейсы IDataWriter и IDataReader, позволяет нам использовать их по отдельности, без необходимости использовать IDataConsole. 
        //    Это и есть реализация принципа разделения интерфейсов.
        //    D:
        //GameStarter зависит от абстракций IDataConsole и ISecretValue, а не от реализаций  DataConsole и SecretValue.Т.е.нет зависимости на что-то конкретное, а лишь на обстракции.

            static void Main(string[] args)
            {
                var dataConsole = new DataConsole();
                var secretValue = new SecretValue();

                var gameStarter = new GameStarter( dataConsole,  secretValue);
                while (true)
                {
                    gameStarter.Execute();
                }
               
            }

    }
}