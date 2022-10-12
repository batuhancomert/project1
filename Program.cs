using System;

namespace project1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Pozitif Bir sayı giriniz: ");
            string num = Console.ReadLine();

            if (isItPozitive(num))
            {
                int number = int.Parse(num);
                int[] numbers = new int[number];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write((i+1) + ". Sayıyı giriniz: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] % 2 == 0)
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
             
            }
        
            Console.ReadKey(); 

            // 2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("1.Pozitif Sayı Giriniz: ");
            string n = (Console.ReadLine());

            Console.Write("2.Pozitif Sayı Giriniz: ");
            string m = (Console.ReadLine());

            if (isItPozitive(n) && isItPozitive(m))
            {
                int number1 = int.Parse(n);
                int number2 = int.Parse(m);
                int[] numbers = new int [number1];

                for (int i = 0; i < number1; i++)
                {
                    Console.WriteLine((i+1)+". Pozitif Sayı Giriniz");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                }
                foreach (var number in numbers)
                {
                    if (number == number1 || number % number2 == 0)
                    {
                        Console.WriteLine(number);
                    }
                }
        
            }      
            Console.ReadKey();


             // 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
            Console.Write("Pozitif Bir sayı giriniz: ");
            string num2 = Console.ReadLine();
           
            if (isItPozitive(n))
            {
                int number = Convert.ToInt32(num2);
                string[] word = new string[number];

                Console.WriteLine(n + " ADET KELİME GİRİNİZ");
                for (int i = 0; i < word.Length; i++)
                {
                    Console.WriteLine((i+1)+". kelime giriniz");
                    word[i] = Console.ReadLine();   
                }

                Array.Reverse(word);

                foreach (var item in word)
                {
                    Console.Write(" " + item);
                }
            }
            Console.ReadKey();

            
            // 4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Cümle Yazınız: ");
            string sentence= Console.ReadLine();
            string[] sentences= sentence.Split(' ');

            //Cümledeki Kelime Sayısı:
            string topWord = "Cümledeki Toplam Kelime Sayısı: ";
            Console.WriteLine(topWord += sentences.Count());

            //Cümledeki Harf Sayısı:
            int topLetter = 0;
            foreach (var stc in sentences)
            {
                topLetter += stc.Length;
            }
            Console.WriteLine("Cümledeki Toplam Harf Sayısı: "+ topLetter);


        }

        // Sayı Pozitif mi ? Değil mi ? Harf Mi ? Kontrolünü yapan Metot
        static bool isItPozitive(string thisNumber)
        {
            bool result = int.TryParse(thisNumber, out int outNumber);

            if(result)
            {
                if( outNumber > 0 )
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Harf Girdiniz Lütfen Pozitif Bir Sayı Giriniz!");
                return false;
            }

           
        }
    }
}
