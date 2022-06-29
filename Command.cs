using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTask02
{
    class CommandPattern
    {
        delegate void Invoker();
        delegate void InvokerSet(string s);

        static Invoker Execute, Print, Redo, Undo;
        static InvokerSet Add;

        class Command
        {
            public Command(Receiver receiver)
            {
                Add = receiver.SetData;
                Execute = receiver.DoIt;
                Print = receiver.Print;
                Redo = receiver.DoIt;
                Undo = receiver.Reverse;
            }
        }

        public class Receiver
        {
            string current, old;
            string ayhaga;
            public void SetData(string s)
            {
                this.ayhaga = s;
            }
            public void DoIt()
            {
                old = current;
                current += ayhaga;
            }
            public void Reverse()
            {
                current = old;
            }
            public void Print()
            {
                Console.WriteLine(current);
            }
        }
      
        public class Client
        {
            public void Instantiate()
            {
                new Command(new Receiver());
            }
            public void ClientMain()
            {
                mainMenu menu = new mainMenu();
                Console.Write("Enter the number or letter beside the choice you wish to make: ");
                string s = Console.ReadLine().ToLower();




                switch (s)
                {
                    case "1":
                        {
                            Add("Hello ");
                            Execute();
                            Console.Clear();
                            menu.ShowMenu();
                            break;
                        }

                    case "2":
                        {
                            Add("Welcome ");
                            Execute();
                            Console.Clear();
                            menu.ShowMenu();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine();
                            Print();
                            Console.WriteLine();
                            break;
                        }
                    case "e":
                        {
                            Environment.Exit(0);
                            break;

                        }
                    case "u":
                        {
                            Undo();
                            Console.Clear();
                            menu.ShowMenu();
                            break;
                        }
                    case "r":
                        {

                            Redo();
                            Console.Clear();
                            menu.ShowMenu();
                            break;
                        }
                }
            }
        }
    }

    class mainMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1. Hello");
            Console.WriteLine("2. Welcome");
            Console.WriteLine("3. print");
            Console.WriteLine("E. Exit");
            Console.WriteLine("U. Undo");
            Console.WriteLine("R. Redo");
        }
    }

 
}
