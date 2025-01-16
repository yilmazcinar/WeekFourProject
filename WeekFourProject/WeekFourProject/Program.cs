using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using WeekFourProject.Absract;
using WeekFourProject.Concrete;

Uretim:
Console.WriteLine("Bilgisayar üretmek için 1 , Telefon üretmek için 2 ' ye basınız.\n ");

int cevap = Convert.ToInt32(Console.ReadLine());


while (cevap != 1 && cevap != 2)
{
    Console.WriteLine("\nGeçersiz Giriş yaptınız. Lütfen 1 veya 2 yi tuşlayınız.\n ");
    cevap = Convert.ToInt32(Console.ReadLine());

}

BaseMachine product;

if (cevap == 1)
{
    product = new Computer();
    Console.WriteLine("Seri Numarası Giriniz\n");
    product.SeriNumarası = Console.ReadLine();
    Console.WriteLine("\nAdını giriniz\n ");
    product.Ad = Console.ReadLine();
    Console.WriteLine("\nAçıklama Giriniz\n");
    product.Aciklama = Console.ReadLine();
    Console.WriteLine("\nİşletim Sistemi giriniz\n");
    product.IsletimSistemi = Console.ReadLine();
    Console.WriteLine("\nBluetooth durumunu giriniz var? yok?\n");
    ((Computer) product).BlueTooth = Console.ReadLine();
    Console.WriteLine($"\nUsb Giriş Sayısı giriniz\n");
    ((Computer) product).Usb = int.Parse (Console.ReadLine());

   



}
else
{
    product = new Phone();
    Console.WriteLine("\nSeri Numarası Giriniz\n");
   product.SeriNumarası = Console.ReadLine();
    Console.WriteLine("\nAdını giriniz\n");
    product.Ad = Console.ReadLine();
    Console.WriteLine("\nAçıklama Giriniz\n");
    product.Aciklama = Console.ReadLine();
    Console.WriteLine("\nİşletim Sistemi giriniz\n");
    product.IsletimSistemi = Console.ReadLine();
    Console.WriteLine("\nLisans durumunu giriniz. Var ? Yok ?\n");
    ((Phone)product).Lisans = Console.ReadLine();

}

product.BilgileriYazdir();
product.UrunAdiGetir();

Console.WriteLine("\nBaşka bir ürün üretmek ister misiniz? Evet = e , Hayır = h ?\n");

string reCreate = Console.ReadLine().ToLower();

if (reCreate != "e")
{
    Console.WriteLine("\nGüle güle\n");
    
}
else
{
    goto Uretim;

}


