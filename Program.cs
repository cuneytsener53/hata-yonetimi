using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            try
            {

                Console.WriteLine("Bir Sayı Giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı :" + sayi);

            }
            catch(Exception ex)

            {

                Console.WriteLine("Hata:" + ex.Message.ToString());
            }

            finally

            {

                Console.Write("İşlem Tamamlandı.");
            }

            try

            {
                //int a = int.Parse(null);
                //int a = int.Parse("Test");
                int a = int.Parse("-200000000000");

            }

            catch (ArgumentNullException ex)

            {
                Console.WriteLine("Boş değer Girdiniz");
                Console.WriteLine(ex);
            }
            
            catch (FormatException ex)

            {

                Console.WriteLine("Veri Tipi Uygun Değil Hatası");
                Console.WriteLine(ex);
            }

            catch (OverflowException ex)

            {

                Console.WriteLine("Çok küçük yada çok büyük değer giriniz");
                Console.WriteLine(ex);
            }

            finally{
                Console.WriteLine("İşlem Başarıyla Tamamlandı");
            }

            
        }
    }
}