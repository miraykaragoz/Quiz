namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz Uygulamasına Hoş Geldiniz.");
            Console.WriteLine("Soru - Cevap Oyunu için 1'e tıklayınız.");
            string cevap = Console.ReadLine();

            if(cevap == "1")
            {
                Console.Clear();

                string[] sorular = ["Mona Lisa'nın sergilendiği müze?", "1 milyonun ondalık ifadesi?", "Savaş tanrısı?", "En büyük gezegen?", "İstanbul'un fethi hangi yıl?", "2016 Yaz Olimpiyatları'nın ev sahibi?"];
                string[] secenekler = ["Louvre|Vatikan Müzesi|Metropolitan Sanat Müzesi", "100,000.00|1,000,000.00|10,000.00", "Zeus|Mars|Poseidon", "Mars|Jüpiter|Venüs", "1453|1520|1492", "İtalya|Rusya|Brezilya"];
                string[] cevaplar = ["Louvre", "1,000,000.00", "Mars", "Jüpiter", "1453", "Brezilya"];

                for(int i = 0;  i < sorular.Length; i++)
                {
                    Console.WriteLine($"Soru {i + 1}: {sorular[i]}");                 
                    string[] secenekListesi = secenekler[i].Split('|');                   
                    Console.WriteLine("Seçenekler: ");

                    for (int j = 0; j < secenekListesi.Length; j++)
                    {
                        Console.WriteLine($"{j + 1}. {secenekListesi[j]}");   
                    }

                    Console.Write("Cevabınızı giriniz (1, 2, 3): ");

                    string inputCevap = Console.ReadLine();
                    int cevapIndex;

                    Console.Clear();

                    if (int.TryParse(inputCevap, out cevapIndex) && cevapIndex > 0 && cevapIndex <= secenekListesi.Length)
                    {
                        string secilenCevap = secenekListesi[cevapIndex - 1];
                        if (secilenCevap == cevaplar[i])
                        {
                            Console.WriteLine("Doğru cevap!");
                        }
                        else
                        {
                            Console.WriteLine($"Yanlış cevap! Doğru cevap: {cevaplar[i]}");
                        }
                    }
                }
            }
        }
    }
}
