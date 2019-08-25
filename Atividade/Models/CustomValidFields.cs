using Atividade.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Atividade.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB db = new ContextDB();

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
                    case ValidFields.ValidaNome:
                        return ValidaNome(value);
                    case ValidFields.ValidaEstadoCivil:
                        return ValidaEstadoCivil(value, validationContext.DisplayName);
                    case ValidFields.ValidaRg:
                        return ValidaRg(value, validationContext.DisplayName);
                    case ValidFields.ValidaCpfCnpj:
                        return ValidaCpfCnpj(value, validationContext.DisplayName);
                    case ValidFields.ValidaNomeFantasia:
                        return ValidationResult.Success;
                    case ValidFields.ValidaCep:
                        return ValidaCep(value, validationContext.DisplayName);
                    case ValidFields.ValidaTelefone:
                        return ValidaTelefone(value, validationContext.DisplayName);
                    case ValidFields.ValidaCelular:
                        return ValidaCelular(value, validationContext.DisplayName);
                    case ValidFields.ValidaEmail:
                        return ValidaEmail(value, validationContext.DisplayName);
                    default:
                        return ValidationResult.Success;
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório!");
        }

        private ValidationResult ValidaNome(object value)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[ a-zA-Z á]*$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult("Informe um nome válido!");
        }

        private ValidationResult ValidaEstadoCivil(object value, string displayName)
        {
            var toLower = value.ToString().ToLower();

            if (toLower == "solteiro" || toLower == "casado" || toLower == "viuvo" || toLower == "viúvo" || toLower == "divorciado")
                return ValidationResult.Success;

            return new ValidationResult($"Informe um valor válido para o campo {displayName}!");
        }

        private ValidationResult ValidaRg(object value, string displayName)
        {
            var result = Regex.IsMatch(value.ToString(), @"^([0-9]{7,14})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"Informe um valor válido para o campo {displayName}!");
        }

        private ValidationResult ValidaCpfCnpj(object value, string displayName)
        {
            var existe = db.clientes.FirstOrDefault(x => x.CpfCnpj == value.ToString());

            if (existe != null)
                return new ValidationResult("O valor informado já foi cadastrado.");

            var result = Regex.IsMatch(value.ToString(), @"^([0-9]{11})$");

            var result2 = Regex.IsMatch(value.ToString(), @"^([0-9]{14})$");

            if (result || result2)
                return ValidationResult.Success;

            return new ValidationResult($"Informe um valor válido para o campo {displayName}!");
        }

        private ValidationResult ValidaCep(object value, string displayName)
        {
            var result = Regex.IsMatch(value.ToString(), @"^([0-9]{5})\-?([0-9]{3})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"Informe um valor válido para o campo {displayName}!");
        }

        private ValidationResult ValidaTelefone(object value, string displayName)
        {
            var result = Regex.IsMatch(value.ToString(), @"^(\(?[0-9]{2}\)?)\s?([9]{1})?([0-9]{4})\-?([0-9]{4})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"Informe um {displayName} válido!");
        }

        private ValidationResult ValidaCelular(object value, string displayName)
        {
            var result = Regex.IsMatch(value.ToString(), @"^(\(?[0-9]{2}\)?)\s?([9]{1})?([0-9]{4})\-?([0-9]{4})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"Informe um {displayName} válido!");
        }

        private ValidationResult ValidaEmail(object value, string displayName)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"Informe um {displayName} válido!");
        }
    }
}