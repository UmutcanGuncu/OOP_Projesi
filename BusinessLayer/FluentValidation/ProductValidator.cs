using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün Adı Minimum 3 Karakter Olmalıdı");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok Sayısı Boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Boş Geçilemez");


        }
    }
}
