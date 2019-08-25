namespace Atividade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Longs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "CpfCnpj", c => c.Long(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.Long(nullable: false));
            AlterColumn("dbo.Clientes", "Celular", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Celular", c => c.Double(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.Double(nullable: false));
            AlterColumn("dbo.Clientes", "CpfCnpj", c => c.Double(nullable: false));
        }
    }
}
