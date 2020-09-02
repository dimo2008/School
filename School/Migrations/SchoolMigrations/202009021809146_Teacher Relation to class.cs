namespace School.Migrations.SchoolMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherRelationtoclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "ClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "ClassId");
            AddForeignKey("dbo.Teachers", "ClassId", "dbo.Classes", "ClassId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "ClassId", "dbo.Classes");
            DropIndex("dbo.Teachers", new[] { "ClassId" });
            DropColumn("dbo.Teachers", "ClassId");
        }
    }
}
