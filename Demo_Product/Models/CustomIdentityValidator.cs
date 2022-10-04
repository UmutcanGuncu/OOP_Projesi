using Microsoft.AspNetCore.Identity;

namespace Demo_Product.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description ="Parola En Az 6 Karakter Olmalı"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordReqyiresUpper",
                Description = "Parola En Az 1 Büyük Harf İçermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordReqyiresUpper",
                Description="Parola En Az 1 Küçük Harf İçermelidir"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code= "PasswordRequiresNonAlphanumeric",
                Description="Parola En Az 1 Tane Alfanümerik Karakter İçermelidir"
            };
        }
    }
}
