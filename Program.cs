namespace MinorAdultAgeAndGrade
{
    internal class AgeAndGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a minor");
            }

            Console.WriteLine("What grade are you?");
            int grade = int.Parse(Console.ReadLine());

            if ((age >= 7 && age <= 11) && (grade >= 1 && grade < 5))
            {
                Console.WriteLine("You are an elementary school student.");
            }
            else if ((age > 11 && age <= 15) && (grade >= 5 && grade <= 7))
            {
                Console.WriteLine("You are a primary school student");
            }
            else if ((age > 15 && age <= 19) && (grade >= 8 && grade <= 12))
            {
                Console.WriteLine("You are a high school student");
            }
            else if (age > 19 && age <= 23 && grade > 12)
            {
                Console.WriteLine("You are an adult and already an university student");
            }
            else if (age <= 19 && grade > 12)
            {
                Console.WriteLine("You need to study more!");
            }
            else if (age < 7 && grade < 1)
            {
                Console.WriteLine("You are a child");
            }
            else
            {
                Console.WriteLine("You've studied enough!");
            }
        }
    }
}