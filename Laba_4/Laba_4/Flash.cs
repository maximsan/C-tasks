using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    sealed class Flash:Storage
    {
        /*- класс Flash-память: скорость USB 3.0, объем памяти;*/
        public double RaceOfUSB_3_0 { get; set; }
        public double VolumeOfMemory { get; set; }

        private const double SizeOfOneFile = 0.78;

        private double SizeOfCopyingInfo = 565;

        private int AmountOfFlash = 0;

        /*добавил отдельную переменную, чтобы после входа заново в пункт меню с количеством девайсов их количество не изменялось*/
        private int newAmountOfFlash = 0;


        static int count = 0;

        /*добавил, чтобы в методе подсчета количества девайсо, 
         *также при новом входе в этот пункт меню не наращивалось изначальное значение памяти*/
        private double temp = 565;

        public Flash(double RaceOfUSB_3_0, double VolumeOfMemory, string NameOfModel, string NameOfStorage)
            : base(NameOfModel, NameOfStorage)
        {
            this.RaceOfUSB_3_0 = RaceOfUSB_3_0;
            this.VolumeOfMemory = VolumeOfMemory;
        }

        public override double GetVolumeOfMemory()
        {

            return VolumeOfMemory*CountOfFlash(); 
        }

        public override double CopyOfTheFiles()
        {
 
            double RestOfMem = 0;
 
            /*считаем количество носителей необходиоме для копирования инфы*/

            while (SizeOfCopyingInfo > 0)
            {
                while (SizeOfCopyingInfo >= VolumeOfMemory)
                {
                    SizeOfCopyingInfo -= Math.Round(VolumeOfMemory / SizeOfOneFile) * SizeOfOneFile;
                    newAmountOfFlash++;
                }
                if (SizeOfCopyingInfo > 0 && SizeOfCopyingInfo < VolumeOfMemory)
                {
                    RestOfMem = SizeOfCopyingInfo;
                    count = newAmountOfFlash + 1;
                    break;
                }
            }
            Console.WriteLine("Quantity of flashes:{0}", count);

            /*время записи с учетом что память на каждом устройстве не целиком ипользуется из-за размера файла*/
            double time = (newAmountOfFlash * (Math.Round(VolumeOfMemory / SizeOfOneFile) * SizeOfOneFile) + RestOfMem) / RaceOfUSB_3_0;
            
            return time;
        }

        public override bool GetInfoOfFreeMemoryOnDevice()
        {
            if (VolumeOfMemory > SizeOfOneFile)
                return true;
            return false;
        }


        public override void GetAllInformationAboutDevice()
        {
            Console.WriteLine("name of storage: {0}\nname of model: {1}\nrace of USB_3.0: {2}\nvolume of memory for record: {3}", NameOfStorage, 
                NameOfModel, RaceOfUSB_3_0, VolumeOfMemory);
        }

        //public override double TimeOfCoopying()
        //{
        //    double TimeOfCoopying = VolumeOfMemory / RaceOfUSB_3_0;
        //    return TimeOfCoopying;
        //}


        private int CountOfFlash()
        {
            while (temp > 0)
            {
                temp -= Math.Round(VolumeOfMemory / SizeOfOneFile) * SizeOfOneFile;
                    AmountOfFlash++;
            }
            return AmountOfFlash;
        }

    }
}
