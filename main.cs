using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
            int counter = 0;
            
            List<int> age = new List<int>();
            List<string> name = new List<string>();
            List<string> surname = new List<string>();
            List<double> salary = new List<double>();
            List<string> position = new List<string> ();

            

            while (true) {
                int length = age.Count;
                Console.WriteLine($"Choose acion");
                Console.WriteLine($"1 - add employee" + '\n' + "2 - output employee list" + '\n' + 
                    "3 - find employee" + '\n'+ "4 - remove employee" + '\n'+ "5 - edit employee");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine($"input age");
                        age.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"input name");
                        name.Add(Console.ReadLine());
                        Console.WriteLine($"input surname");
                        surname.Add(Console.ReadLine());
                        Console.WriteLine($"input pasition");
                        position.Add(Console.ReadLine());
                        Console.WriteLine($"input salary");
                        salary.Add(Convert.ToDouble(Console.ReadLine()));
                    break;

                    case 2:
                        
                        for (int i = 0; i<length; i++)
                        {
                            
                            Console.WriteLine($"Age-"+age[i]);
                            Console.WriteLine($"Name-" + name[i]);
                            Console.WriteLine($"Surname-" + surname[i][i]);
                            Console.WriteLine($"Position-"+position[i]);
                            Console.WriteLine($"Salary-"+salary[i]);
                        }
                        break;

                    case 3:
                        string temp = Console.ReadLine();

                        for(int i = 0; i < length; i++)
                        {
                            if(temp == name[i] || temp == surname[i]||temp == position[i])
                            {
                                Console.WriteLine(name[i]);
                                Console.WriteLine(surname[i]);
                                Console.WriteLine(position[i]);
                                break;      
                            } else
                            {
                                Console.WriteLine($"is not at this list");
                            }
                            
                        }

                        break;

                    case 4:
                        string temp1 = Console.ReadLine();

                        for (int i = 0; i < length; i++)
                        {
                            if (temp1 == name[i] || temp1 == surname[i] || temp1 == position[i])
                            {
                                age.RemoveAt(i);
                                name.RemoveAt(i);
                                position.RemoveAt(i);
                                salary.RemoveAt(i);
                            }
                            else
                            {
                                Console.WriteLine($"is not at this list");
                            }

                        }
                        break;

                    case 5:
                        string temp2 = Console.ReadLine();

                        for (int i = 0; i < length; i++)
                        {
                            if (temp2 == name[i] || temp2 == surname[i] || temp2 == position[i])
                            {
                                Console.WriteLine($"choose option" + '\n' + "1 - change name" + '\n' + 
                                     "2 - change surname"+ '\n' + "3 - change salary" + '\n' + "4 - change position");
                                int option = Convert.ToInt32 (Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        name[i] = Console.ReadLine();
                                        break;
                                        case 2:
                                        surname[i] = Console.ReadLine();
                                        break;
                                    case 3:
                                        salary[i] = Convert.ToDouble (Console.ReadLine());
                                        break;
                                            case 4:
                                        position[i] = Console.ReadLine();
                                            break;
                                    default:
                                        Console.WriteLine($"is not at this list");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"is not at this list");
                            }

                        }
                        break;
                        
                    default:
                        Console.WriteLine($"is not at this list");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
                
                counter++;

            }

        }
    }
}
