using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    using Bank;
    class Client
    {
        [DllImport("msvcrt")]

        static extern int _getch();

        private int NumOfAttempt = 0, attempt = 3;
        private bool start = true;
        private string answer;

        Bank newBank = new Bank();
        
        public void NewDeposit()
        {
            Console.WriteLine("Input your deposit: ");
            newBank.initialSum = int.Parse(Console.ReadLine());
        }

        public void NewMenuOfBankomat()
        {
            Console.Clear();
            Console.WriteLine("Welcome menu of the bankomat");
            Console.WriteLine("Please, input your password");

            do
            {
                Console.WriteLine("You have {0} attempt, after you car will be blocked:", attempt--);
                int verifyPassword = int.Parse(Console.ReadLine());
                if (verifyPassword == newBank.returnNumber())
                {

                    while (start)
                    {
                        Console.Clear();
                        Console.WriteLine("Working menu of Bankomat");
                        Console.WriteLine("1 - show balance of account");
                        Console.WriteLine("2 - add money");
                        Console.WriteLine("3 - take money from account");
                        Console.WriteLine("4 - exit");
                        switch (_getch())
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("Balance of your account:");
                                Console.WriteLine(newBank.initialSum);
                                Console.WriteLine("Do you want to continue?/Y,N");
                                answer = Console.ReadLine();
                                //verifyAnswerOfclient();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye!");
                                    return;
                                }
                                else
                                {
                                    break;
                                }
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine("You are in submenu of adding money");
                                Console.WriteLine("Input sum:");
                                newBank.AddSumOnAccount(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Acoount is replenish");
                                Console.WriteLine("Do you want to continue?/Y,N");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye!");
                                    return;
                                }
                                else
                                {
                                    break;
                                }

                            case '3':
                                Console.Clear();
                                Console.WriteLine("You are in submenu of taking money");
                                Console.WriteLine("Input sum");
                                int takingSum = int.Parse(Console.ReadLine());
                                //int temp = newBank.WithdrawCash(takingSum);
                                if (takingSum >= newBank.initialSum)
                                {
                                    Console.WriteLine("Not enough money on account, press any key");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    newBank.WithdrawCash(takingSum);
                                    Console.WriteLine("Sum: {0} taking from account", takingSum);
                                    Console.WriteLine("Account is replenish, press any key");
                                    Console.ReadKey();
                                    break;
                                }

                            case '4':
                                Console.WriteLine("Are you shure???N/Y");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                    break;
                                else start = false;
                                return;

                        }
                    }



                }
                if (verifyPassword != newBank.returnNumber())
                {
                    Console.WriteLine("You inter wrong password, try again:");
                    NumOfAttempt++;
                }
                Console.Clear();
            } while (NumOfAttempt < 3);
            Console.WriteLine("It was last try, BYE!");

        }
        //public string verifyAnswerOfclient()
        //{
        //    if (answer == "N" || answer == "n")
        //    {
        //        Console.WriteLine("Bye!");
        //        return answer;
        //    }
        //    //return;
        //
        //}
    }
}


            