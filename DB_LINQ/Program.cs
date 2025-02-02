namespace Odev7_
{
    internal class Program
    {//Bir liste oluştur ve içine farklı şehir isimleri ekle.
     //Kullanıcıdan harf girdisi al ve bu harfle başlayan şehirleri LINQ kullanarak ekrana yazdır.
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();

            sehirler.Add("adana"); // 01
            sehirler.Add("adıyaman"); // 02
            sehirler.Add("afyonkarahisar"); // 03
            sehirler.Add("ağrı"); // 04
            sehirler.Add("amasya"); // 05
            sehirler.Add("ankara"); // 06
            sehirler.Add("antalya"); // 07
            sehirler.Add("artvin"); // 08
            sehirler.Add("aydın"); // 09
            sehirler.Add("balıkesir"); // 10
            sehirler.Add("bilecik"); // 11
            sehirler.Add("bingöl"); // 12
            sehirler.Add("bitlis"); // 13
            sehirler.Add("bolu"); // 14
            sehirler.Add("burdur"); // 15
            sehirler.Add("bursa"); // 16
            sehirler.Add("çanakkale"); // 17
            sehirler.Add("çankırı"); // 18
            sehirler.Add("çorum"); // 19
            sehirler.Add("denizli"); // 20
            sehirler.Add("diyarbakır"); // 21
            sehirler.Add("edirne"); // 22
            sehirler.Add("elazığ"); // 23
            sehirler.Add("erzincan"); // 24
            sehirler.Add("erzurum"); // 25
            sehirler.Add("eskişehir"); // 26
            sehirler.Add("gaziantep"); // 27
            sehirler.Add("giresun"); // 28
            sehirler.Add("gümüşhane"); // 29
            sehirler.Add("hakkâri"); // 30
            sehirler.Add("hatay"); // 31
            sehirler.Add("ısparta"); // 32
            sehirler.Add("mersin"); // 33
            sehirler.Add("istanbul"); // 34
            sehirler.Add("izmir"); // 35
            sehirler.Add("kars"); // 36
            sehirler.Add("kastamonu"); // 37
            sehirler.Add("kayseri"); // 38
            sehirler.Add("kırklareli"); // 39
            sehirler.Add("kırşehir"); // 40
            sehirler.Add("kocaeli"); // 41
            sehirler.Add("konya"); // 42
            sehirler.Add("kütahya"); // 43
            sehirler.Add("malatya"); // 44
            sehirler.Add("manisa"); // 45
            sehirler.Add("kahramanmaraş"); // 46
            sehirler.Add("mardin"); // 47
            sehirler.Add("muğla"); // 48
            sehirler.Add("muş"); // 49
            sehirler.Add("nevşehir"); // 50
            sehirler.Add("niğde"); // 51
            sehirler.Add("ordu"); // 52
            sehirler.Add("rize"); // 53
            sehirler.Add("sakarya"); // 54
            sehirler.Add("samsun"); // 55
            sehirler.Add("siirt"); // 56
            sehirler.Add("sinop"); // 57
            sehirler.Add("sivas"); // 58
            sehirler.Add("tekirdağ"); // 59
            sehirler.Add("tokat"); // 60
            sehirler.Add("trabzon"); // 61
            sehirler.Add("tunceli"); // 62
            sehirler.Add("şanlıurfa"); // 63
            sehirler.Add("uşak"); // 64
            sehirler.Add("van"); // 65
            sehirler.Add("yozgat"); // 66
            sehirler.Add("zonguldak"); // 67
            sehirler.Add("aksaray"); // 68
            sehirler.Add("bayburt"); // 69
            sehirler.Add("karaman"); // 70
            sehirler.Add("kırıkkale"); // 71
            sehirler.Add("batman"); // 72
            sehirler.Add("şırnak"); // 73
            sehirler.Add("bartın"); // 74
            sehirler.Add("ardahan"); // 75
            sehirler.Add("ığdır"); // 76
            sehirler.Add("yalova"); // 77
            sehirler.Add("karabük"); // 78
            sehirler.Add("kilis"); // 79
            sehirler.Add("osmaniye"); // 80
            sehirler.Add("düzce"); // 81

            Console.Write("Bir harf girin: ");
            char aramaHarfi = Console.ReadLine().ToLower()[0];

            List<string> arananSehirler = sehirler.Where(p => p.StartsWith(aramaHarfi.ToString())).ToList();
            foreach (var sehir in arananSehirler)
            {
                string duzeltilmisSehir = char.ToUpper(sehir[0]) + sehir.Substring(1);
                Console.WriteLine(duzeltilmisSehir);
            }
        }
    }
}
