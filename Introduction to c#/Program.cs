using Introduction_to_c_;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        Customer[] customer = new Customer[3];

        customer[0] = new Customer
        {
            Name = "Unknown",
            gender = Gender.Unknown
        };

        customer[1] = new Customer
        {
            Name = "Isaac",
            gender = Gender.Male
        };

        customer[2] = new Customer
        {
            Name = "Ife",
            gender = Gender.Female
        };


      foreach (Customer customers in customer) 
        {
            Console.WriteLine("Name = {0} && Gender = {1}" , customers.Name ,GetGender(customers.gender));
        }
    }   

    public static string GetGender(Gender gender)
    {
        //switch(gender)
        //{
        //    case Gender.Unknown:
        //        return "unknown";
        //    case Gender.Male:
        //        return "Male";
        //    case Gender.Female:
        //        return "Female";
        //    default:
        //        return "Invalid number, Try again";
        //}

        if (gender == Gender.Unknown)
        {
            return "unknown";
        }
        else if (gender == Gender.Male)
        {
            return "male";
        }
        else if(gender == Gender.Female)
        {
            return "Female";
        }
        else
        {
            return "invalid input";
        }
    }
 }

class Customer
{ 

    public string? Name { get; set; }
    public Gender gender { get; set; }
}

public enum Gender
{ 
    Unknown,
    Male,
    Female

}