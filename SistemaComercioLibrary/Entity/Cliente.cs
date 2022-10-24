﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(18)]
        public string Cpf_Cnpj { get; set; }
        [Required]
        [MaxLength(255)]
        public string Logradouro { get; set; }
        [Required]
        [MaxLength(4)]
        public int Numero { get; set; }
        [Required]
        [MaxLength(255)]
        public string Complemento { get; set; }
        [Required]
        [MaxLength(255)]
        public string Bairro { get; set; }
        [Required]
        [MaxLength(255)]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(255)]
        public string Estado { get; set; }
        [Required]
        [MaxLength(9)]
        public string Cep { get; set; }
        [Required]
        [MaxLength(13)]
        public string Telefone { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        public List<ContaReceber> ContaReceber  { get; set; }
        public List<Venda> Venda { get; set; }
    }
}
