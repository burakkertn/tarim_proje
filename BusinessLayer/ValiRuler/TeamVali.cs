using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValiRuler
{
    public class TeamVali : AbstractValidator<Team>
    {
        public TeamVali()
        {

            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Adı Boş Geçme");


            RuleFor(x => x.Title).NotEmpty().WithMessage("Görevi Boş Geçemezsiniz");

            RuleFor(x => x.ResimUrl).NotEmpty().WithMessage("Görevi Boş Geçemezsiniz");

            RuleFor(x => x.FacebookUrl).NotEmpty().WithMessage("Görevi Boş Geçemezsiniz");

            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Görevi Boş Geçemezsiniz");

            RuleFor(x => x.TwitterrUrl).NotEmpty().WithMessage("Görevi Boş Geçemezsiniz");

            RuleFor(x => x.PersonName).MaximumLength(20).WithMessage("Maksimum 20 Karakter Giriniz");

            RuleFor(x => x.PersonName).MinimumLength(4).WithMessage("Minimum 4 Karakter Giriniz");

            RuleFor(x => x.Title).MaximumLength(15).WithMessage("Maksimum 15 Karakter Giriniz");

            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Minimum 3 Karakter Giriniz");



        }

        public ValidationResult Validate(Resim resim)
        {
            throw new NotImplementedException();
        }
    }
}
