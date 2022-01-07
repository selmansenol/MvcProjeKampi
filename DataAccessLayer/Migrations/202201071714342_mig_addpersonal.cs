namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addpersonal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personals",
                c => new
                    {
                        PersonalID = c.Int(nullable: false, identity: true),
                        PersonalName = c.String(maxLength: 50),
                        PersonalSurname = c.String(maxLength: 50),
                        PersonalJob = c.String(maxLength: 50),
                        Skill = c.String(maxLength: 20),
                        SkillPoint = c.Int(nullable: false),
                        Skill2 = c.String(maxLength: 20),
                        SkillPoint2 = c.Int(nullable: false),
                        Skill3 = c.String(maxLength: 20),
                        SkillPoint3 = c.Int(nullable: false),
                        Skill4 = c.String(maxLength: 20),
                        SkillPoint4 = c.Int(nullable: false),
                        Skill5 = c.String(maxLength: 20),
                        SkillPoint5 = c.Int(nullable: false),
                        Skill6 = c.String(maxLength: 20),
                        SkillPoint6 = c.Int(nullable: false),
                        Skill7 = c.String(maxLength: 20),
                        SkillPoint7 = c.Int(nullable: false),
                        Skill8 = c.String(maxLength: 20),
                        SkillPoint8 = c.Int(nullable: false),
                        Skill9 = c.String(maxLength: 20),
                        SkillPoint9 = c.Int(nullable: false),
                        Skill10 = c.String(maxLength: 20),
                        SkillPoint10 = c.Int(nullable: false),
                        Image = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.PersonalID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personals");
        }
    }
}
