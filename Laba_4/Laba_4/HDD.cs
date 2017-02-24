using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    sealed class HDD : Storage
    {
        /*- класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов.*/
        public double RaceOfUSB_2_0 { get; set; }
        public double VolumeOfSections { get; set; }
        public int AmountOfSections { get; set; }

        private const double SizeOfOneFile = 0.78;

        private double SizeOfCopyingInfo = 565;

        private double temp = 565;

        private int AmountOfHDD = 0;

        private int newAmountOfHDD = 0;

        static int count = 0;

        public HDD(double raceOfUsb, double volumeOfSections, int amountOfSections, string NameOfModel, string NameOfStorage)
            : base(NameOfModel, NameOfStorage)
        {
            this.RaceOfUSB_2_0 = raceOfUsb;
            this.VolumeOfSections = volumeOfSections;
            this.AmountOfSections = amountOfSections;
        }

        public override double GetVolumeOfMemory()
        {
            return VolumeOfSections*CountOfHDD();
        }

        public override double CopyOfTheFiles()
        {
            double RestOfMem = 0;
            
            /*счиатем количество носителей необходиоме для копирования инфы*/
            while (SizeOfCopyingInfo > 0)
            {
                while (SizeOfCopyingInfo >= VolumeOfSections)
                {
                    SizeOfCopyingInfo -= Math.Round(VolumeOfSections / SizeOfOneFile) * SizeOfOneFile;
                    newAmountOfHDD++;
                }
                if (SizeOfCopyingInfo > 0 && SizeOfCopyingInfo < VolumeOfSections)
                {
                    RestOfMem = SizeOfCopyingInfo;
                    count = newAmountOfHDD + 1;
                    break;
                }
            }

            Console.WriteLine("Quantity of HDD:{0}", count);

            /*время записи с учетом что память на каждом устройстве не целиком ипользуется из-за размера файла*/
            double time = (newAmountOfHDD * (Math.Round(VolumeOfSections / SizeOfOneFile) * SizeOfOneFile) + RestOfMem) / RaceOfUSB_2_0;

            return time;
        }

        public override bool GetInfoOfFreeMemoryOnDevice()
        {
            throw new NotImplementedException();
        }

        //public override double TimeOfCoopying()
        //{
        //    double TimeOfCoopying = VolumeOfSections / RaceOfUSB_2_0;
        //    return TimeOfCoopying;
        //}

        public override void GetAllInformationAboutDevice()
        {
            Console.WriteLine("Name of storage: {0},\nname of model: {1},\nrace of USB_2.0: {2},\nvolume of memory for record: {3}", NameOfStorage,
                NameOfModel, RaceOfUSB_2_0, VolumeOfSections);
        }

        private int CountOfHDD()
        {
            while (temp > 0)
            {
                temp -= Math.Round(VolumeOfSections / SizeOfOneFile) * SizeOfOneFile;
                AmountOfHDD++;
            }
            return AmountOfHDD;
        }
    }

}
