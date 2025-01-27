using Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersizdir";
        
        public static string CarListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncelledni";
        public static string CarNotAvailable = "Araba aktif olarak kullanımda";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string AccessTokenCreated = "Token oluşturuldua";
        public static string AuthorizationDenied = "Autherize reddedildi";
        public static string CarImageAdded;
        public static string ImageAddingFailed;
        public static string FileDeletionFailed;
        public static string ImageDataDeletionFailed;
        public static string CarImageDeleted;
        public static string FileNotFound = "Dosya bulunamadı";
        internal static string ImageLimitExceded = "Resim limiti dolu";
    }
}
