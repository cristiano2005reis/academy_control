namespace Academy_Control.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criaçãodobanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        AlunoId = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nome = c.String(unicode: false),
                        Endereco = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        Estado = c.String(unicode: false),
                        Data_matricula = c.DateTime(nullable: false, precision: 0),
                        Ativo = c.Boolean(nullable: false),
                        Selecionado = c.Boolean(nullable: false),
                        Turno = c.String(unicode: false),
                        Desconto_especial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Foto = c.String(unicode: false),
                        Pai = c.String(unicode: false),
                        Mae = c.String(unicode: false),
                        Responsavel = c.String(unicode: false),
                        Nascimento = c.DateTime(nullable: false, precision: 0),
                        Adulto_crianca = c.String(unicode: false),
                        Matricula = c.String(unicode: false),
                        Socio = c.Boolean(nullable: false),
                        N_Titulo = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Celular = c.String(unicode: false),
                        Obs = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        CPF = c.String(unicode: false),
                        RG = c.String(unicode: false),
                        Orgao = c.String(unicode: false),
                        Ja_praticou_esporte = c.Boolean(nullable: false),
                        Onde = c.String(unicode: false),
                        Tempo = c.String(unicode: false),
                        Problema_saude = c.Boolean(nullable: false),
                        Data_ultimo_exame = c.DateTime(nullable: false, precision: 0),
                        Qual = c.String(unicode: false),
                        Data_ultimo_pag = c.DateTime(nullable: false, precision: 0),
                        Exame_cinza = c.DateTime(nullable: false, precision: 0),
                        Exame_azul = c.DateTime(nullable: false, precision: 0),
                        Exame_amarela = c.DateTime(nullable: false, precision: 0),
                        Exame_laranja = c.DateTime(nullable: false, precision: 0),
                        Exame_verde = c.DateTime(nullable: false, precision: 0),
                        Exame_roxa = c.DateTime(nullable: false, precision: 0),
                        Exame_marron = c.DateTime(nullable: false, precision: 0),
                        Exame_preta = c.DateTime(nullable: false, precision: 0),
                        Exame_2_dan = c.DateTime(nullable: false, precision: 0),
                        Exame_3_dan = c.DateTime(nullable: false, precision: 0),
                        Exame_4_dan = c.DateTime(nullable: false, precision: 0),
                        Exame_5_dan = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.AlunoId);
            
            CreateTable(
                "dbo.AlunosTurmas",
                c => new
                    {
                        AlunoTurmaId = c.Int(nullable: false, identity: true),
                        AlunoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlunoTurmaId)
                .ForeignKey("dbo.Alunos", t => t.AlunoId, cascadeDelete: true)
                .Index(t => t.AlunoId);
            
            CreateTable(
                "dbo.Mensalidades",
                c => new
                    {
                        MensalidadeId = c.Int(nullable: false, identity: true),
                        AlunoId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        Vencimento = c.DateTime(nullable: false, precision: 0),
                        Data_pagamento = c.DateTime(nullable: false, precision: 0),
                        Valor_pagar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor_pago = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Selecionado = c.String(unicode: false),
                        Emissao = c.DateTime(nullable: false, precision: 0),
                        Mes = c.String(unicode: false),
                        Valor_professor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor_desconto_aluno = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor_clube = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor_academia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MensalidadeId)
                .ForeignKey("dbo.Alunos", t => t.AlunoId, cascadeDelete: true)
                .ForeignKey("dbo.Turmas", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.AlunoId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        TurmaId = c.Int(nullable: false, identity: true),
                        ModalidadeId = c.Int(nullable: false),
                        ProfessorId = c.Int(nullable: false),
                        Codigo = c.String(unicode: false),
                        Nome_turma = c.String(unicode: false),
                        Hora_inicio = c.DateTime(nullable: false, precision: 0),
                        Hora_fim = c.DateTime(nullable: false, precision: 0),
                        Seg = c.String(unicode: false),
                        Ter = c.String(unicode: false),
                        Qua = c.String(unicode: false),
                        Qui = c.String(unicode: false),
                        Sex = c.String(unicode: false),
                        Sab = c.String(unicode: false),
                        Dom = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TurmaId)
                .ForeignKey("dbo.Modalidades", t => t.ModalidadeId, cascadeDelete: true)
                .ForeignKey("dbo.Professores", t => t.ProfessorId, cascadeDelete: true)
                .Index(t => t.ModalidadeId)
                .Index(t => t.ProfessorId);
            
            CreateTable(
                "dbo.Modalidades",
                c => new
                    {
                        ModalidadeId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(unicode: false),
                        Nome = c.String(unicode: false),
                        Valor_bruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor_desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vencimento = c.DateTime(nullable: false, precision: 0),
                        Selecionada = c.Boolean(nullable: false),
                        Valor_combo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Professores_ProfessorId = c.Int(),
                    })
                .PrimaryKey(t => t.ModalidadeId)
                .ForeignKey("dbo.Professores", t => t.Professores_ProfessorId)
                .Index(t => t.Professores_ProfessorId);
            
            CreateTable(
                "dbo.Professores",
                c => new
                    {
                        ProfessorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Codigo = c.String(unicode: false),
                        Percentual = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data_cadastro = c.DateTime(nullable: false, precision: 0),
                        Obs = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ProfessorId);
            
            CreateTable(
                "dbo.Valores",
                c => new
                    {
                        ValorId = c.Int(nullable: false, identity: true),
                        Percentual_Country = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto_aluno_socio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ValorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mensalidades", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.Turmas", "ProfessorId", "dbo.Professores");
            DropForeignKey("dbo.Modalidades", "Professores_ProfessorId", "dbo.Professores");
            DropForeignKey("dbo.Turmas", "ModalidadeId", "dbo.Modalidades");
            DropForeignKey("dbo.Mensalidades", "AlunoId", "dbo.Alunos");
            DropForeignKey("dbo.AlunosTurmas", "AlunoId", "dbo.Alunos");
            DropIndex("dbo.Modalidades", new[] { "Professores_ProfessorId" });
            DropIndex("dbo.Turmas", new[] { "ProfessorId" });
            DropIndex("dbo.Turmas", new[] { "ModalidadeId" });
            DropIndex("dbo.Mensalidades", new[] { "TurmaId" });
            DropIndex("dbo.Mensalidades", new[] { "AlunoId" });
            DropIndex("dbo.AlunosTurmas", new[] { "AlunoId" });
            DropTable("dbo.Valores");
            DropTable("dbo.Professores");
            DropTable("dbo.Modalidades");
            DropTable("dbo.Turmas");
            DropTable("dbo.Mensalidades");
            DropTable("dbo.AlunosTurmas");
            DropTable("dbo.Alunos");
        }
    }
}
