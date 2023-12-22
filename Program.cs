using Test_task;

namespace MyProject;
class Program
{
    
    static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();
        //тут можно расскомитить дял быстрого тестирования
        //studentManager.AddStudent("Иванов", "Иван", 15, 3, 4, 3);
        //studentManager.AddStudent("Сергеев", "Сергей", 14, 5, 2, 3);
        //studentManager.AddStudent("Михаилов", "Михаил", 14, 5, 5, 4);

        Console.WriteLine("Здраствуйте.");
        Console.WriteLine("Введите команду. Подсказка:");
        Help();

        bool notClose = true;
        while (notClose) //консольное приложение будет работать, пока не введут команду выхода из программы
        {
            string read = Console.ReadLine();
            string[] cod = read.Split(' ');
            switch (cod[0])//взаимодействие с консолью реализовано с помощью ввода команд
            {
                case "/add":
                    try
                    {
                        studentManager.AddStudent(cod[1], cod[2], Int32.Parse(cod[3]),
                        Int32.Parse(cod[4]), Int32.Parse(cod[5]), Int32.Parse(cod[6]));
                        Console.WriteLine("Студент успешно добавлен");
                    }catch (Exception) { Console.WriteLine("Неправильно введенная команда"); } //проверка на ввод нулевого значения или несоответствие типу данных
                    break;
                case "/show":
                    studentManager.WriteStudentsList();
                    break;
                case "/avg":
                        Console.WriteLine("Средние баллы учеников по предметам:");
                        studentManager.AvgSubjects();
                    break;
                case "/help":
                    Help();
                    break;
                case "/close":
                    notClose = false;
                    break;
            }
        }
        
    }

    //подсказки по командам, выведены в отдельный метод для избежания повторений в коде
    private static void Help()
    {
        Console.WriteLine("/add {фамилия} {имя} {возраст} {оценка по математике} {русскому} {литературе} <-- добавить ученика в список");
        Console.WriteLine("/show <-- показать список учеников");
        Console.WriteLine("/avg <-- средние оценки по каждому предмету");
        Console.WriteLine("/help <-- перечень доступных команд");
        Console.WriteLine("/close <-- выйти");
    }
}