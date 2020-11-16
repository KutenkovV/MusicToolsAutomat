using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MusicTools
{
    // ГЛАВНЫЙ родительский класс от которого все наследуем
    public class MusicTools
    {
        public static Random rnd = new Random();

        // объявляем наш enum, где напишем акустический или электро у нас инструмент (1ое общее свойство)
        public enum type { electric, acoustic };
        public type type1 = type.acoustic;

        public int toolCost = 0; //стоимость наших инструментов (2ое общее свойство)

        //возвращаем в методе наш тип + цену
        public virtual String GetInfo()
        {
            var str = String.Format("\nТип инструмента: {0}", this.type1);
            str += String.Format("\nЦена инструмента: {0} рублей", this.toolCost);

            return str;
        }
    }

    // СТРУННЫЕ инструменты
    public class Stringed : MusicTools
    {
        public int StringsCount = 0; // кол-во струн

        // MusicSystem - с забугорного "Музыкальный строй" 
        public string[] MusicSystem = new string[3] { "Стандартный", "Инструмент не настроен", "Произвольный" };
        public int temp = 0;

        // по счетчику выше мы будем выбирать элемент массива строк

        //мне было лень расписывать все возможные "строи" гитар, скрипок и т.д. и потому я сделал так
        //потому что инструмент изначально в магазине - РАСТРОЕННЫЙ (или настроенный каким то добрым дядей и то как то по своему)
        //посему сделал такой вот простенький выбор. Инструмент мб или растроенный, или настроеный по стндрту или произвольно


        // тута мы задаем значения нашим полям
        public static Stringed Generate()
        {
            return new Stringed
            {
                type1 = (type)rnd.Next(2),    //Из родительского класса рандомим какой тип нам выпадет (общее свойство)
                toolCost = 5000 + rnd.Next(35000), //Из родительского класса рандомим какая цена нам выпадет (общее свойство)
                StringsCount = 4 + rnd.Next() % 6, //тут мы рандомим сколь-ко струн нам попадется (правда это никак не связано с реал. жизн)
                temp = rnd.Next(3), //рандомим в счетчике по которому будет получать какой строй у нашего инструмента
            };
        }

        // тута мы выводим наши значения в ричбокс
        public override String GetInfo()
        {
            var str = "Вы получили струнный инструмент!";

            str += base.GetInfo();
            str += String.Format("\nКоличество струн: {0}", this.StringsCount);
            str += String.Format("\nСтрой инструмента: {0}", this.MusicSystem[temp]); //собственно вот и выводим по массиву

            return str;
        }
    }

    // КЛАВИШНЫЕ инструменты
    public class Keydoard : MusicTools
    {
        public int KeysCount = 0; // кол-во клавиш
        public int OktavCount = 0; // кол-во октав

        // Дальше комментировать свои проблемы с логикой в познании музыкальных инструментов не буду С:

        // генерим наши значения инструмента
        public static Keydoard Generate()
        {
            return new Keydoard
            {
                type1 = (type)rnd.Next(2),
                toolCost = 5000 + rnd.Next(35000),
                KeysCount = 11 + rnd.Next() % 44,
                OktavCount = 1 + rnd.Next(8)
            };
        }

        // выводим снегеренные значения
        public override String GetInfo()
        {
            var str = "Вы получили клавишный инструмент!";

            str += base.GetInfo();
            str += String.Format("\nКоличество клавиш в инструменте: {0}", this.KeysCount);
            str += String.Format("\nКоличество октав в инструменте: {0}", this.OktavCount); //одна октава - это 12 клавиш

            return str;
        }
    }

    // БАРАБАННЫЕ инструменты
    public class Drum : MusicTools
    {
        public int radius = 0; // радиус барабанчиков
        public string[] drumtype = new string[3] { "большой", "средний", "малый" }; // Массив строк с счетчиком, чтобы его рандомить и выбирать по нему
        public int temp = 0;

        public static Drum Generate()
        {
            return new Drum
            {
                type1 = (type)rnd.Next(2), // тип инструмента
                toolCost = 5000 + rnd.Next(35000),
                radius = 20 + rnd.Next(150), // радиус барабана от 20см до 150см
                temp = rnd.Next(3)
            };
        }

        public override String GetInfo()
        {
            var str = "Вы получили Барабан!";

            str += base.GetInfo();
            str += String.Format("\nРадиус барабана: {0} см", this.radius);
            str += String.Format("\nТип барабана: {0}", this.drumtype[temp]); //точно так же по счетчику выбираем какой элм. нам вывести

            return str;
        }
    }
}
