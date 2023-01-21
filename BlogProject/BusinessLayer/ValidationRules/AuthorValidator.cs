using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AuthorValidator : AbstractValidator<Author>
	{
		public AuthorValidator() 
		{
			RuleFor(x=>x.AuthorName).NotEmpty().WithMessage("Ad Soyad boş bırakılamaz.")
				.MinimumLength(2).WithMessage("Ad Soyad en az 2 karakter olmalıdır.")
				.MaximumLength(50).WithMessage("Ad Soyad en fazla 50 karakter olmalıdır.");
			
			
			RuleFor(x => x.AuthorEmail).NotEmpty().WithMessage("Email adresi boş bırakılamaz.")
			.EmailAddress().WithMessage("Geçersiz email adresi girdiniz.");
			
			
			RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez")
			.MinimumLength(8).WithMessage("Şifreniz en az 8 karakter olmalıdır.")
			.MaximumLength(16).WithMessage("Şifreniz en fazla 16 karakter olmalıdır.")
			.Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük karakter içermelidir.")
			.Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük karakter içermelidir.")
			.Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam içermelidir.")
			.Matches(@"[\!\?\*\.]+").WithMessage("Şifreniz en az bir özel karakter (!? *.) içermelidir.");

		}
	}
}
