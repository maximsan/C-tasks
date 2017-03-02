using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    sealed class DVD : Storage
    {
        /*- класс DVD - диск: скорость чтения / записи, тип (односторонний (4,7 Гб) /двусторонний (9,4 Гб));*/
        public double RaceOfReading { get; set; }
        public int TypeOfDVD { get; set; }

        private double VolumeOfDVD;

        private double SizeOfCopyingInfo = 565;

        private int AmountOfDVD = 0;

        private int newAmountOfDVD = 0;

        private const double SizeOfOneFile = 0.78;

        static int count = 0;

        private double temp = 565;

        public DVD(double RaceOfReading, int TypeOfDVD, string NameOfModel, string NameOfStorage)
            : base(NameOfModel, NameOfStorage)
        {
            
            this.RaceOfReading = RaceOfReading;
            this.TypeOfDVD = TypeOfDVD;
            if (TypeOfDVD == 1)
                VolumeOfDVD = 4.7;
            else VolumeOfDVD = 9.4;
        }

        public override double GetVolumeOfMemory()
        {

            return VolumeOfDVD * CountOfDVD(); 
        }

        public override double CopyOfTheFiles()
        {

            double RestOfMem = 0;
            
            /*счиатем количество носителей необходиоме для копирования инфы*/

            while (SizeOfCopyingInfo > 0)
            {
                while (SizeOfCopyingInfo >= VolumeOfDVD)
                {
                    SizeOfCopyingInfo -= Math.Round(VolumeOfDVD / SizeOfOneFile) * SizeOfOneFile;
                    newAmountOfDVD++;
                }
                if (SizeOfCopyingInfo > 0 && SizeOfCopyingInfo < VolumeOfDVD)
                {

                    RestOfMem = SizeOfCopyingInfo;
                    count = newAmountOfDVD + 1;
                    break;
                }
            }
            Console.WriteLine("Quantity of DVD:{0}", count);

            /*время записи с учетом что память на каждом устройстве не целиком ипользуется из-за размера файла*/
            double time = (newAmountOfDVD * (Math.Round(VolumeOfDVD / SizeOfOneFile) * SizeOfOneFile) + RestOfMem) / RaceOfReading;

            return time;
        }

        public override bool GetInfoOfFreeMemoryOnDevice()
        {
            throw new NotImplementedException();
        }

        public override void GetAllInformationAboutDevice()
        {
            Console.WriteLine("Name of storage: {0},\nname of model: {1},\nrace of reading/writing: {2},\nvolume of memory for record: {3}", NameOfStorage,
    NameOfModel, RaceOfReading, TypeOfDVD);
        }

        //public override double TimeOfCoopying()
        //{
        //    double TimeOfCoopying = TypeOfDVD / RaceOfReading;
        //    return TimeOfCoopying;
        //}

        private int CountOfDVD()
        {
           while (temp> 0)
            {
                temp -= Math.Round(VolumeOfDVD / SizeOfOneFile) * SizeOfOneFile;
                AmountOfDVD++;
            }
            return AmountOfDVD;
        }

    }
    
}
