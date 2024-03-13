using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string bloodType;
            int age;
            string countryOfResident;


            Console.WriteLine("Hey user!please enter your name here ");
            name= Console.ReadLine();

            Console.WriteLine("you have enter your name as : "  + name);



            Console.WriteLine("Hey user ! please enter your blood type here");
            bloodType = Console.ReadLine();

            Console.WriteLine("you have enter your blood type as : "+ bloodType );


            Console.WriteLine("Hey user ! please enter your age here");

            age = Convert.ToInt32(Console.ReadLine()); 


            Console.WriteLine("you have enter your age as :" + age );


            Console.WriteLine("Hey user ! please enter your contry of resident here");

            countryOfResident = Console.ReadLine();

            Console.WriteLine("you have enter your country of resident as  : "+  countryOfResident );









            Console.WriteLine("")



            
                
                
                ;






        }



    }




}













