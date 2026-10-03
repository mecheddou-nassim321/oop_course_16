using System;
 class Settings
{
    public static int DayNumber
    {
        get
        {
            return DateTime.Today.Day;
        }
    }

    public static string DayName
    {
        get
        {
            return DateTime.Today.DayOfWeek.ToString();
        }
    }

    public static string ProjectPath
    {
        get;
        set;
    }

    //this is a private constructor to prevent creating object from this class
     static Settings()
    {
        ProjectPath = @"C:\MyProjects\";
    }
}
class clsPersonne
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string userName { get; set; }
    public string Password { get; set; }

    public clsPersonne()
    {
        ID = -1;
        Name = "empty";
        Age = 0;
    }
    /* public clsPersonne(int iD, string name, int age)
     {
         this.ID = iD;
         this.Name = name;
         this.Age = age;
     }
     ~clsPersonne()
     {
         Console.WriteLine("Destructor called.");
     }
     public static clsPersonne find(int ID)
     {
         if (ID == 10)
         {
             return new clsPersonne(10, "yahia", 22);
         }
         else
         {
             return null;
         }

     }
     public static clsPersonne find(string userName, string password)
     {
         if (userName == "yahia" && password == "yahia123")
         {
             return new clsPersonne(10, "yahia", 22);
         }
         else
         {
             return null;
         }
     }

     */
  public  class clsPersone
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            get
            {
                return First_Name + " " + Last_Name;
            }
        }
        public clsPersone(int ID, string First_Name, string Last_Name, string Title)
        {
            this.ID = ID;
            this.First_Name= First_Name;
            this.Last_Name = Last_Name;
            this.Title = Title;
        }
    }
  public  class clsEmployee : clsPersone

    {
       
        public clsEmployee(int ID, string First_Name, string Last_Name, string Title, float salary, string Departement) :
            base( ID,  First_Name,  Last_Name,  Title)
        {
            this.salary = salary;
            this.Departement = Departement;
            
        }
        public float salary { get; set; }
        public string Departement { get; set; }

        public void salary_After_increase(float amount)
        {
            salary += amount;
        }
    }

    class Program
    {
        static void Main()
        {

            // You cannot create an object here because class has private constructor
            // Settings Obj1 = new Settings();

            //
            // Read the static properties.
            //
            //  Console.WriteLine(Settings.DayNumber);
            //Console.WriteLine(Settings.DayName);

            //
            // Change the value of the static bool property.
            //
            // Settings.ProjectPath = @"C:\MyProjects\";
            //Console.WriteLine(Settings.ProjectPath);

            clsPersonne personne1 = new clsPersonne();

            Console.WriteLine("ID:{0}", personne1.ID);
            Console.WriteLine("Name:{0}", personne1.Name);
            Console.WriteLine("Age:{0}", personne1.Age);

            /*   clsPersonne personne2 = new clsPersonne(10, "yahia", 22);
               clsPersonne p4 = new clsPersonne();

               Console.WriteLine("find the personne by ID");
               if (clsPersonne.find(11)!=null)
               {
                   Console.WriteLine("ID:{0}", personne2.ID);
                   Console.WriteLine("Name:{0}", personne2.Name);
                   Console.WriteLine("Age:{0}", personne2.Age);
               }
               else
               {
                   Console.WriteLine("this personne not find by this id");
               }
               clsPersonne personne3 = new clsPersonne(4, "yahia", 22);
               if (clsPersonne.find("yahia", "yahia123") != null)
               {
                   Console.WriteLine("ID:{0}", personne3.ID);
                   Console.WriteLine("Name:{0}", personne3.Name);
                   Console.WriteLine("Age:{0}", personne3.Age);
               }
               else
               {
                   Console.WriteLine("find the personne by the userName and this password");
               }

                   Console.ReadKey();*/
            clsEmployee employe1 = new clsEmployee(1,"Mecheddou","Nassim","Full Stack Devloper",5000,"IT");
            
            Console.WriteLine("ID={0}", employe1.ID);
            Console.WriteLine("Full Name={0}", employe1.FullName);
            Console.WriteLine("Title={0}", employe1.Title);
            Console.WriteLine("Department:{0}", employe1.Departement);
            Console.WriteLine("Salary:{0}",employe1.salary);
            Console.WriteLine("salary after increase");
            employe1.salary_After_increase(200);
            Console.WriteLine("Salary:{0}", employe1.salary);



        }
    }
}