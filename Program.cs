
// //      --------------------------  Task 1    ------------------------------
//
// using Homework2_week2.Person;
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Person person = new Person();
//         Console.Write("Input your first name: ");
//         person.FirstName = Console.ReadLine();
//         Console.Write("Input your last name: ");
//         person.LastName =Console.ReadLine();
//         Console.Write("Input your age: ");
//         person.Age =int.Parse(Console.ReadLine());
//         Console.Write("Input your Address: ");
//         person.Address =Console.ReadLine();
//         
//         Console.WriteLine("----------------------------------------");
//         Console.WriteLine(person.GetFullName());
//         Console.WriteLine($"My birth year is: {person.GetBirthYear()}");
//         Console.WriteLine(person.GetAddress());
//     }
// }

// // ------------------------------  Task 2  --------------------------------
//
// using Homework2_week2.Rectangle;
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Rectangle rectangle = new Rectangle();
//         
//         Console.Write("Input width: ");
//         rectangle.Width = int.Parse(Console.ReadLine());
//         Console.Write("Input height: ");
//         rectangle.Height = int.Parse(Console.ReadLine());
//         
//         Console.WriteLine($"Area is: {rectangle.Area}");
//     }
// }

// ----------------------------------  Task 3 ------------------------------------

// using Homework2_week2;
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Student student = new Student();
//         Console.Write("Input the student name: ");
//         student.Name = Console.ReadLine();
//         Console.Write("Input the student grade level: ");
//         student.GradeLevel =int.Parse(Console.ReadLine());
//         Console.WriteLine("Input the student scores: ");
//         for (int i = 0; i < 4; i++)
//         {
//             Console.Write($"{i+1}- score is: ");
//             student.Scores[i] = int.Parse(Console.ReadLine());
//         }
//
//         if (student.GetAverage() >= 85)
//         {
//             Console.WriteLine($"Congratulations {student.Name} on achieving an average scores {student.GetAverage()} in grade {student.GradeLevel} \n Keep up the good working");
//         }
//
//         if (student.GetAverage() < 85 && student.GetAverage() > 75)
//         {
//             Console.WriteLine($"Congratulations {student.Name} on achieving above average scores {student.GetAverage()} in grade {student.GradeLevel} \n Keep up the good working");
//         }
//         else
//         {
//             Console.WriteLine($"{student.Name}, If you are having difficulties with your studies, don't hesitate to seek help. Ypur current average score {student.GetAverage()} in grade {student.GradeLevel} ");
//         }
//     }
// }

// // ---------------------------------- Task 4 ---------------------------------------
//
// using Homework2_week2;
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Car car = new Car();
//         Console.Write("Enter the company of car: ");
//         car.Make = Console.ReadLine();
//         Console.Write("Enter the model of car: ");
//         car.Model = Console.ReadLine();
//         Console.Write("Enter the year of car: ");
//         car.Year = int.Parse(Console.ReadLine());
//         Console.Write("Enter the Mileage of car: ");
//         car.Mileage = int.Parse(Console.ReadLine());
//         Console.Write("Enter the Fuel level of car: ");
//         car.Fuel = int.Parse(Console.ReadLine());
//         
//         Console.WriteLine($"Make: {car.Make} \n Model: {car.Model} \n Year: {car.Year} \n Mileage: {car.Mileage} \n Fuel: {car.Fuel}");
//
//         Console.Write("How many mileage you have driven in the car: ");
//         int miles = int.Parse(Console.ReadLine());
//         car.Drive(miles);
//         Console.Write("How many fuel you have added to the car: ");
//         int galloons = int.Parse(Console.ReadLine());
//         car.AddFuel(galloons);
//         Console.WriteLine($"You have driven {miles} miles. Current mileage is {car.Mileage} miles. Added {galloons} gallooons of fuel. Current fuel level is {car.Fuel} galloons.");
//         Console.WriteLine();
//         Console.WriteLine("After th trip and refueling: ");
//         Console.WriteLine($"Mileage: {car.Mileage} miles");
//         Console.WriteLine($"Fuel: {car.Fuel} fuel");
//     }
//}