namespace Atividade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validaaa : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "Ativo");
            DropColumn("dbo.Clientes", "UsuarioCriacao");
            DropColumn("dbo.Clientes", "UsuarioAlteracao");
            DropColumn("dbo.Clientes", "DataCriacao");
            DropColumn("dbo.Clientes", "DataAlteracao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clientes", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clientes", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Ativo", c => c.Boolean(nullable: false));
        }
    }
}
