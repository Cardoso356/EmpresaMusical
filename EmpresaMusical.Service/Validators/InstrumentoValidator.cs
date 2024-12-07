using FluentValidation;
using EmpresaMusical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Service.Validators
{
    public class InstrumentoValidator : AbstractValidator<Instrumento>
    {
        public InstrumentoValidator() 
        {
            RuleFor(prop => prop.NomeInstrumento)
                .NotEmpty().WithMessage("Por favor, informe o nome do instrumento")
                .NotNull().WithMessage("Por favor, informe o nome do instrumento");

            RuleFor(prop => prop.Tipo)
                .NotEmpty().WithMessage("Por favor, informe o tipo do instrumento")
                .NotNull().WithMessage("Por favor, informe o tipo do instrumento");

        }
    }
}
