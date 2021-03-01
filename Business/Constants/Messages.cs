using Core.Entities.Concrete;
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
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError= "Şifre hatalı";
        public static string SuccesfulLogin= "Sisteme giriş Başarılıı";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated="Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
