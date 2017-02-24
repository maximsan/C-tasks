using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Laba_4
{
    abstract class Storage
    {
        [DllImport("msvcrt")]

        static extern int _getch();

        public string NameOfModel { get; set; }
        public string NameOfStorage { get; set; }

        public Storage(string NameOfModel, string NameOfStorage)
        {
            this.NameOfModel = NameOfModel;
            this.NameOfStorage = NameOfStorage;
        }
        public abstract double GetVolumeOfMemory();

        public abstract double CopyOfTheFiles();

        public abstract bool GetInfoOfFreeMemoryOnDevice();

        public abstract void GetAllInformationAboutDevice();

        static void Main(string[] args)
        {
            /*В меню постоянно показывается информаиця в пунктах 2, 3 только если с них начинать проверять работу прогрыммы*/

            bool start = true;
            string answer;

            Storage [] ArrayOfStorage = new Storage[3];
            ArrayOfStorage[0] = new Flash(0.6, 64.0, "Floppy", "Flash");        /* flash race - 0,6 gb/s */
            ArrayOfStorage[1] = new DVD(0.03, 2, "Smart", "DVD");               /* DVD race - 0,03 gb/s */
            ArrayOfStorage[2] = new HDD(0.06, 120, 2, "Swift", "HDD");          /* HDD race - 0,06 gb/s */
            try
            {
                while (start)
                {
                    Console.Clear();
                    Console.WriteLine("Menu of the application");
                    Console.WriteLine("1 - Calculation of the full memory of the all devices");
                    Console.WriteLine("2 - Calculation of the time for copying");
                    Console.WriteLine("3 - Calculation of the needed devices for transportation of the information");
                    Console.WriteLine("0 - Exit from the app");
                    switch (_getch())
                    {

                        case '1':
                            Console.Clear();
                            ArrayOfStorage[0].GetAllInformationAboutDevice();
                            Console.WriteLine();
                            Console.WriteLine("Calculation of the full memory of the flashes: {0:N}",
                                ArrayOfStorage[0].GetVolumeOfMemory());
                            Console.WriteLine();

                            ArrayOfStorage[1].GetAllInformationAboutDevice();
                            Console.WriteLine();
                            Console.WriteLine("Calculation of the full memory of the DVD: {0:N}",
                                ArrayOfStorage[1].GetVolumeOfMemory());
                            Console.WriteLine();

                            ArrayOfStorage[2].GetAllInformationAboutDevice();
                            Console.WriteLine();
                            Console.WriteLine("Calculation of the full memory of the HDD: {0:N}",
                                ArrayOfStorage[2].GetVolumeOfMemory());

                            Console.WriteLine("Do you want to continue?/Y,N");
                            answer = Console.ReadLine();
                            if (answer == "N" || answer == "n")
                            {
                                Console.WriteLine("Bye!");
                                return;
                            }
                            break;


                        case '2':
                            Console.Clear();
                            Console.WriteLine("Calculation of the time for copying");

                            Console.WriteLine("For coopying of information by Flash will be need: {0:N} sec",
                                ArrayOfStorage[0].CopyOfTheFiles());
                            Console.WriteLine();

                            Console.WriteLine("For coopying of information by DVD will be need: {0:N} sec",
                                ArrayOfStorage[1].CopyOfTheFiles());
                            Console.WriteLine();

                            Console.WriteLine("For coopying of information by HDD will be need: {0:N} sec",
                                ArrayOfStorage[2].CopyOfTheFiles());

                            Console.WriteLine("Do you want to continue?/Y,N");
                            answer = Console.ReadLine();
                            if (answer == "N" || answer == "n")
                            {
                                Console.WriteLine("Bye!");
                                return;
                            }
                            break;

                        case '3':
                            Console.Clear();
                            Console.WriteLine("For coopying of your information needed:");

                            ArrayOfStorage[0].CopyOfTheFiles();
                            ArrayOfStorage[1].CopyOfTheFiles();
                            ArrayOfStorage[2].CopyOfTheFiles();

                            Console.WriteLine("Do you want to continue?/Y,N");
                            answer = Console.ReadLine();
                            if (answer == "N" || answer == "n")
                            {
                                Console.WriteLine("Bye!");
                                return;
                            }
                            break;
                        case '0':

                            Console.WriteLine("Do you want to continue?/Y,N");
                            answer = Console.ReadLine();
                            if (answer == "N" || answer == "n")
                            {
                                Console.WriteLine("Bye!");
                                return;
                            }
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}",e.Message);
            }

        }




    }
}

