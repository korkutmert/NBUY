using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OzelDersYerim.Data.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BranchName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Age = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Experince = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerHour = table.Column<decimal>(type: "TEXT", nullable: true),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Age = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: true),
                    Experince = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    PricePerHour = table.Column<decimal>(type: "TEXT", nullable: true),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "StudentTeachers",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5aa42dea-90ce-4342-b3d4-a34d9483e736", null, "Admin rolü", "Admin", "ADMIN" },
                    { "5e983d61-be70-494a-9077-f78bf14aaf3e", null, "Student rolü", "Student", "STUDENT" },
                    { "9388f291-fa5d-4666-81fd-f07c4f3c04f2", null, "Teacher rolü", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "BranchName", "ImageUrl", "Url" },
                values: new object[,]
                {
                    { 1, "Matematik", "mat.png", "matematik" },
                    { 2, "Kimya", "kimya.png", "kimya" },
                    { 3, "İngilizce", "ing.png", "ingilizce" },
                    { 4, "Müzik", "müzik.png", "muzik" },
                    { 5, "Türkçe", "turkce.png", "turkce" },
                    { 6, "Bilgisayar", "bilgisayar.png", "bilgisayar" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "Age", "FirstName", "ImageUrl", "LastName", "Url" },
                values: new object[,]
                {
                    { 1, "24 Yaşındayım.Yazılım eğitimi alıyorum.Yeni programlama dilleri üzerinde kendimi geliştirmek ve ders almak istiyorum.", "24", "Mert Korkut", "1.png", "Muslu", "ogrenci-mert-korkut-muslu" },
                    { 2, "24 Yaşındayım.Elektirk-elektronik mühendisiyim ancak şu sıralar yazılım eğitimi alıyorum.Kendimi bu alanda geliştirmek istiyorum.", "28", "Cemre ", "2.png", "Şenel", "ogrenci-cemre-senel" },
                    { 3, "Kendimi her alanda gelişime açık hissediyorum. Back-end developer alanında çalışmak istediğim içinde özellikle bu alanda kendime birşeyler katmak istiyorum.", "23", "Harun ", "3.png", "Özer", "ogrenci-harun-ozer" },
                    { 4, "Yeni mezun bir sağlıkçı olarak Kpss sınavlarına hazırlanmak için matematik dersleri almak istiyorum.", "20", "Senem", "4.png", "Öztürk", "ogrenci-senem-ozturk" },
                    { 5, "Matematik derslerinde çok zorlanıyorum.", "14", "Zeynep", "5.png", "Aslan", "ogrenci-zeynep-aslan" },
                    { 6, "Merhaba.Herhangi bir müzik aleti çalmayı öğrenmek için buradayım !.", "22", "Kemal Emre", "6.png", "Erol", "ogrenci-kemal-emre-erol" },
                    { 7, "Lise öğrencisiyim.Üniversite sınavları için Kimya dersleri almak istiyorum.", "17", "Aslı", "7.png", "Yıldız", "ogrenci-asli-yildiz" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Age", "BranchId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Experince", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PricePerHour", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { "3e07e45d-525c-4921-aa77-1fec52174254", "İngilizce Öğretmeniyim. Her türlü İngilizce sınavlarına hazırlık konusunda ders vermekteyim.", 0, "27", 3, "f4085d21-725f-4e9b-97e0-ae686c8cc4c6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "5", "Arzu", "Kadın", "11.png", "Doğramacı", "Şişli", false, null, null, null, null, "05550005501", null, false, 300m, "8936dba1-3fb5-4a10-a018-edd7f73bdf6e", false, "ogretmen-arzu-dogramaci", null },
                    { "6ed224a5-9bac-4d41-8e55-27012b310ad0", "Mimar Sinan Güzel Sanatlar Üniversitesi Konservatuar mezunuyum. Uzmanlık alanım Piyano olamakla beraber keman ve gitar dersleri de vermekteyim.", 0, "39", 4, "ddae22fe-a25e-4e17-9cd8-ae62cc87e081", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "15", "Ahmet", "Erkek", "10.png", "Yılmaz", "Beşiktaş", false, null, null, null, null, "05550005500", null, false, 450m, "ef741240-8d67-496c-9d7d-b5c5312178ca", false, "ogretmen-ahmet-yilmaz", null },
                    { "788a925d-56bc-48b6-802e-04d4ad06a3ec", "İlköğretim-lise düzeyinde matematik dersleri verilir. Sınavlar için fazladan etüt alabilirsiniz.", 0, "42", 1, "2115301b-5406-4f4e-9946-f50fc6db5c52", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "", "Serdar", "Erkek", "12.png", "Kulbilge", "Aksaray", false, null, null, null, null, "05550005502", null, false, 250m, "d810fc1d-510c-4ccc-9a6f-8588f1edc7f7", false, "ogretmen-serdar-kulbilge", null },
                    { "e6c62ebe-8830-492c-84e4-f24a2e1d00d1", "Boğaziçi Üniversitesi Mezunuyum. 28 yaşındayım. Özel bir lisede Kimya Öğretmenliği yapıyorum.", 0, "28", 2, "1293753d-ff60-49a8-a9ad-90c482839cac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "6", "Hande", "Kadın", "13.png", "Yıldırım", "Etiler", false, null, null, null, null, "05550005503", null, false, 300m, "d343fbec-e15b-444c-958c-3b08a3316359", false, "ogretmen-hande-yildirim", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "BranchId", "Experince", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "Phone", "PricePerHour", "Url" },
                values: new object[,]
                {
                    { 1, "Mimar Sinan Güzel Sanatlar Üniversitesi Konservatuar mezunuyum. Uzmanlık alanım Piyano olamakla beraber keman ve gitar dersleri de vermekteyim.", "39", 4, "15", "Ahmet", "Erkek", "10.png", "Yılmaz", "Beşiktaş", "05550005500", 450m, "ogretmen-ahmet-yilmaz" },
                    { 2, "İngilizce Öğretmeniyim. Her türlü İngilizce sınavlarına hazırlık konusunda ders vermekteyim.", "27", 3, "5", "Arzu", "Kadın", "11.png", "Doğramacı", "Şişli", "05550005501", 300m, "ogretmen-arzu-dogramaci" },
                    { 3, "İlköğretim-lise düzeyinde matematik dersleri verilir. Sınavlar için fazladan etüt alabilirsiniz.", "42", 1, "", "Serdar", "Erkek", "12.png", "Kulbilge", "Aksaray", "05550005502", 250m, "ogretmen-serdar-kulbilge" },
                    { 4, "Boğaziçi Üniversitesi Mezunuyum. 28 yaşındayım. Özel bir lisede Kimya Öğretmenliği yapıyorum.", "28", 2, "6", "Hande", "Kadın", "13.png", "Yıldırım", "Etiler", "05550005503", 300m, "ogretmen-hande-yildirim" },
                    { 5, "Samsun 19 Mayıs Universitesi Matematik Bölümü mezunuyum. Aynı zamanda Elektro Gitar dersleri vermekteyim.", "30", 4, "7", "Burak", "Erkek", "14.png", "Yılmaz", "Mecidiyeköy", "05550005504", 400m, "ogretmen-burak-yilmaz" },
                    { 6, "Türk Dili Ve Edebiyatı, Türkçe, Dil Anlatım gibi dersler uzmanlık alanım olup, her türlü sınav için ders veriyorum.", "29", 5, "7", "Hasan Can", "Erkek", "15.png", "Güzel", "Beşiktaş", "05550005505", 200m, "ogretmen-hasan-can-guzel" },
                    { 7, "Back-End ve Front-End development konularında A'dan Z'ye eğitim vermekteyim. Sektörde Senior Developer olarak çalıştım.", "42", 6, "21", "Hakkı ", "Erkek", "16.png", "Sarıca", "Esenler", "05550005505", 700m, "ogretmen-hakki-sarica" }
                });

            migrationBuilder.InsertData(
                table: "StudentTeachers",
                columns: new[] { "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 1 },
                    { 7, 2 },
                    { 7, 7 }
                });

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
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherId",
                table: "StudentTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchId",
                table: "Teachers",
                column: "BranchId");
        }

        /// <inheritdoc />
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
                name: "StudentTeachers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
