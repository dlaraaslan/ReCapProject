using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "ürün ismi geçersiz";
        public static string DailyPriceInvalid = "Geçersiz fiyat.";
        public static string CarDeleted = "ürün silindi";

        public static string BrandNameInvalid = "Geçersiz marka ismi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";

        public static string MaintenanceTime = "Sistem bakımda ";
        public static string CarsListed = "Ürünler listelendi";
        public static string FailRental = "Araç müsait değil";
        public static string RentalAdded = "Kiralama işlemi başarıyla tamamlandı";

        public static string CarImageAdded = "Araç fotoğrafı eklendi.";
        public static string CarImageUpdated = "Araç fotoğrafı güncellendi.";
        public static string CarImageDeleted = "Araç fotoğrafı silindi.";
        public static string CarImageCountOfCarError = "İlgili araca ait fotoğraf adedi maksimum sayıdadır.";
        public static string CarImageLimitExceeded = "Car Image Limit Exceeded!";
        public static string AuthorizationDenied = "yetkiniz yok.";
        public static string UserRegistered = "kayıt oldu";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "parola hatası";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAdded = "kullanıcı eklendi";
    }
}
