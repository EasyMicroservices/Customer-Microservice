using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMicroservices.CustomerMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderType = table.Column<byte>(type: "tinyint", nullable: true),
                    NationalityType = table.Column<int>(type: "int", nullable: true),
                    MaritalStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    RoleOnSiteType = table.Column<byte>(type: "tinyint", nullable: true),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalServiceIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    ProvinceId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_PersonCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "PersonCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certifications_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    CountryShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolderNationalityType = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passports_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonRelations",
                columns: table => new
                {
                    FromPersonId = table.Column<long>(type: "bigint", nullable: false),
                    ToPersonId = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonRelations", x => new { x.FromPersonId, x.ToPersonId });
                    table.ForeignKey(
                        name: "FK_PersonRelations_Persons_FromPersonId",
                        column: x => x.FromPersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonRelations_Persons_ToPersonId",
                        column: x => x.ToPersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberType = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExitDate = table.Column<DateTime>(type: "date", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visas_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CreationDateTime",
                table: "Addresses",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DeletedDateTime",
                table: "Addresses",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_IsDeleted",
                table: "Addresses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ModificationDateTime",
                table: "Addresses",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UniqueIdentity",
                table: "Addresses",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_CreationDateTime",
                table: "Certifications",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_DeletedDateTime",
                table: "Certifications",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_IsDeleted",
                table: "Certifications",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_ModificationDateTime",
                table: "Certifications",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_PersonId",
                table: "Certifications",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_UniqueIdentity",
                table: "Certifications",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_CreationDateTime",
                table: "Emails",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_DeletedDateTime",
                table: "Emails",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_IsDeleted",
                table: "Emails",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ModificationDateTime",
                table: "Emails",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_PersonId",
                table: "Emails",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UniqueIdentity",
                table: "Emails",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Links_CreationDateTime",
                table: "Links",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Links_DeletedDateTime",
                table: "Links",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Links_IsDeleted",
                table: "Links",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ModificationDateTime",
                table: "Links",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonId",
                table: "Links",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_UniqueIdentity",
                table: "Links",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_CreationDateTime",
                table: "Passports",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_DeletedDateTime",
                table: "Passports",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_IsDeleted",
                table: "Passports",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_ModificationDateTime",
                table: "Passports",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_PersonId",
                table: "Passports",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_UniqueIdentity",
                table: "Passports",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCategories_CreationDateTime",
                table: "PersonCategories",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCategories_DeletedDateTime",
                table: "PersonCategories",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCategories_IsDeleted",
                table: "PersonCategories",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCategories_ModificationDateTime",
                table: "PersonCategories",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCategories_UniqueIdentity",
                table: "PersonCategories",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRelations_CreationDateTime",
                table: "PersonRelations",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRelations_DeletedDateTime",
                table: "PersonRelations",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRelations_IsDeleted",
                table: "PersonRelations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRelations_ModificationDateTime",
                table: "PersonRelations",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRelations_ToPersonId",
                table: "PersonRelations",
                column: "ToPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRelations_UniqueIdentity",
                table: "PersonRelations",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CategoryId",
                table: "Persons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CreationDateTime",
                table: "Persons",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DeletedDateTime",
                table: "Persons",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_IsDeleted",
                table: "Persons",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ModificationDateTime",
                table: "Persons",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UniqueIdentity",
                table: "Persons",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CreationDateTime",
                table: "Phones",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_DeletedDateTime",
                table: "Phones",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_IsDeleted",
                table: "Phones",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ModificationDateTime",
                table: "Phones",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_PersonId",
                table: "Phones",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_UniqueIdentity",
                table: "Phones",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_CreationDateTime",
                table: "Visas",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_DeletedDateTime",
                table: "Visas",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_IsDeleted",
                table: "Visas",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_ModificationDateTime",
                table: "Visas",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_PersonId",
                table: "Visas",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_UniqueIdentity",
                table: "Visas",
                column: "UniqueIdentity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "PersonRelations");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Visas");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "PersonCategories");
        }
    }
}
