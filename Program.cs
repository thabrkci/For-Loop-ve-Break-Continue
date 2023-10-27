internal class Program
{
    private static void Main(string[] args)
    {
    //  //Belli bir kod bloğunun belli şartlar altında birden fazla çalışmasına for loop kullanılır.
    //  //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
    //  Console.Write("Lütfen bir sayı giriniz");//Örneğin 20 sayısı girilince 20'ye kadar olan tek sayıları yazar.
    //  int sayac = int.Parse(Console.ReadLine());
    //  for (int i = 1; i <= sayac; i++)
    //  {
    //      if (i % 2 == 1)
    //          Console.WriteLine(i);
    //  }

      //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamını yazdır.
      int tektoplam = 0;
      int çifttoplam = 0;
      for (int i = 0; i <= 1500; i++)
      {
          if(i%2 == 1)
          tektoplam += i; //tektoplam = tektoplam+ i;
          else
          çifttoplam += i;//tektoplam = tektoplam+ i;
          
      }
      Console.WriteLine("Tek Toplam" + tektoplam);
      Console.WriteLine("Çift Toplam" + çifttoplam);

    for (int i = 1; i < 10; i++)
    {
        if(i==4)
        break;//Break durdurmak için kullanılır örneğin 1 den başlayıp 4 e eşit olana kadar devam eder ve 4 e gelince durur
        Console.WriteLine(i);
    }

    for (int i = 5; i < 30; i++)   
    {
    if(i==15)
    break;
    Console.WriteLine(i);    
    }

    for (int i = 1; i < 10; i++)
    {
        if(i==4)
        continue;//ise 1 ila 10 sayısı arasındaki bütün sayıları yazdıracaktır.
        Console.WriteLine(i);
    }
    }
}