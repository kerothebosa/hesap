
Console.WriteLine("Toplama için:1");
Console.WriteLine("Çıkarma için:2");
Console.WriteLine("Çarpma için:3");
Console.WriteLine("Bölme için:4");
Console.WriteLine("Yapmak istediğiniz işlem için giriş yapınız:(1,2,3,4)");
int islem = int.Parse(Console.ReadLine());
    if (islem == 1 || islem == 2 ||islem == 3 ||islem == 4)
    {
                
            Console.WriteLine("İlk sayıyı giriniz:");
            float birinci =float.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            float ikinci =float.Parse(Console.ReadLine());
            float sonuc=0;

            string den = null;

                switch (islem)
                {
                    case 1:
                    sonuc = birinci+ikinci;
                    den = "+";
                        break;
                    case 2:
                    sonuc = birinci - ikinci;
                    den ="-";
                        break;
                    case 3:
                    sonuc=  birinci * ikinci;
                    den="*";
                        break;
                    case 4:
                    sonuc = birinci / ikinci;
                    den="/";
                        break;
                    default:
                    
                        break;
                }

                Console.WriteLine("Sonuç:{0}",sonuc);
                Console.WriteLine("Yapılan İşlem: {0} {1} {2} = {3}",birinci,den,ikinci,sonuc);

    }
    else
    {
    Console.WriteLine("Doğru bir işlem girişi olmadı.");
    }
