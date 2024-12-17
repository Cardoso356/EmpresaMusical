using FluentValidation;
using EmpresaMusical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Service.Validators
{
    public class MusicoValidator : AbstractValidator<Musico>
    {
        public MusicoValidator() 
        {
            RuleFor(prop => prop.NomeMusico)
                .NotEmpty().WithMessage("Por favor, informe o nome do músico")
                .NotNull().WithMessage("Por favor, informe o nome do músico");

            RuleFor(prop => prop.Endereco)
                .NotEmpty().WithMessage("Por favor, informe o endereço do músico")
                .NotNull().WithMessage("Por favor, informe o endereço do músico");

            RuleFor(prop => prop.Email)
                .EmailAddress().WithMessage("E-mail inválido.")
                .NotEmpty().WithMessage("Por favor, informe o endereço de email do músico")
                .NotNull().WithMessage("Por favor, informe o endereço de email do músico");

            RuleFor(prop => prop.Telefone)
                .NotEmpty().WithMessage("Por favor, informe o número de telefone do músico")
                .NotNull().WithMessage("Por favor, informe o número de telefone do músico");

        }
    }
}
