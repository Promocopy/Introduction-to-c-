using Introduction_to_c_;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{

    //public static void reference(ref int j)
    //{
    //    j = 101;
    //}

    public class Student
    {
        //int _id;  //non negation result to be answerd
        //string _name;  // shouldn't allowe empty name to a student, or no name be returned
        //int _passMark = 35;

        //public string Name
        //{
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new Exception("name can not be empty");
        //        }
        //        this._name = value;
        //    }
        //    get
        //    {
        //        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        //    }


        //}

        //    interface Ia 
        //    {
        //        void APrint();
        //    }

        //    public class A : Ia
        //    {
        //        public void APrint()
        //        {
        //            Console.WriteLine("A"); ;
        //        }
        //    }

        //    interface Ib
        //    {
        //        void BPrint();
        //    }

        //    public class B : Ib
        //    {
        //        public void BPrint()
        //        {
        //            Console.WriteLine("B"); ;
        //        }
        //    }

        //    public class AB : A, Ia , Ib
        //    {
        //        A a = new A();
        //        B b = new B();
        //     public void APrint()
        //    {
        //        a.APrint();
        //    }

        //    public void BPrint()
        //    {
        //        b.BPrint();
        //    }

        //}




        //public string GetName()
        //{
        //    //return string.IsNullOrEmpty(this._name) ? "No Name" :this._name;

        //    if (string.IsNullOrEmpty(this._name))
        //    {
        //        return "no name";
        //    }
        //    else
        //    {
        //        return this._name;
        //    }
        //}


        //    public int PassMark
        //    { 
        //        get 
        //        { 
        //            return _passMark; 
        //        }
        //    }



        //    public int ID
        //    {
        //        set
        //        {
        //            if (value <=  0)
        //            {
        //                throw new Exception("ID must be not be negative");
        //            }
        //            this._id = value;

        //        }
        //        get
        //        {
        //            return this._id;
        //        }
        //    }

        //}
        //public delegate void Hellodelegate(int Message);

        //public static void hello(int strMessage)
        //{
        //    Console.WriteLine(strMessage);
        //}

        //public class Employee
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public int Salary { get; set; }
        //    public int experience { get; set; }

        //    public static void PromoteEmployee(List <Employee> employeelist)
        //    {
        //        foreach (Employee employee in employeelist)
        //        {
        //            if (employee.experience >= 5)
        //            {
        //                Console.WriteLine("{0} is promoted", employee.Name);
        //            }
        //        }
        //    }


        //}






        private static void Main(string[] args)
        {












            //StreamReader stream = new StreamReader("C:\\sameple files\\data.txt");
            //Console.WriteLine(stream.ReadToEnd());
            //stream.Close();



            //List<Employee> emplist = new List<Employee>();

            //emplist.Add(new Employee() { Id = 101, Name = "John", Salary = 5000, experience = 5});
            //emplist.Add(new Employee() { Id = 101, Name = "Jane", Salary = 5000, experience = 4 });
            //emplist.Add(new Employee() { Id = 101, Name = "Jose", Salary = 5000, experience = 6 });
            //emplist.Add(new Employee() { Id = 101, Name = "James", Salary = 5000, experience = 3 });

            //Employee.PromoteEmployee(emplist);






            //Hellodelegate del = new Hellodelegate(hello);
            //del(10);


            //    AB ab = new AB();
            //    ab.APrint();
            //    ab.BPrint();

            //    Student student = new Student();
            //    student.ID = 1 ;
            //    student.Name = "game";

            //    Console.WriteLine("student id = {0}" , student.ID);
            //    Console.WriteLine("student name = {0}", student.Name);
            //    Console.WriteLine("passmark = {0}", student.PassMark);











            //Tut k = new Tut();
            //k.EvenNumbers();

            //int i = 0;
            //reference(ref i);
            //Console.WriteLine(i);











            //int[] number = new int[3];
            //number[0] = 1;
            //number[1] = 2;
            //number[2] = 3;

            //int i = 0;

            //while (i<number.Length)
            //{
            //    Console.WriteLine(number[i]); 
            //    i++;
            //}









            //int totalcoffee = 0;
            //string userdecision = string.Empty;

            //do
            //{

            //    int userchoice = 0;

            //    do
            //    {
            //        Console.WriteLine("Please select your choice of coffee  1 - small, 2 - medium, 3 - large.");
            //        userchoice = int.Parse(Console.ReadLine());

            //        switch (userchoice)
            //        {
            //            case 1:
            //                totalcoffee += 1;
            //                break;
            //            case 2:
            //                totalcoffee += 2;
            //                break;
            //            case 3:
            //                totalcoffee += 3;
            //                break;
            //            default:
            //                Console.WriteLine("your choice {0} is invalid, please look at the menu and select again", userchoice);
            //                break;
            //        }
            //    } while (userchoice != 1 && userchoice != 2 && userchoice != 3);



            //    do
            //    {

            //        Console.WriteLine("Do you want to buy again YES or NO");
            //        userdecision = Console.ReadLine();

            //        if (userdecision != "YES" && userdecision != "NO")
            //        {
            //            Console.WriteLine("Invalid choice {0}, Please select YES or NO", userdecision);
            //        }

            //    } while (userdecision != "YES" && userdecision != "NO");
            //} while (userdecision == "YES");

            //Console.WriteLine("Thank you for shopping with us");
            //Console.WriteLine("Bill Amount = {0}", totalcoffee);










            //int totalcoffeecoast = 0;


            //Start:


            //Console.WriteLine("please select your coffee 1 - small , 2 - medium, 3 - large");
            //int number = int.Parse(Console.ReadLine());



            //if (number == 1)
            //{
            //    totalcoffeecoast += 1;
            //}
            //else if (number == 2)
            //{
            //    totalcoffeecoast += 2;
            //}
            //else if (number == 3)
            //{
            //    totalcoffeecoast += 3;
            //}
            //else
            //{
            //    Console.WriteLine("your choice{0} is invalid", number);
            //}


            //Decide:
            //Console.WriteLine("Do you want to buy another coffee Yes or No");
            //string userdecision = Console.ReadLine();

            //switch (userdecision.ToUpper())
            //{
            //    case "YES":
            //        goto Start;
            //    case "NO":
            //        break;
            //    default:
            //        Console.WriteLine("your choice {0} is invalid ", userdecision);
            //        goto Decide;
            //}

            //Console.WriteLine("Thank you for shopping with us.");
            //Console.WriteLine("Your bill amount is {0}", totalcoffeecoast);



            //bool? isyoumajor = null;

            //if (isyoumajor == true)
            //{
            //    Console.WriteLine("User is major");
            //}
            //else if (isyoumajor == false)
            //{
            //    Console.WriteLine("User is not major");
            //}
            //else
            //{
            //    Console.WriteLine("user did not answer");
            //}


            //int[] oddnumbers = {1, 2, 3, 4, 5};
            //oddnumbers[0] = 1;
            //oddnumbers[1] = 2;
            //oddnumbers[2] = 3;
            //oddnumbers[3] = 4;

            //Console.WriteLine(oddnumbers[3]);

            //int[] evennumbers = new int[4] { 1,2,3,4,};
            //evennumbers[0] = 1;
            //evennumbers[1] = 2;
            //evennumbers[2] = 3;
            //evennumbers[3] = 4;
            //int? num = 100;
            //int res = num ?? 0;
            //Console.WriteLine(res);
            //if (num == null)
            //{
            //    res = 0;
            //}
            //else
            //{
            //    res =(int)num;
            //}
            //Console.WriteLine("res is {0}", res);








            //string number = "100";
            //int? _number = null;
            //int result = 0;

            //bool conversion = int.TryParse(number, out result);
            //if (conversion== true)
            //{
            //    Console.WriteLine(result);
            //}
            //else if (conversion == false)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("input a valid number");
            //}





        }
    }
}