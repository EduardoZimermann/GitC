using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade.Models
{
    public class Cliente : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEstadoCivil)]
        public string EstadoCivil { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaRg)]
        public string Rg { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaCpfCnpj)]
        public string CpfCnpj { get; set; }

        public string NomeFantasia { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaCep)]
        public string Cep { get; set; }

        [CustomValidFields(default)]
        public string Endereco { get; set; }

        [CustomValidFields(default)]
        public string Cidade { get; set; }

        [CustomValidFields(default)]
        public string Estado { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaTelefone)]
        public string Telefone { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaCelular)]
        public string Celular { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CpfCnpj.Length == 14)
            {
                if (string.IsNullOrWhiteSpace(NomeFantasia) || string.IsNullOrEmpty(NomeFantasia))
                    yield return new ValidationResult("Informe o nome fantasia!");
            }
        }
    }
}