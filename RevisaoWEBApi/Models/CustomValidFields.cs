using RevisaoWEBApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {   
                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        return ValidarLogin(value);
                    case ValidFields.ValidaEmail:
                        return ValidarEmail(value, validationContext.DisplayName);
                    case ValidFields.ValidaSenha:
                        return ValidarSenha(value, validationContext.DisplayName);
                    case ValidFields.ValidaNome:
                        return ValidarNome(value);
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }

        private ValidationResult ValidarLogin(object value)
        {
            ContextDB db = new ContextDB();

            Usuario usuarioExiste = db.usuarios.FirstOrDefault(x => x.Login == value.ToString());

            if (usuarioExiste != null)
                return new ValidationResult($"O nome {value} já existe.");

            return ValidationResult.Success;
        }

        private ValidationResult ValidarEmail(object value, string displayField)
        {
        var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido");
        }

        private ValidationResult ValidarNome(object value)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[ a-zA-Z á]*$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult("Informe um nome válido!");
        }

        private ValidationResult ValidarSenha(object value, string displayName)
        {
            if (value.ToString().Length > 16)
                return new ValidationResult($"O campo {displayName} não deve conter mais de 16 caracteres.");
            else if (value.ToString().Length < 8)
                return new ValidationResult($"O campo {displayName} deverá conter no mínimo 8 caracteres.");

            return ValidationResult.Success;
        }
    }
}