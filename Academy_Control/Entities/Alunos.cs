using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Academy_Control.Entities
{
    public class Alunos
    {
        [Key]
        public Int32 AlunoId { get; set; }
        public Int32 Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime Data_matricula { get; set; }
        public bool Ativo { get; set; }
        public bool Selecionado { get; set; }
        public string Turno { get; set; }
        public Decimal Desconto_especial { get; set; }
        public string Foto { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Responsavel { get; set; }
        public DateTime Nascimento { get; set; }
        public string Adulto_crianca { get; set; }
        public string Matricula { get; set; }
        public bool Socio { get; set; }
        public string N_Titulo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Obs { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Orgao { get; set; }
        public bool Ja_praticou_esporte { get; set; }
        public string Onde { get; set; }
        public string Tempo { get; set; }
        public bool Problema_saude { get; set; }
        public DateTime Data_ultimo_exame { get; set; }
        public string Qual { get; set; }
        public DateTime Data_ultimo_pag { get; set; }
        public DateTime Exame_cinza { get; set; }
        public DateTime Exame_azul { get; set; }
        public DateTime Exame_amarela { get; set; }
        public DateTime Exame_laranja { get; set; }
        public DateTime Exame_verde { get; set; }
        public DateTime Exame_roxa { get; set; }
        public DateTime Exame_marron { get; set; }
        public DateTime Exame_preta { get; set; }
        public DateTime Exame_2_dan { get; set; }
        public DateTime Exame_3_dan { get; set; }
        public DateTime Exame_4_dan { get; set; }
        public DateTime Exame_5_dan { get; set; }
    }
}