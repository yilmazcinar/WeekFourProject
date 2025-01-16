using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekFourProject.Absract;

namespace WeekFourProject.Concrete
{
    internal class Phone : BaseMachine
    {
       
        public string Lisans { get; set; }

     

    public override void UrunAdiGetir()
        {
            Console.WriteLine($"Ürün {Ad}");
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Lisans Durumu : {Lisans}");
        }
    }
}