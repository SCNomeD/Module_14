using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Module_14_2
{
    internal class Program
    {
        #region Select()
        //static void Main(string[] args)
        //{
        //    List<Student> students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    var names = from s in students select s.Name;

        //    // Выведем результат
        //    foreach (var name in names)
        //        Console.WriteLine(name);
        //}
        #endregion
        #region Select() продолжение
        //// Допустим, из данных по студентам мы хотим выгрузить для них анкеты,
        //// но описывать модель класса анкеты не хотим, ведь больше нигде она нам
        //// не понадобится. 
        //static void Main(string[] args)
        //{
        //    // Наш список студентов
        //    List<Student> students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    var studentApplications = from s in students
        //                                  // создадим анонимный тип для представления анкеты
        //                              select new
        //                              {
        //                                  FirstName = s.Name,
        //                                  YearOfBirth = DateTime.Now.Year - s.Age
        //                              };

        //    // Либо, если модель Анкеты у нас есть, так: 
        //    var studentApplications2 = from s in students
        //                                   // спроецируем в новую сущеность анкеты
        //                               select new Application()
        //                               {
        //                                   FirstName = s.Name,
        //                                   YearOfBirth = DateTime.Now.Year - s.Age
        //                               };

        //    // Выведем результат
        //    foreach (var application in studentApplications)
        //        Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");

        //    foreach (var application in studentApplications2)
        //        Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
        //}
        #endregion
        #region Select() продолжение 2
        //static void Main(string[] args)
        //{
        //    // Наш список студентов
        //    List<Student> students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    // выборка имен в строки
        //    var names = students.Select(u => u.Name);

        //    // проекция в анонимный тип
        //    var applications = students.Select(u => new
        //    {
        //        FirstName = u.Name,
        //        YearOfBirth = DateTime.Now.Year - u.Age
        //    });

        //    // проекция в другой тип, если есть модель анкеты
        //    var applications1 = students.Select(u => new Application()
        //    {
        //        FirstName = u.Name,
        //        YearOfBirth = DateTime.Now.Year - u.Age
        //    });

        //    // Выведем результат
        //    Console.WriteLine("Выборка имен в строки:");
        //    foreach (var name in names)
        //        Console.WriteLine(name);

        //    Console.WriteLine("Проекция в анонимный тип:");
        //    foreach (var application in applications)
        //        Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");

        //    Console.WriteLine("Проекция в другой тип, если есть модель анкеты:");
        //    foreach (var application in applications1)
        //        Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
        //}
        #endregion
        #region 14.2.1
        //static void Main(string[] args)
        //{
        //    string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

        //    var wordsInfo = words.Select(w =>
        //    new
        //    {  // Выборка в анонимный тип
        //        Name = w,
        //        Length = w.Length // Длину слова сохраняем сразу в свойство нового анонимного типа
        //    })
        //        .OrderBy(word => word.Length); //  сортируем коллекцию по длине

        //    // выводим
        //    foreach (var word in wordsInfo)
        //        Console.WriteLine($"{word.Name} - {word.Length} букв");
        //}
        #endregion
        #region Переменные в запросах, let
        //static void Main(string[] args)
        //{
        //    // Наш список студентов
        //    List<Student> students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    var fullNameStudents = from s in students
        //                               // временная переменная для генерации полного имени
        //                           let fullName = s.Name + " Иванов"
        //                           // проекция в новую сущность с использованием новой переменной
        //                           select new
        //                           {
        //                               Name = fullName,
        //                               Age = s.Age
        //                           };

        //    foreach (var stud in fullNameStudents)
        //        Console.WriteLine(stud.Name + ", " + stud.Age);

        //    // Методы расширения, к сожалению, не поддерживают определение внутренних
        //    // локальных переменных, и это одно из основных преимуществ операторов перед ними.
        //}
        #endregion
        #region 14.2.3
        //static void Main(string[] args)
        //{
        //    // Наш список студентов
        //    List<Student> students = new List<Student>
        //        {
        //            new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //            new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //            new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //            new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //        };

        //    var youngStudentApplications = from s in students
        //                                   where s.Age < 27 // берем тех, кто младше 27
        //                                   let birthYear = DateTime.Now.Year - s.Age // Вычисляем год рождения
        //                                   select new Application() // создаем анкеты
        //                                   {
        //                                       Name = s.Name,
        //                                       YearOfBirth = birthYear
        //                                   };

        //    // Вывод
        //    foreach (var studApplication in youngStudentApplications)
        //        Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);
        //}
        #endregion
        #region Множественная выборка
        //static void Main(string[] args)
        //{
        //    // Список студентов
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
        //    };

        //    // Список курсов
        //    var coarses = new List<Coarse>
        //    {
        //        new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
        //        new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
        //    };

        //    // добавим студентов в курсы
        //    var studentsWithCoarses = from stud in students
        //                              from coarse in coarses
        //                              select new { Name = stud.Name, CoarseName = coarse.Name };

        //    // выведем результат
        //    foreach (var stud in studentsWithCoarses)
        //        Console.WriteLine($"Студент {stud.Name} добавлен курс {stud.CoarseName}");
        //}
        #endregion
        #region 14.2.4
        //static void Main(string[] args)
        //{
        //    // Список студентов
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
        //    };

        //    // Список курсов
        //    var coarses = new List<Coarse>
        //    {
        //        new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
        //        new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
        //    };

        //    var studentsWithCoarses = from stud in students
        //                              where stud.Age < 29 // берем всех студентов младше 29
        //                              where stud.Languages.Contains("английский") // ищем тех, у кого в списке языков есть английский
        //                              let birthYear = DateTime.Now.Year - stud.Age // Вычисляем год рождения
        //                              from coarse in coarses
        //                              where coarse.Name.Contains("C#") // теперь выбираем только курс по C#
        //                              select new // выборка в новую сущность
        //                              {
        //                                  Name = stud.Name,
        //                                  BirthYear = birthYear,
        //                                  CoarseName = coarse.Name
        //                              };

        //    // выведем результат
        //    foreach (var stud in studentsWithCoarses)
        //        Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");
        //}
        #endregion
        #region Skip(), Take()
        //static void Main(string[] args)
        //{
        //    // Для пропуска элементов существует метод Skip(), а для включения элементов в
        //    // выборку — Take().
        //    var cars = new[] { "Volvo", "Opel", "Suzuki", "Toyota", "Lada", "Kamaz" };

        //    // пропустим первые два элемента
        //    Console.WriteLine("Пропустим первые два элемента:");
        //    var skip = cars.Skip(2);

        //    foreach (var car in skip)
        //        Console.WriteLine(car);

        //    // Skip() и Take() удобно сочетать:
        //    // пропустим первые два элемента и выведем следующие два
        //    Console.WriteLine("Пропустим первые два элемента и выведем следующие два:");
        //    var skip2 = cars.Skip(2).Take(2);

        //    foreach (var car in skip2)
        //        Console.WriteLine(car);
        //}
        #endregion
        #region 12.2.5
        //static void Main(string[] args)
        //{
        //    var contacts = new List<Contact>();

        //    contacts.Add(new Contact("Андрей", 7999945005));
        //    contacts.Add(new Contact("Сергей", 799990455));
        //    contacts.Add(new Contact("Иван", 79999675));
        //    contacts.Add(new Contact("Игорь", 8884994));
        //    contacts.Add(new Contact("Анна", 665565656));
        //    contacts.Add(new Contact("Василий", 3434));

        //    // бесконечный цикл, ожидающий ввод с консоли
        //    while (true)
        //    {
        //        Console.WriteLine("\nВведите номер страницы от 1 до 3:");
        //        var keyChar = Console.ReadKey().KeyChar; // получаем символ с консоли
        //        Console.Clear();  //  очистка консоли от ввода


        //        if (!Char.IsDigit(keyChar))
        //        {
        //            Console.WriteLine("Ошибка ввода, введите число");
        //        }
        //        else
        //        {
        //            //  переменная для хранения запроса в зависимости от введенного с консоли числа
        //            IEnumerable<Contact> page = null;

        //            //  выбираем нужное кол-во элементов для создания постраничного ввода в зависимости от запроса
        //            switch (keyChar)
        //            {
        //                case ('1'):
        //                    page = contacts.Take(2);
        //                    break;
        //                case ('2'):
        //                    page = contacts.Skip(2).Take(2);
        //                    break;
        //                case ('3'):
        //                    page = contacts.Skip(4).Take(2);
        //                    break;
        //            }

        //            //   проверим, что ввели существующий номер страницы
        //            if (page == null)
        //            {
        //                Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
        //                continue;
        //            }

        //            // вывод результата на консоль
        //            foreach (var contact in page)
        //                Console.WriteLine(contact.Name + " " + contact.PhoneNumber);
        //        }
        //    }
        //}
        #endregion
        #region SkipWhile(), TakeWhile()
        //static void Main(string[] args)
        //{
        //    // Подготовка данных
        //    var cars = new List<Car>()
        //    {
        //        new Car("Suzuki", "JP"),
        //        new Car("Toyota", "JP"),
        //        new Car("Opel", "DE"),
        //        new Car("Kamaz", "RUS"),
        //        new Car("Lada", "RUS"),
        //        new Car("Lada", "RUS"),
        //        new Car("Honda", "JP"),
        //    };

        //    Console.WriteLine("Пропустим японские машины в начале списка");
        //    var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP");

        //    foreach (var notJapanCar in notJapanCars)
        //        Console.WriteLine(notJapanCar.Manufacturer);

        //    Console.WriteLine();

        //    Console.WriteLine("Теперь выберем только японские машины из начала списка");
        //    var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");

        //    foreach (var japanCar in japanCars)
        //        Console.WriteLine(japanCar.Manufacturer);
        //}
        #endregion
        #region 14.2.10
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                Console.WriteLine("Введите номер страницы от 1 до 3.");

                // Читаем введенный с консоли символ
                var input = Console.ReadKey().KeyChar;

                // проверяем, число ли это
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

                // если не соответствует критериям - показываем ошибку
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine("\nСтраницы не существует\n");
                }
                // если соответствует - запускаем вывод
                else
                {
                    // пропускаем нужное количество элементов и берем 2 для показа на странице
                    var pageContent = phoneBook.Skip((pageNumber - 1) * 2).Take(2);

                    Console.WriteLine();
                    // выводим результат
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);
                    Console.WriteLine();
                }
            }
        }
        #endregion
    }
}