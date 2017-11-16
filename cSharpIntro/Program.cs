using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region commented code
            /*
            string title = "testing" + " C#\n\t\"Javascript\"";
            string path = "C:\\Documents\\images";
            string path2 = @"C:\Documents\images";

            int number = -25;
            bool isHoliday = true;
            double distance = 33.3;
            decimal salary = 100000.75m;
            string mySalary = salary.ToString("c3");
            Console.WriteLine(mySalary);
            decimal rate = .15m;
            //string myRate = rate.ToString("p0");

            double y = 54567;
            string x = y.ToString("AMZ000-00-0000");
            string z = y.ToString("AMZ###-##-####");  //# - optional placeholder
            string a = "85";
            /*int.Parse, double.Parse, decimal.Parse, bool.Parse 

            int b = int.Parse(a) + 5;
            Console.WriteLine(b);
            Console.WriteLine(x);
            Console.WriteLine(z);
            //Console.WriteLine(salary);
            Console.WriteLine(distance);

            Console.WriteLine("Hello World!");
            Console.WriteLine(path + number);
            Console.WriteLine(path2);
            Console.WriteLine(title);
            Console.WriteLine(number);
            Console.WriteLine(isHoliday);

            Console.ReadLine();

            //Loops
            for (int i = 1; i <= 10; i++) {
               // Console.WriteLine("7 x " + i + " = " + (i * 7));
            Console.WriteLine("{2} x {1} = {0}", i * 7 , i ,7 );
            }
            Console.ReadLine();

            //while loop
            int bonus = 5075;
            while (bonus > 500) {
                bonus -= 500;
                Console.WriteLine("$500 bonus paid, bonus left: {0}", bonus);
            }
            Console.ReadLine();

            //do while
            string answer = "y";
            int total = 0;
            while (answer == "y") {
                Console.WriteLine("Enter expense:");
                string expense = Console.ReadLine();
                if (expense == "")
                {
                    continue; //if user enters string it will prompt you to ask again.
                }
                
                int iexpense = int.Parse(expense); //converting string to int
                if (iexpense > 10000)
                {
                    break; //stop there and not continue the loop
                }
                total += iexpense; //update total
                Console.WriteLine("Do you want to enter another expense? (y/n)"); //ask if they want to enter another expense
                answer = Console.ReadLine();//update the loop condition
            }
            Console.WriteLine("Your total expenses are: {0}", total.ToString("c"));//convert into currency format
            answer = Console.ReadLine();
                   } */
            #endregion
            //classes
            Book myBook = new Book(); //Making a new object called 'myBook'
            myBook.Author = "Joe Smith";
            myBook.Title = "Joe's Book";
            myBook.Price = 900000m;
            Console.WriteLine(myBook);
            Console.ReadLine();

            Product phone = new Product();
            phone.Title = "iPhone 8";
            phone.Description = "Apples latest phone";
            phone.Price = 799m;
            phone.SKU = "4958202";
            phone.Qty = 10;
            phone.Image = "phone.jpg";
            phone.SalePrice = 50m;

            Console.WriteLine(phone.InStock());
            Book hisBook = new Book()
            {
                Title = "Max Adventures",
                Price = 9m,
                Author = "Jeff Case"
            };
            Console.WriteLine(hisBook);
            Console.ReadLine();

            Shape shape1 = new Shape();
            shape1.Type = "Square";
            shape1.Color = "Red";
            shape1.Draw();

            Shape shape2 = new Shape();
            shape2.Type = "Circle";
            shape2.Color = "Green";
            shape2.Draw();

            Shape shape3 = new Shape();
            shape3.Type = "Triangle";
            shape3.Color = "Yellow";
            shape3.Draw();
        }
    }
}