using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static classı newlemeyi ortadan kaldırıyor
    //public oluşturulan değişkenler PascalCase yazılır yani ilk harfi büyük başlar
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım arası";
        public static string ProductsListed = "Ürünler listelendi";
        public static string InvalidUnitPrice = "Ürünün fiyatı 0 ve ya daha az olamaz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir ";
        public static string ProductNameAlreadyExists = "Böyle bir ürün mevcut";
        public static string CategoryLimitExceeded = "Kategori sayısı limiti aştı";
        public static string AuthorizationDenied = "Yetki reddedildi.";
        public static string UserRegistered = "Başarıyla kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı şifre girdiniz.";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı var.";
        public static string AccessTokenCreated = "Giriş token oluşturuldu.";
        public static string CategoryAdded = "Yeni Kategori Eklendi.";
    }
}
