using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValiRuler
{
    public class ImageVali : AbstractValidator<Resim>
    {
        public ImageVali()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel Başlığı Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel Açıklaması Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel URL'si Boş Geçilemez");

            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapın");

            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Lütfen En Az 8 Karakter Veri Girişi Yapın");
        }
    }
}
