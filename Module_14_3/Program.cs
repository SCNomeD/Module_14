namespace Module_14_3
{
    internal class Program
    {
        #region Простая сортировка OrderBy(),OrderByDescending()
        //static void Main(string[] args)
        //{
        //    // Список студентов
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    // Сортировка по увеличению возраста
        //    Console.WriteLine("Сортировка по увеличению возраста:");
        //    var sortedStuds = from s in students orderby s.Age select s;

        //    foreach (var stud in sortedStuds)
        //        Console.WriteLine(stud.Name + ", " + stud.Age);

        //    // Сортировка по убыванию возраста
        //    Console.WriteLine("Сортировка по убыванию возраста:");
        //    var sortedStuds2 = from s in students orderby s.Age descending select s;

        //    foreach (var stud in sortedStuds2)
        //        Console.WriteLine(stud.Name + ", " + stud.Age);

        //    // То же самое через методы расширения:
        //    // По возрастанию
        //    var sortedStudentsAsc = students.OrderBy(s => s.Age);

        //    // По убыванию
        //    var sortedStudentsDesc = students.OrderByDescending(s => s.Age);
        //}
        #endregion
        #region Множественная сортировка
        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
            {
                new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            // Сортировка сначала по имени, а затем - по возрасту
            var sortedStuds = from s in students orderby s.Name, s.Age select s;

            foreach (var stud in sortedStuds)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            // Через методы расширения по возрастанию:
            // Сортировка по имени и возрасту (возрастание)
            var sortedStuds2 = students
               .OrderBy(s => s.Name)
               .ThenBy(s => s.Age);

            foreach (var stud in sortedStuds2)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            // Через методы расширения по убыванию:
            // Сортировка по имени и возрасту(убывание)
            var sortedStudsDesc = students
                .OrderByDescending(s => s.Name)
                .ThenByDescending(s => s.Age);

            foreach (var stud in sortedStudsDesc)
                Console.WriteLine(stud.Name + ", " + stud.Age);
        }
        #endregion
        #region
        //static void Main(string[] args)
        //{

        //}
        #endregion
    }
}