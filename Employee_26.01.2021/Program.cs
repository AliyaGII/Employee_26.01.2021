using System;

namespace Employee_26._01._2021
{
    class Employee
    {
        public string name;
        public string surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string position;
        public double salary;
        public int experience;
     
       
        public double Tax()
        {
            return Math.Round(salary * 13 / 100, 2);
        }
        public double PensionFond()
        {
            return Math.Round(salary / 100, 2);
        }
        public double Wage()
        {
            return Math.Round((salary - Tax() - PensionFond()), 2);
        }
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{surname} {name}");
            if (position == "Factory Worker")
            {
                salary = 3000;
                if (experience >= 2 && experience < 5) salary += 480;
                if (experience >= 5 && experience < 10) salary += 1200;
                if (experience >= 15) salary += 2000;

            }
            if (position == "Teacher")
            {
                salary = 2000;
                if (experience >= 2 && experience < 5) salary += 480;
                if (experience >= 5 && experience < 10) salary += 1200;
                if (experience >= 15) salary += 2000;
            }
            if (position == "Coder")
            {
                salary = 27000;
                if (experience >= 2 && experience < 5) salary += 480;
                if (experience >= 5 && experience < 10) salary += 1200;
                if (experience >= 15) salary += 2000;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Position: {position}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Salary: {salary} somoni");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Experience: {experience} years");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Tax:(13% Tax( {Tax()} somoni ) + 1% Pension Fond ( {PensionFond()} somoni )");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Wage: {Wage()} somoni\n");
            Console.ForegroundColor = ConsoleColor.White;




        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Homer", "Any", "Mark" };
            string[] surnames = {"Simpson", "Teacher", "Zuckerberg"};
            string[] positions = { "Factory Worker", "Teacher", "Coder" };
            for (int i = 0; i < 3; i++)
            {
                Employee worker= new Employee(surnames[i], names[i]);
                worker.experience = new Random().Next(1, 15);
                worker.position = positions[i];
                worker.GetInfo();
            }
        }
    }
}
