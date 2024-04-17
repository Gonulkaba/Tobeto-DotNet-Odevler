﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Products.Commands.Create
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(i => i.Name).NotEmpty().WithMessage("İsim alanı boş olamaz");  //Name alanı boşsa hata fırlat
            RuleFor(i => i.Stock).GreaterThanOrEqualTo(1);  //Stock değeri 1 den büyükse veya eşitse. (1den büyükse için = GreaterThan) 
            RuleFor(i => i.UnitPrice).GreaterThanOrEqualTo(1);
            RuleFor(i => i.CategoryId).GreaterThanOrEqualTo(1);


            //RuleFor(i => i.Name).Must(name => name.StartsWith("A"));
            RuleFor(i => i.Name).Must(StartsWithA).WithMessage("İsim alanı A harfi ile başlamalıdır."); //kendi validasyonlarımızı yazabiliyoruz.
            

        }

        public bool StartsWithA(string name)
        {
            return name.StartsWith("A");
        }
    }
}