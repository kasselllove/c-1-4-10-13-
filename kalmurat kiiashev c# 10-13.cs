using System;
using System.Collections.Generic;

// ---- 10 ---- //

class RecipePlanner
{
    static Dictionary<string, List<string>> recipes = Dictionary<string, List<string>>();
    static Dictionary<string, string> instructions = Dictionary<string, string>();
    static Dictionary<string, string> weeklyMenu = Dictionary<string, string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню рецептов и план питания:");
            Console.WriteLine("1. Добавить рецепт");
            Console.WriteLine("2. Запланировать меню на неделю");
            Console.WriteLine("3. Показать меню на неделю");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddRecipe();
                    break;
                case "2":
                    PlanMenu();
                    break;
                case "3":
                    ShowMenu();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }
    }

    static void AddRecipe()
    {
        Console.Write("Введите название рецепта: ");
        string recipeName = Console.ReadLine();

        Console.WriteLine("Введите ингредиенты (введите 'stop', чтобы завершить):");
        List<string> ingredients = List<string>();
        string ingredient;
        while ((ingredient = Console.ReadLine()) != "stop")
        {
            ingredients.Add(ingredient);
        }

        Console.Write("Введите инструкцию по приготовлению: ");
        string instruction = Console.ReadLine();

        recipes[recipeName] = ingredients;
        instructions[recipeName] = instruction;
        Console.WriteLine("Рецепт добавлен.");
    }

    static void PlanMenu()
    {
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        for (int i = 0; i < days.Length; i++)
        {
            Console.Write($"Введите блюдо для {days[i]}: ");
            string dish = Console.ReadLine();
            if (recipes.ContainsKey(dish))
            {
                weeklyMenu[days[i]] = dish;
            }
            else
            {
                Console.WriteLine("Рецепт не найден. Пожалуйста, добавьте его.");
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nМеню на неделю:");
        foreach (var day in weeklyMenu)
        {
            Console.WriteLine($"{day.Key}: {day.Value}");
        }
    }
}

// ---- 11 ---- //

class SkillCourses
{
    static Dictionary<string, double> courses = Dictionary<string, double>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню курсов и навыков:");
            Console.WriteLine("1. Добавить курс");
            Console.WriteLine("2. Обновить курсы");
            Console.WriteLine("3. Показать курсы");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCourse();
                    break;
                case "2":
                    UpdateProgress();
                    break;
                case "3":
                    ShowProgress();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверно");
                    break;
            }
        }
    }

    static void AddCourse()
    {
        Console.Write("Введите название курса: ");
        string course = Console.ReadLine();

        courses[course] = 0;
        Console.WriteLine("Курс добавлен.");
    }

    static void UpdateProgress()
    {
        Console.Write("Введите название курса для обновления: ");
        string course = Console.ReadLine();

        if (courses.ContainsKey(course))
        {
            Console.Write("Введите прогресс курса (проценты): ");
            double progress = Convert.ToDouble(Console.ReadLine());
            courses[course] = progress;
            Console.WriteLine("Прогресс обновлен.");
        }
        else
        {
            Console.WriteLine("Курс не найден.");
        }
    }

    static void ShowProgress()
    {
        Console.WriteLine("\nПрогресс курсов:");
        foreach (var course in courses)
        {
            string status = course.Value == 100 ? "Завершено" : "В процессе";
            Console.WriteLine($"{course.Key}: {course.Value}% - {status}");
        }
    }
}

// ---- 12 ---- //

class TravelPlanner
{
    class Trip
    {
        public string Destination;
        public double Budget;
        public DateTime StartDate;
        public DateTime EndDate;
        public List<string> Events = new List<string>();
    }

    static List<Trip> trips = new List<Trip>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nПланировщик путешествий:");
            Console.WriteLine("1. Добавить поездку");
            Console.WriteLine("2. Показать поездки");
            Console.WriteLine("3. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTrip();
                    break;
                case "2":
                    ShowTrips();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Неверно");
                    break;
            }
        }
    }

    static void AddTrip()
    {
        Trip trip = new Trip();

        Console.Write("Введите место назначения: ");
        trip.Destination = Console.ReadLine();

        Console.Write("Введите бюджет: ");
        trip.Budget = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите дату начала поездки: ");
        trip.StartDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Введите дату окончания поездки: ");
        trip.EndDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Введите мероприятия для поездки (введите stop, чтобы завершить): ");

        string eventInfo;
        while ((eventInfo = Console.ReadLine()) != "stop")
        {
            trip.Events.Add(eventInfo);
        }

        trips.Add(trip);
        Console.WriteLine("Поездка добавлена");
    }

    static void ShowTrips()
    {
        if (trips.Count == 0)
        {
            Console.WriteLine("Нет запланированных поездок");
            return;
        }

        foreach (var trip in trips)
        {
            Console.WriteLine($"\nПоездка в {trip.Destination} с {trip.StartDate:yyyy-MM-dd} по {trip.EndDate:yyyy-MM-dd}");
            Console.WriteLine($"Бюджет: {trip.Budget}");
            Console.WriteLine("Мероприятия:");
            foreach (var eventInfo in trip.Events)
            {
                Console.WriteLine($"- {eventInfo}");
            }
        }
    }
}

// ---- 13 ---- // 

class FinancialAnalysis
{
    static List<double> incomes = new List<double>();
    static List<double> expenses = new List<double>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nФинансовый анализ:");
            Console.WriteLine("1. Ввести доход");
            Console.WriteLine("2. Ввести расход");
            Console.WriteLine("3. Показать финансовый анализ");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddIncome();
                    break;
                case "2":
                    AddExpense();
                    break;
                case "3":
                    ShowAnalysis();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверно");
                    break;
            }
        }
    }

    static void AddIncome()
    {
        Console.Write("Введите сумму дохода: ");
        double income = Convert.ToDouble(Console.ReadLine());
        incomes.Add(income);
        Console.WriteLine("Доход добавлен.");
    }

    static void AddExpense()
    {
        Console.Write("Введите сумму расхода: ");
        double expense = Convert.ToDouble(Console.ReadLine());
        expenses.Add(expense);
        Console.WriteLine("Расход добавлен.");
    }

    static void ShowAnalysis()
    {
        double totalIncome = 0;
        double totalExpense = 0;

        foreach (double income in incomes)
        {
            totalIncome += income;
        }

        foreach (double expense in expenses)
        {
            totalExpense += expense;
        }

        double balance = totalIncome - totalExpense;

        Console.WriteLine($"\nОбщий доход: {totalIncome}");
        Console.WriteLine($"Общие расходы: {totalExpense}");
        Console.WriteLine($"Баланс: {balance}");

        if (balance < 0)
        {
            Console.WriteLine("Ваши расходы превышают доходы");
        }
        else
        {
            Console.WriteLine("Финансовое состояние стабильное");
        }
    }
}
