namespace QueroTrocarMeuLivro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Pais", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "Pais");
        }
    }
}
