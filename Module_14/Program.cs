namespace Module_14_1
{
    internal class Program
    {
        #region Where()
        //static void Main(string[] args)
        //{
        //    int[] numbers =
        //        {
        //        1,
        //        2,
        //        3,
        //        4,
        //        10,
        //        34,
        //        55,
        //        66,
        //        77,
        //        88
        //    };
        //    var evenNums = from i in numbers
        //                   where i % 2 == 0 && i > 10
        //                   select i;

        //    foreach (int i in evenNums)
        //        Console.WriteLine(i);

        //    //C методами расширения всё становится ещё проще : 
        //    var evens = numbers.Where(i => i % 2 == 0 && i > 10);

        //    foreach (int n in evens)
        //        Console.WriteLine(n);
        //}
        #endregion
        #region Задача по коллекциям
        //static void Main(string[] args)
        //{
        //    // Добавим Россию с её городами
        //    var russianCities = new List<City>();
        //    russianCities.Add(new City("Москва", 11900000));
        //    russianCities.Add(new City("Санкт-Петербург", 4991000));
        //    russianCities.Add(new City("Волгоград", 1099000));
        //    russianCities.Add(new City("Казань", 1169000));
        //    russianCities.Add(new City("Севастополь", 449138));

        //    // Выберем города-миллионники:
        //    var bigCities = from russianCity in russianCities
        //                    where russianCity.Population > 1000000
        //                    orderby russianCity.Population descending
        //                    select russianCity;

        //    foreach (var bigCity in bigCities)
        //        Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

        //    // То же самое с помощью методов расширения выглядит ещё проще:
        //    var bigCities2 = russianCities.Where(c => c.Population > 1000000)
        //        .OrderByDescending(c => c.Population);

        //    foreach (var bigCity2 in bigCities2)
        //        Console.WriteLine(bigCity2.Name + " - " + bigCity2.Population);
        //}

        //// Создадим модель класс для города
        //public class City
        //{
        //    public City(string name, long population)
        //    {
        //        Name = name;
        //        Population = population;
        //    }

        //    public string Name { get; set; }
        //    public long Population { get; set; }
        //}
        #endregion
        #region 14.1.1
        //static void Main(string[] args)
        //{
        //    // Добавим Россию с её городами
        //    var russianCities = new List<City>();
        //    russianCities.Add(new City("Москва", 11900000));
        //    russianCities.Add(new City("Санкт-Петербург", 4991000));
        //    russianCities.Add(new City("Волгоград", 1099000));
        //    russianCities.Add(new City("Казань", 1169000));
        //    russianCities.Add(new City("Севастополь", 449138));

        //    var shortNameCities = russianCities
        //        .Where(city => city.Name.Length <= 10) // выборка городов с коротким именем
        //        .OrderBy(city => city.Name.Length); // сортировка по длине имени

        //    foreach (var City in shortNameCities)
        //        Console.WriteLine(City.Name);
        //}

        //// Создадим модель класс для города
        //public class City
        //{
        //    public City(string name, long population)
        //    {
        //        Name = name;
        //        Population = population;
        //    }

        //    public string Name { get; set; }
        //    public long Population { get; set; }
        //}
        #endregion
        #region Сложные фильтры
        //static void Main(string[] args)
        //{
        //    // Словарь для хранения стран с городами
        //    var Countries = new Dictionary<string, List<City>>();

        //    // Добавим Россию с её городами
        //    var russianCities = new List<City>();
        //    russianCities.Add(new City("Москва", 11900000));
        //    russianCities.Add(new City("Санкт-Петербург", 4991000));
        //    russianCities.Add(new City("Волгоград", 1099000));
        //    russianCities.Add(new City("Казань", 1169000));
        //    russianCities.Add(new City("Севастополь", 449138));
        //    Countries.Add("Россия", russianCities);

        //    // Добавим Беларусь
        //    var belarusCities = new List<City>();
        //    belarusCities.Add(new City("Минск", 1200000));
        //    belarusCities.Add(new City("Витебск", 362466));
        //    belarusCities.Add(new City("Гродно", 368710));
        //    Countries.Add("Беларусь", belarusCities);

        //    // Добавим США
        //    var americanCities = new List<City>();
        //    americanCities.Add(new City("Нью-Йорк", 8399000));
        //    americanCities.Add(new City("Вашингтон", 705749));
        //    americanCities.Add(new City("Альбукерке", 560218));
        //    Countries.Add("США", americanCities);

        //    // Задача: сделать выборку городов-миллионников по всем странам.
        //    // Решим её с помощью LINQ:
        //    var cities = from country in Countries // пройдемся по странам
        //                 from city in country.Value // пройдемся по городам
        //                 where city.Population > 1000000 // выберем города - миллионники
        //                 orderby city.Population descending // отсортируем по населению
        //                 select city;

        //    foreach (var city in cities)
        //        Console.WriteLine(city.Name + " - " + city.Population);
        //}

        //// Создадим модель класс для города
        //public class City
        //{
        //    public City(string name, long population)
        //    {
        //        Name = name;
        //        Population = population;
        //    }

        //    public string Name { get; set; }
        //    public long Population { get; set; }
        //}
        #endregion
        #region 14.1.2
        //static void Main(string[] args)
        //{
        //    string[] text = { "Раз два три", "четыре пять шесть", "семь восемь девять" };

        //    var words = from str in text // пробегаемся по элементам массива
        //                from word in str.Split(' ') // дробим каждый элемент по пробелам, сохраняя в новую последовательность
        //                select word; // собираем все куски в результирующую выборку

        //    // выводим результат
        //    foreach (var word in words)
        //        Console.WriteLine(word);
        //}
        #endregion
        #region SelectMany()
        //static void Main(string[] args)
        //{
        //    // Подготовим данные
        //    List<Student> students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    // Составим запрос ()
        //    var selectedStudents = students.SelectMany(
        //        // коллекция, которую нужно преобразовать
        //        s => s.Languages,
        //        // функция преобразования, применяющаяся к каждому элементу коллекции
        //        (s, l) => new { Student = s, Lang = l })
        //        // дополнительные условия 
        //        .Where(s => s.Lang == "английский" && s.Student.Age < 28)
        //        // указатель на объект выборки
        //        .Select(s => s.Student);

        //    // Выведем результат
        //    foreach (Student student in selectedStudents)
        //        Console.WriteLine($"{student.Name} - {student.Age}");
        //}
        #endregion
        #region 14.1.5
        //static void Main(string[] args)
        //{
        //    var companies = new Dictionary<string, string[]>();

        //    companies.Add("Apple", new[] { "Mobile", "Desktop" });
        //    companies.Add("Samsung", new[] { "Mobile" });
        //    companies.Add("IBM", new[] { "Desktop" });

        //    var mobileCompanies = companies
        //       // смотрим те из выборки, значения в которых содержат искомое
        //       .Where(c => c.Value.Contains("Mobile"));

        //    foreach (var company in mobileCompanies)
        //        Console.WriteLine(company.Key);
        //}
        #endregion
        #region 14.1.6
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
                new[] {2, 3, 7, 1},
                new[] {45, 17, 88, 0},
                new[] {23, 32, 44, -6},
            };

            var orderedNums = numsList
                .SelectMany(s => s) // выбираем элементы
                .OrderBy(s => s); // сортируем

            // выводим
            foreach (var ord in orderedNums)
                Console.WriteLine(ord);
        }
        #endregion
    }
}