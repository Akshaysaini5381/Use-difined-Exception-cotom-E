using System;

namespace Use_difined_Exception_cotom_E
{
    class CheckSallaryException : Exception
    {
        /*  public override string ToString()
          {
              return "Sallary must be positive";
          }*/
        /* public CheckSallaryException(string msg) : base(msg)
         {
             // Console.WriteLine(msg);
         }*/
        // use difine E
        public CheckSallaryException(string msg) 
        {
             Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number :");
            int empNo = int.Parse(Console.ReadLine());
            Console.Write("Enter the Name :");
            string  empName = Console.ReadLine();

            try
            {
                Console.Write("Enter the number :");
                int empsallary = int.Parse(Console.ReadLine());
                    Console.WriteLine("No is :"+empNo);
                    Console.WriteLine("Name is :" + empName);
                if (empsallary>0 )
                {
                    Console.WriteLine("Sallary is :" + empsallary);
                }
                else
                {
                    throw new CheckSallaryException("Sallary must be positive :");
                }
            }
            catch (CheckSallaryException e)
            {
               Console.WriteLine(e.Message);
            }
        }
    }
}
