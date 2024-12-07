using FluentValidation;
using EmpresaMusical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Service.Validators
{
    public class MusicoAlbumValidator :AbstractValidator<MusicoAlbum>
    {
        public MusicoAlbumValidator()
        {
            RuleFor(prop => prop.Musico)
                .NotEmpty().WithMessage("Por favor, informe o nome do músico vinculado ao álbum")
                .NotNull().WithMessage("Por favor, informe o nome do músico vinculado ao álbum");

            RuleFor(prop => prop.Album)
                .NotEmpty().WithMessage("Por favor, informe o nome do álbum vinculado ao músico")
                .NotNull().WithMessage("Por favor, informe o nome do álbum vinculado ao músico");
        }
    }
}
