using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WeekFourProject.Absract;

namespace WeekFourProject.Concrete
{
    internal class Computer : BaseMachine
    {
        int _usb;
        public int Usb
        {
            get
            {
                return _usb;
            }
            set
            {
                if (value != 2 && value != 4)
                {
                    Console.WriteLine("Usb Giriş Sayısı 2 veya 4 olmalıdır. ");
                    _usb = -1;

                }
                else
                {
                    _usb = value;
                }


            }
        }

        public string BlueTooth { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Usb Sayısı : {Usb} ");
            Console.WriteLine($"Bluethoot : {BlueTooth}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Ürün adı : {Ad}");
        }

    }
}
