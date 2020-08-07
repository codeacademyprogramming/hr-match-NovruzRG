namespace HR_Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CVs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Category = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        Salary = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Education = c.String(nullable: false, maxLength: 50),
                        Experience = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 50),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Vacancies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(nullable: false, maxLength: 50),
                        Company = c.String(nullable: false, maxLength: 50),
                        Category = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        Salary = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Education = c.String(nullable: false, maxLength: 50),
                        Experience = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        About = c.String(nullable: false, maxLength: 250),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VacancyCVs",
                c => new
                    {
                        Vacancy_ID = c.Int(nullable: false),
                        CV_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vacancy_ID, t.CV_ID })
                .ForeignKey("dbo.Vacancies", t => t.Vacancy_ID, cascadeDelete: true)
                .ForeignKey("dbo.CVs", t => t.CV_ID, cascadeDelete: true)
                .Index(t => t.Vacancy_ID)
                .Index(t => t.CV_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacancies", "UserId", "dbo.Users");
            DropForeignKey("dbo.VacancyCVs", "CV_ID", "dbo.CVs");
            DropForeignKey("dbo.VacancyCVs", "Vacancy_ID", "dbo.Vacancies");
            DropForeignKey("dbo.CVs", "UserId", "dbo.Users");
            DropIndex("dbo.VacancyCVs", new[] { "CV_ID" });
            DropIndex("dbo.VacancyCVs", new[] { "Vacancy_ID" });
            DropIndex("dbo.Vacancies", new[] { "UserId" });
            DropIndex("dbo.CVs", new[] { "UserId" });
            DropTable("dbo.VacancyCVs");
            DropTable("dbo.Vacancies");
            DropTable("dbo.CVs");
        }
    }
}
