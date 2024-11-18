string[] ögrenciler = { "Safiye", "Eymen", "Safiye", "Bekir", "Rümeysa", "Safiye", "Berat", "Safiye" };

int baslangicİndexi = Array.IndexOf(ögrenciler, "Safiye");
int sonucIndexi = Array.LastIndexOf(ögrenciler, "Safiye");

Console.WriteLine(baslangicİndexi);

while (baslangicİndexi != sonucIndexi) { 

    int yenibaslangicindexi = Array.IndexOf(ögrenciler, "Safiye", baslangicİndexi+1);

    Console.WriteLine(yenibaslangicindexi);

    baslangicİndexi = yenibaslangicindexi;
   
}