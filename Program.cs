using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                const int numberOfSymbols = Task2.Padding / 2;

                string specialSymbols = new String(task.DecorativeSign, numberOfSymbols);
                string spaces = new String(' ', numberOfSymbols);
                FormattableString message = $"{specialSymbols}{spaces}${task.Balance:N2}{spaces}{specialSymbols}";
                return FormattableString.Invariant(message);
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
