
using Encapsulation;

// Geçerli kapı sayısı ile araba oluşturulması
Araba araba1 = new Araba("Renault", "Megane", "Siyah", 4);

// Geçersiz kapı sayısı ile araba oluşturulması
Araba araba2 = new Araba("Volkswagen", "Polo" , "Beyaz", 3);

araba1.Bilgiler();
araba2.Bilgiler();