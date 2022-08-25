using Module_14_2;

namespace Module_14_3_3
{
    internal class Program
    {
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

            // Сортировка по имени и фамилии (возрастание)
            var resultPhoneBook = phoneBook
                .OrderBy(name => name.Name)
                .ThenBy(surname => surname.LastName);

            // Вывод результата в консоль
            foreach (var e in resultPhoneBook)
                Console.WriteLine(e.Name + " " + e.LastName);

            Console.ReadLine();
        }
    }
}