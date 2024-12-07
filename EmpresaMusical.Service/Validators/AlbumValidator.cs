using FluentValidation;
using EmpresaMusical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Service.Validators
{
    public class AlbumValidator : AbstractValidator<Album>
    {
        public AlbumValidator()
        {
            RuleFor(prop => prop.TituloAlbum)
                .NotEmpty().WithMessage("Por favor, informe o título do álbum")
                .NotNull().WithMessage("Por favor, informe o título do álbum");

            RuleFor(prop => prop.Formato)
                .NotEmpty().WithMessage("Por favor, informe o formato do álbum")
                .NotNull().WithMessage("Por favor, informe o formato do álbum");


        }
    }
}
