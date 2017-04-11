using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Models
{
    public class Usuario
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name="Nome do Usuário")]
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataCadastro { get; set; }
    }
}