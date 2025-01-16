using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFourProject.Absract
{
    internal abstract class BaseMachine
    {
        public DateTime UretimTarihi { get; set; }
        
        public string SeriNumarası { get; set; }
        
        public string Ad {  get; set; }
       
        public string Aciklama { get; set; }
       
        public string IsletimSistemi { get; set; }


        protected BaseMachine()
        {
            UretimTarihi = DateTime.Now;

        }

        public virtual void BilgileriYazdir() 
        
        {
            Console.WriteLine($"Üretim Tarihi : {UretimTarihi}\nSeri Numarası : {SeriNumarası}\nAdı : {Ad}\nAçıklama {Aciklama}\nİşletim Sistemi : {IsletimSistemi}");
        
        }

        public abstract void UrunAdiGetir();



    }
}
