namespace SMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        AttendanceDate = c.DateTime(nullable: false),
                        IsAttend = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 15),
                        Lastname = c.String(nullable: false, maxLength: 20),
                        FatherName = c.String(nullable: false, maxLength: 15),
                        Username = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 10),
                        BornDate = c.DateTime(nullable: false),
                        ContactNo = c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false),
                        Address = c.String(maxLength: 250),
                        RegDate = c.DateTime(nullable: false),
                        ClassId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(maxLength: 5),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Text = c.String(nullable: false, maxLength: 500),
                        SendingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 15),
                        Lastname = c.String(nullable: false, maxLength: 20),
                        IdentityNo = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Username = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 10),
                        RoleId = c.Int(nullable: false),
                        BornDate = c.DateTime(nullable: false),
                        ContactNo = c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false),
                        Address = c.String(maxLength: 250),
                        Salary = c.Double(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Logging",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(),
                        StudentId = c.Int(),
                        LogDate = c.DateTime(nullable: false),
                        Message = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StaffId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 30),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExamResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamTypesId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        Mark = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExamTypes", t => t.ExamTypesId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.ExamTypesId)
                .Index(t => t.StudentId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.ExamTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentsMessage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Messages", t => t.MessageId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.MessageId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.StaffClasses",
                c => new
                    {
                        StaffId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StaffId, t.ClassId })
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.SubjectClasses",
                c => new
                    {
                        SubjectId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SubjectId, t.ClassId })
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Attendances", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.StudentsMessage", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentsMessage", "MessageId", "dbo.Messages");
            DropForeignKey("dbo.Messages", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Staffs", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.ExamResults", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.ExamResults", "StudentId", "dbo.Students");
            DropForeignKey("dbo.ExamResults", "ExamTypesId", "dbo.ExamTypes");
            DropForeignKey("dbo.SubjectClasses", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.SubjectClasses", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Staffs", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Logging", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Logging", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffClasses", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.StaffClasses", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Messages", "ClassId", "dbo.Classes");
            DropIndex("dbo.SubjectClasses", new[] { "ClassId" });
            DropIndex("dbo.SubjectClasses", new[] { "SubjectId" });
            DropIndex("dbo.StaffClasses", new[] { "ClassId" });
            DropIndex("dbo.StaffClasses", new[] { "StaffId" });
            DropIndex("dbo.StudentsMessage", new[] { "StudentId" });
            DropIndex("dbo.StudentsMessage", new[] { "MessageId" });
            DropIndex("dbo.ExamResults", new[] { "SubjectId" });
            DropIndex("dbo.ExamResults", new[] { "StudentId" });
            DropIndex("dbo.ExamResults", new[] { "ExamTypesId" });
            DropIndex("dbo.Logging", new[] { "StudentId" });
            DropIndex("dbo.Logging", new[] { "StaffId" });
            DropIndex("dbo.Staffs", new[] { "SubjectId" });
            DropIndex("dbo.Staffs", new[] { "RoleId" });
            DropIndex("dbo.Messages", new[] { "ClassId" });
            DropIndex("dbo.Messages", new[] { "StaffId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropIndex("dbo.Attendances", new[] { "SubjectId" });
            DropIndex("dbo.Attendances", new[] { "StudentId" });
            DropTable("dbo.SubjectClasses");
            DropTable("dbo.StaffClasses");
            DropTable("dbo.StudentsMessage");
            DropTable("dbo.ExamTypes");
            DropTable("dbo.ExamResults");
            DropTable("dbo.Subjects");
            DropTable("dbo.Roles");
            DropTable("dbo.Logging");
            DropTable("dbo.Staffs");
            DropTable("dbo.Messages");
            DropTable("dbo.Classes");
            DropTable("dbo.Students");
            DropTable("dbo.Attendances");
        }
    }
}
