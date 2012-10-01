namespace MeAnota.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IndiceUsuario : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Usuario", "Email", c => c.String(maxLength: 255, nullable: false));
            CreateIndex("Usuario", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("Usuario", "IX_Email");
            AlterColumn("Usuario", "Email", c => c.String(isMaxLength: true, nullable: true));
        }
    }
}
