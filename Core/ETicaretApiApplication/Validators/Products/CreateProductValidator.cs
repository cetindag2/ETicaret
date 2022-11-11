using FluentValidation;
using ETicaretAPI.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen ürün adını boş geçmeyiniz")
                .MaximumLength(50)
                .MinimumLength(3)
                .WithMessage("Lütfen ürün adını 3 ile 50 karekter arası giriniz");
            RuleFor(p => p.Price)
                .NotEmpty()
                .NotEmpty()
                .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                .WithMessage("Fiyat bilgisi boş olamaz");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotEmpty()
                .WithMessage("Lütfen stock bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                .WithMessage("Stock bilgisi boş olamaz");

        }

    }
}
