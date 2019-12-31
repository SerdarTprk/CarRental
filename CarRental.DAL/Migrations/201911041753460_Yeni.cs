namespace CarRental.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yeni : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BrandName = c.String(maxLength: 25),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedUser = c.Guid(nullable: false),
                        UpdatedUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ModelName = c.String(nullable: false, maxLength: 25),
                        ModelYear = c.DateTime(storeType: "date"),
                        BrandId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedUser = c.Guid(nullable: false),
                        UpdatedUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DailyPrice = c.String(nullable: false, maxLength: 9, unicode: false),
                        InsuranceExpiryDate = c.DateTime(nullable: false, storeType: "date"),
                        InspectionExpiryDate = c.DateTime(nullable: false, storeType: "date"),
                        FuelType = c.Int(nullable: false),
                        CarClassEnum = c.Int(nullable: false),
                        Plate = c.String(nullable: false, maxLength: 11),
                        CylindeerVolume = c.String(),
                        EngineCapacity = c.String(),
                        CarColorEnum = c.Int(nullable: false),
                        DriverLicenceType = c.Int(nullable: false),
                        DateOfPurchase = c.DateTime(nullable: false, storeType: "date"),
                        IsRented = c.Boolean(nullable: false),
                        ModelId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedUser = c.Guid(nullable: false),
                        UpdatedUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.ModelId)
                .Index(t => t.ModelId);
            
            CreateTable(
                "dbo.RentedCars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CarId = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        DeliveredDate = c.DateTime(nullable: false, storeType: "date"),
                        RentEndDate = c.DateTime(nullable: false),
                        RentCanceled = c.Boolean(nullable: false),
                        Description = c.String(maxLength: 120, unicode: false),
                        RentStartDate = c.DateTime(nullable: false),
                        TankBefore = c.Int(nullable: false),
                        TankAfter = c.Int(nullable: false),
                        OdoMeterBefore = c.Int(nullable: false),
                        OdoMeterAfter = c.Int(nullable: false),
                        LessorUser = c.Int(),
                        DailyPrice = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedUser = c.Guid(nullable: false),
                        UpdatedUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .Index(t => t.CarId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Phone = c.String(),
                        Adress = c.String(nullable: false, maxLength: 200, unicode: false),
                        E_mail = c.String(nullable: false, maxLength: 50, unicode: false),
                        DriverLicenceType = c.Int(nullable: false),
                        TcNo = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedUser = c.Guid(nullable: false),
                        UpdatedUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleUser",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoleUser", "UserId", "dbo.Users");
            DropForeignKey("dbo.RoleUser", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.RentedCars", "CarId", "dbo.Cars");
            DropForeignKey("dbo.RentedCars", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Cars", "ModelId", "dbo.Models");
            DropIndex("dbo.RoleUser", new[] { "UserId" });
            DropIndex("dbo.RoleUser", new[] { "RoleId" });
            DropIndex("dbo.RentedCars", new[] { "CustomerId" });
            DropIndex("dbo.RentedCars", new[] { "CarId" });
            DropIndex("dbo.Cars", new[] { "ModelId" });
            DropIndex("dbo.Models", new[] { "BrandId" });
            DropTable("dbo.RoleUser");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Customers");
            DropTable("dbo.RentedCars");
            DropTable("dbo.Cars");
            DropTable("dbo.Models");
            DropTable("dbo.Brands");
        }
    }
}
