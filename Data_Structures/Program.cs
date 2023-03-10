using System;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stacks stack= new Stacks();
           
           Queue queue= new Queue();

            Random random = new Random();
           
            int iNo,iCnt = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("\tWEL-COME TO DATA STRUCTURE STACKS");
                Console.WriteLine("*************************************************");
                Console.WriteLine("\t----------OPTIONS----------\n");
                Console.WriteLine("1  : Push stack");
                Console.WriteLine("2  : Display Stack");
                Console.WriteLine("3  : Pop Stack");
                Console.WriteLine("4  : Peek of Stack");
                Console.WriteLine("5  : Is-Empty Stack");
                Console.WriteLine("6  : Size of Stack");
                Console.WriteLine("7  : Enqueue in Queue");
                Console.WriteLine("8  : Display Queue");
                Console.WriteLine("0  : Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("********************************************");
                switch (option)
                {
                    case 1:
                       
                        Console.WriteLine("----------{ ADD NODE }----------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            iNo = random.Next(9, 99);
                            Console.Write("\nEnter {0} Element : ", i + 1);
                            stack.push(iNo);
                        }
                        Console.WriteLine("\n--------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();  
                        break;

                    case 2:
                        Console.WriteLine("----------{ DISPLAY NODE }----------\n");
                        
                        stack.display();
                        
                        Console.WriteLine("\n-----------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 3 :
                        Console.WriteLine("----------{ REMOVE NODE }----------\n");

                        stack.pop();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;


                    case 4:
                        Console.WriteLine("----------{ PEEK }----------\n");

                        stack.peek();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("----------{ IS-EMPTY }----------\n");

                        stack.isEmpty();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 6:

                        Console.WriteLine("----------{ SIZE OF STACK }----------\n");

                        stack.size();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 7:

                        Console.WriteLine("----------{ ENQUEUE }----------\n");

                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            iNo = random.Next(9, 99);
                            Console.Write("\nEnter {0} Element : ", i + 1);
                            queue.enqueue(iNo);
                        }
                        Console.WriteLine("\n--------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.WriteLine("----------{ DISPLAY QUEUE }----------\n");

                        queue.display();

                        Console.WriteLine("\n-----------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.WriteLine("----------{ DEQUEUE }----------\n");

                        queue.dequeue();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 10:
                        Console.WriteLine("----------{ IS-EMPTY QUEUE }----------\n");

                        queue.isEmpty();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 11:

                        Console.WriteLine("----------{ SIZE OF QUEUE }----------\n");

                        queue.size();

                        Console.WriteLine("\n-----------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 0:
                        flag= false;
                        break;

                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
           



        }
    }
}