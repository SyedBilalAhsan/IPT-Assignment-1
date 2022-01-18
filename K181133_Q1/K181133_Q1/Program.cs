using System;
using System.IO;
using System.Configuration;


namespace K181133_Q1
{
    class Program 
    {
       
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                if (args.Length > 0)
                {               
                    if (args.Length == 3)
                    {
                        person.userName = args[0];
                        person.password = args[1];
                        person.StationId = args[2];
                        if (Convert.ToString(person.StationId) == "210001" || Convert.ToString(person.StationId) == "210002")
                        {
                            person.WriteinFile(Convert.ToString(person.userName), Convert.ToString(person.password), Convert.ToString(person.StationId));
                        }
                        else
                        {
                            Console.WriteLine("Station Id can only be '210001' for Main Campus and '210002' for City Campus ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Argument length: " + args.Length);
                        Console.WriteLine("Please Provide all 3 arguments.");
                    }
                }
                else
                {
                    Console.WriteLine("No command line arguments found.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            
        }
    }
}
