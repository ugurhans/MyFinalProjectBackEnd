using Core.Entities.Concrate;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün Eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductListed = "Ürünler Listelendi";
        internal static string BrandAdded = "Marka Eklendi";
        internal static string ColorAdded = "Renk Seçeneği Eklendi";

        public static string ColorListed = "Ürünler Listelendi";
        public static string UserListed = "Kullanıcılar Listelendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        internal static string RentalListed = "Kiralama İşlemleri Listelendi";

        public static string RentalAdded = "Kiralama işlemi Eklendi";
        public static string CustomerAdded = "Kullanıcı Eklendi";

        public static string RentalNotAvaible = "Araba Henüz Teslim Edilmedi";
        public static string ImagesListed = "Resimler Listelendi";
        internal static string ImageAdded = "Resim Eklendi";
        internal static string ImagesDeleted = "Resim silindi";
        internal static string CarCheckImageLimited = "Resim sayısı arttırılamıyor.";

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır";
        internal static string UserRegistered = "Kayıt Olundu";
        internal static string UserNotFound = "Kullanıcı Bulunamadı";
        internal static string PasswordError = "Şifreyi Yanlış girdiniz";
        internal static string SuccessfulLogin = "Başarıyla giriş yapıldı.";
        internal static string UserAlreadyExists = "Kullanıcı zaten mevcur.";
        internal static string AccessTokenCreated = "Giriş Tokenı Yaratıldı";
        internal static string CarListed = "Arabalar Listelendi";
        internal static string CarDeleted = "Arabalar Silindi";
        internal static string CustomerDeleted = "Müşteri Silindi";
        internal static string NewCustomerAdded = "Yeni müşteri eklendi";
        internal static string CustomerUpdated = "Müşteri güncellendi";
        internal static string ColorUpdated = "Renk güncellendi";
        internal static string ColorDeleted = "Renk Silindi";

        public static string CarUpdate = "Araba güncellendi";
    }
}
