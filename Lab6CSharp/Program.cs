using System.Security.Cryptography.X509Certificates;

namespace Lab6CSharp
{


    class Program
    {
        static void task1()
        {
            // Creating objects of different classes
            Console.WriteLine("Create states:");

            Republic republic = new Republic("Republic", 331449281, "RCapital.", "President");
            Monarchy monarchy = new Monarchy("Monarchy", 67886011, "MCapital", "MKing");
            Kingdom kingdom = new Kingdom("Kingdom", 46754778, "KCapital", "KKing");

            Console.WriteLine();

            // Showing objects
            Console.WriteLine("Showing objects:");
            republic.Show();
            monarchy.Show();
            kingdom.Show();

            Console.WriteLine();

            // Testing destruction order
            Console.WriteLine("Destructors:");
            TestDestructors();

            Console.ReadLine();
        }

        static void TestDestructors()
        {
            Monarchy testMonarchy = new Monarchy("TMonarchy", "TMonarch");
            Republic testRepublic = new Republic("TRepublic", "TPresident");
            Kingdom testKingdom = new Kingdom("TKingdom", "TKing");
        }
        public static void task2()
        {
            // Створення каталогу видань
            IVydannia[] catalog = new IVydannia[]
            {
            new Book("Book1", "Author1", 2010, " Publisher"),
            new Article("Article2", "Author2", "Journal2", 25, 2015),
            new ElectronicResource("ElectronicResource3", "Author2", "http://elecres.com", "Description..")
            };

            // Виведення повної інформації з каталогу
            foreach (var item in catalog)
            {
                item.DisplayInfo();
            }

            // Пошук видань за прізвищем автора
            string searchAuthor = "Author2";
            Console.WriteLine($"\nSearch by author '{searchAuthor}':");
            foreach (var item in catalog)
            {
                if (item.IsAuthor(searchAuthor))
                {
                    item.DisplayInfo();
                }
            }


        }

        public static void task3()
        {
            int i=1;
            Rectangle rectangle = new Rectangle(3, 4, 5);
            foreach (int side in rectangle)
            {
                Console.WriteLine("Side " + i + ": " + side);
                i++;
            }

        }

        static void Main(string[] args)
        {
            //ask user what task to run
            Console.WriteLine("Enter the number of the task you want to run (1/2/3):");
            string taskNumber = Console.ReadLine();
            //switch to the task
            switch (taskNumber)
            {
                case "1":
                    task1();
                    break;
                case "2":
                    task2();
                    break;
                case "3":
                    task3();
                    break;
                default:
                    Console.WriteLine("Invalid task number");
                    break;
            }
        }
    }

}