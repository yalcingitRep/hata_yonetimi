using System;
namespace hata_yonetimi{
    class Program{
        public static void Main(string[] args){
            try{
                int a = int.Parse("-2000000000");
            }
            catch(ArgumentNullException ex){
                Console.WriteLine("Boş deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Cok kucuk veya buyuk deger girdiniz");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("islem basarili");
            }
        }
    }
}