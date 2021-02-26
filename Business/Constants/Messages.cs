using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string DailyPriceInvalid = "Arabanın Günlük Ücreti 0'dan Büyük Olmalıdır";
        public static string DescriptionInvalid = "Arabanın Açıklaması Minimum 2'den Karakter Olmalıdır";
        public static string MaintenanceTime ="Sistem Bakımda";
        public static string CarsListed = "Araçlar Listelendi";
        public static string RentalReturnDateInValid = "Araba henüz teslim edilmedi.";
        public static string RentalAdded = "Kiralama başarılı";
        public static string ImagesAdded = "resim eklendi";
        public static string FailAddedImageLimit = "Resim limitine erişildi!";
    }
}
