﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Core.Entities.Concrate;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).Length(1, 250);
            RuleFor(u => u.LastName).Length(1, 25);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez!");
            RuleFor(u => u.Password).Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter, en az bir harf ve bir sayı içermelidir!");
        }

        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }
    }
}

