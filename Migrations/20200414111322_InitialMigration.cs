using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERPCore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address1 = table.Column<string>(maxLength: 100, nullable: false),
                    Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    State = table.Column<string>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Zip = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDepartment", x => new { x.EmployeeId, x.DepartmentId });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DateOfJoining = table.Column<DateTime>(nullable: false),
                    EmployeeDepartmentDepartmentId = table.Column<int>(nullable: true),
                    EmployeeDepartmentEmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeDepartment_EmployeeDepartmentEmployeeId_EmployeeDepartmentDepartmentId",
                        columns: x => new { x.EmployeeDepartmentEmployeeId, x.EmployeeDepartmentDepartmentId },
                        principalTable: "EmployeeDepartment",
                        principalColumns: new[] { "EmployeeId", "DepartmentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    EmployeeDepartmentDepartmentId = table.Column<int>(nullable: true),
                    EmployeeDepartmentEmployeeId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_EmployeeDepartment_EmployeeDepartmentEmployeeId_EmployeeDepartmentDepartmentId",
                        columns: x => new { x.EmployeeDepartmentEmployeeId, x.EmployeeDepartmentDepartmentId },
                        principalTable: "EmployeeDepartment",
                        principalColumns: new[] { "EmployeeId", "DepartmentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 10, "Tokyo", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 1, "London", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 2, "San Francisco", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 3, "London", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 4, "San Francisco", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 5, "New York", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 6, "London", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 7, "New York", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 8, "New York", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "City", "State", "Zip" },
                values: new object[] { 9, "Edinburgh", null, "unknown", "unkown", "123456" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed62d93e-d0d9-43d1-89e1-20458b5786c5", "a6b70544-4a65-43b2-8777-14ce1463346f", "superadmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df7239b0-b6b8-4200-bc71-e318335b8043", "3999a880-a3ae-43fc-84e0-7a59fb24e67f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2fe4ab61-3cd9-4ea2-a7d6-86ffe248e4a5", "6f29e2d1-2949-4f33-9872-063955190a1b", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a95902e5-9d6f-4853-a130-46d2da927c59", 0, "8d40ebed-9c8f-4d9e-98fd-2a188f305b2d", "superadmin@site.co", true, false, null, "superadmin@site.co", "SuperAdmin", "AQAAAAEAACcQAAAAEFr6/6nXMcUE1fTG9VofTHq901MdZx1qrfIXa4rJR42VSI8/n3dQ5U/GWPvn2tMkpw==", null, false, "", false, "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b425f26-2999-4fcd-ab6e-a179a3ff6470", 0, "6fce8b35-54b0-4a68-9a11-cf6d822943e2", "admin@site.co", true, false, null, "admin@site.co", "Admin", "AQAAAAEAACcQAAAAEC3vZLOYWa/CXODW05mAQRaVIP6Jfnru3qgZWN6X+xSDDQsUrelo0Z9925QX7TI0yA==", null, false, "", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "EmployeeId", "Name" },
                values: new object[] { 5, null, null, null, "IT" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "EmployeeId", "Name" },
                values: new object[] { 6, null, null, null, "Management" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "EmployeeId", "Name" },
                values: new object[] { 2, null, null, null, "HR" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "EmployeeId", "Name" },
                values: new object[] { 3, null, null, null, "Testing" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "EmployeeId", "Name" },
                values: new object[] { 4, null, null, null, "Training" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "EmployeeId", "Name" },
                values: new object[] { 1, null, null, null, "Development" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7b425f26-2999-4fcd-ab6e-a179a3ff6470", "df7239b0-b6b8-4200-bc71-e318335b8043" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a95902e5-9d6f-4853-a130-46d2da927c59", "ed62d93e-d0d9-43d1-89e1-20458b5786c5" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 1, 10, 33, new DateTime(2008, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Airi.Satou@site.com", null, null, "Airi", 1, "Satou" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 2, 1, 42, new DateTime(2009, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angelica.Ramos@site.com", null, null, "Angelica", 1, "Ramos" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 3, 2, 66, new DateTime(2009, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashton.Cox@site.com", null, null, "Ashton", 1, "Cox" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 4, 3, 41, new DateTime(2012, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley.Greer@site.com", null, null, "Bradley", 0, "Greer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 5, 4, 28, new DateTime(2011, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brenden.Wagner@site.com", null, null, "Brenden", 0, "Wagner" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 6, 5, 61, new DateTime(2012, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brielle.Williamson@site.com", null, null, "Brielle", 1, "Williamson" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 7, 6, 38, new DateTime(2011, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruno.Nash@site.com", null, null, "Bruno", 0, "Nash" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 8, 7, 21, new DateTime(2011, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caesar.Vance@site.com", null, null, "Caesar", 0, "Vance" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 9, 8, 46, new DateTime(2011, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cara.Stevens@site.com", null, null, "Cara", 1, "Stevens" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "Age", "DateOfJoining", "Email", "EmployeeDepartmentDepartmentId", "EmployeeDepartmentEmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[] { 10, 9, 22, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cedric.Kelly@site.com", null, null, "Cedric", 1, "Kelly" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeDepartmentEmployeeId_EmployeeDepartmentDepartmentId",
                table: "Departments",
                columns: new[] { "EmployeeDepartmentEmployeeId", "EmployeeDepartmentDepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressId",
                table: "Employees",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeDepartmentEmployeeId_EmployeeDepartmentDepartmentId",
                table: "Employees",
                columns: new[] { "EmployeeDepartmentEmployeeId", "EmployeeDepartmentDepartmentId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "EmployeeDepartment");
        }
    }
}
