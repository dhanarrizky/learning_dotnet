using System;

namespace DataBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your application logic goes here
            // foreach(var a in users){
            //     Console.WriteLine(a);
            // }
            Users user = new Users();
            user.GetAll();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
