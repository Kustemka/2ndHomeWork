using System;


namespace Practic2Kustov
{
    class Program
    {
        static void Main(string[] args)
        {
            String FullName, Mail;
            int age;
            double maths, programming, physics;
            FullName = "Кустов Артем Александрович";
            Mail = "kystiksmk@gmail.com";
            age = 22;
            maths = 4.6;
            programming = 3.3;
            physics = 3.9;

            //Подсчет суммы баллов и среднего балла
            double sumResults, avrgResults;
                sumResults = maths + programming + physics;
            avrgResults = sumResults / 3;
            string sumRes = sumResults.ToString("#.#");
            string avrgRes = avrgResults.ToString("#.#");

            //string pattern = "Ф.И.О.: {0} \nПочта: {1} \nВозраст: {2} \nБаллы по математике: {3}  \nБаллы по программированию: {4}  \nБаллы по физике: {5}";
            //Console.WriteLine(pattern,
            //                  FullName,
            //                  Mail,
            //                  age,
            //                  maths,
            //                  programming,
            //                  physics);

            Console.WriteLine($"Ф.И.О.: {FullName} \nПочта: {Mail} \nВозраст: {age} \nБаллы по математике: {maths} \nБаллы по программированию: {programming} \nБаллы по физике: {physics} \n_________________ \nОбщий балл: {sumRes} \nСредний балл: {avrgRes}");
            Console.ReadKey();
        }
    }
}
