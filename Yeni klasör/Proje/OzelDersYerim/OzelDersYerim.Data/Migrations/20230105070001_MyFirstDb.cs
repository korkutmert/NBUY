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
                name: "StudentTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
