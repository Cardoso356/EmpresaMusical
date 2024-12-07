using FluentValidation;
using EmpresaMusical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Service.Validators
{
    public class MusicoInstrumentoValidator :AbstractValidator<MusicoInstrumento>
    {
        public MusicoInstrumentoValidator()
        {
            RuleFor(prop => prop.Musico)
                .NotEmpty().WithMessage("Por favor, informe o nome do músico vinculado ao instrumento")
                .NotNull().WithMessage("Por favor, informe o nome do músico vinculado ao instrumento");

            RuleFor(prop => prop.Instrumento)
                .NotEmpty().WithMessage("Por favor, informe o nome do instrumento vinculado ao músico")
                .NotNull().WithMessage("Por favor, informe o nome do instrumento vinculado ao músico");
        }
    }
}
