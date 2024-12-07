using FluentValidation;
using EmpresaMusical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Service.Validators
{
    public class MusicaValidator : AbstractValidator<Musica>
    {
        public MusicaValidator()
        {
            RuleFor(prop => prop.NomeMusica)
                .NotEmpty().WithMessage("Por favor, informe o nome da música")
                .NotNull().WithMessage("Por favor, informe o nome da música");

            RuleFor(prop => prop.Gravadora)
                .NotEmpty().WithMessage("Por favor, informe a gravadora responsável pelo album/música")
                .NotNull().WithMessage("Por favor, informe a gravadora responsável pelo album/música");

            RuleFor(prop => prop.Album)
                .NotEmpty().WithMessage("Por favor, informe o título do album que contém a música")
                .NotNull().WithMessage("Por favor, informe o título do album que contém a música");
        }
    }
}
