using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb2AvanceradV2.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Garden & Movies" },
                    { 2, "Games & Books" },
                    { 3, "Movies & Baby" },
                    { 4, "Electronics & Health" },
                    { 5, "Toys & Kids" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 1, "2802 Bechtelar Course, New Zelma, Micronesia", 4, "Joshuah_Braun71@yahoo.com", "Brayan", "Male", "Wilkinson", "(854) 219-3849 x523", 4056.1700000000001 },
                    { 2, "3609 Strosin Causeway, Darleneburgh, Haiti", 4, "Alek_Gorczany@hotmail.com", "Kathryn", "Male", "Nicolas", "(723) 735-4526 x8221", 2788.9099999999999 },
                    { 3, "580 Ollie Mount, Trompton, Comoros", 4, "Chelsea6@gmail.com", "Kayden", "Female", "Feest", "607.976.3843 x50701", 6489.6400000000003 },
                    { 4, "611 Sauer Estates, New Greggfurt, Austria", 3, "Haylee71@hotmail.com", "Rudy", "Female", "Ernser", "983.739.9362", 8122.6700000000001 },
                    { 5, "4996 Kutch Squares, Pfeffermouth, Mali", 2, "Howell40@gmail.com", "Jennyfer", "Male", "Turner", "395-557-1271 x08593", 2791.1199999999999 },
                    { 6, "30496 Emiliano Stream, North Karliemouth, Kenya", 4, "Anderson.Spinka@hotmail.com", "Hermina", "Male", "Donnelly", "986-997-0308", 791.20000000000005 },
                    { 7, "8737 Deangelo Path, Ladariusville, Palestinian Territory", 4, "Dortha.Hahn@hotmail.com", "Alexander", "Male", "Robel", "447.800.7207 x47209", 5049.6800000000003 },
                    { 8, "5001 Marlen Causeway, Schroedershire, Western Sahara", 3, "Raoul13@gmail.com", "Sophie", "Female", "Wiegand", "873-977-8918 x44357", 6790.6700000000001 },
                    { 9, "8269 Harris Viaduct, Danielview, Palestinian Territory", 5, "Ashly.Beier90@hotmail.com", "Wilfredo", "Male", "Thiel", "248-270-0865", 391.50999999999999 },
                    { 10, "624 Cole Ways, Dylanberg, Venezuela", 4, "Conner70@gmail.com", "Javier", "Female", "Powlowski", "1-455-245-7506", 3529.0500000000002 },
                    { 11, "49597 Hyatt Way, West Trevion, Austria", 2, "Shad.Homenick21@hotmail.com", "Taurean", "Male", "Wisoky", "1-565-573-4052", 4911.1099999999997 },
                    { 12, "71772 Rahul Mount, Maidafurt, British Indian Ocean Territory (Chagos Archipelago)", 3, "Ernesto43@gmail.com", "Prudence", "Female", "Lakin", "719.645.3968", 1058.7 },
                    { 13, "87241 Mraz Viaduct, Strosintown, United States Minor Outlying Islands", 2, "Kiel5@gmail.com", "Zachery", "Female", "Zulauf", "(885) 839-2040", 327.91000000000003 },
                    { 14, "533 Selina Vista, Port Annalise, Nigeria", 4, "Alexandrea61@yahoo.com", "Liam", "Male", "Brekke", "817-824-4723 x4744", 7917.5100000000002 },
                    { 15, "350 MacGyver Divide, South Maeland, Syrian Arab Republic", 5, "Otilia.King@yahoo.com", "Steve", "Male", "Wilkinson", "1-617-453-5934", 8841.6299999999992 },
                    { 16, "710 Herman Dam, Lindberg, Libyan Arab Jamahiriya", 5, "Flavie.Cole@yahoo.com", "Noel", "Female", "Torphy", "404.864.2781 x1927", 4498.9700000000003 },
                    { 17, "28529 Christopher Valleys, South Myles, Mauritius", 5, "Ebba.Altenwerth@yahoo.com", "Jadyn", "Female", "Runolfsdottir", "935.662.6618 x90308", 2502.5500000000002 },
                    { 18, "79275 Cecil Ports, Port Chet, Romania", 2, "Ashton_Frami@hotmail.com", "Makenzie", "Female", "Mayert", "588.385.8041 x96634", 4140.2399999999998 },
                    { 19, "43690 Kamren Square, Enochside, Faroe Islands", 5, "Lauryn.Greenfelder@yahoo.com", "Kiara", "Male", "O'Keefe", "642-360-2659", 8846.2199999999993 },
                    { 20, "81744 Graham Station, Walterborough, Canada", 1, "Garrick_Nolan87@gmail.com", "Nikko", "Male", "Leuschke", "(368) 501-4994 x862", 5296.6700000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
