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
                    { 1, "Jewelery, Clothing & Baby" },
                    { 2, "Sports" },
                    { 3, "Toys" },
                    { 4, "Tools" },
                    { 5, "Computers & Grocery" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 1, "757 Karley Springs, Gutmannhaven, Saint Helena", 1, "Bryon_Dach8@gmail.com", "Justyn", "Male", "Monahan", "1-488-481-9394", 7709.2700000000004 },
                    { 2, "40134 Shany Manors, Joanyshire, Germany", 5, "Hollie85@hotmail.com", "Loyce", "Female", "Hamill", "739.370.1919", 3333.0500000000002 },
                    { 3, "361 Verner Villages, Metzhaven, Cote d'Ivoire", 3, "Asia.Hettinger@hotmail.com", "Timmothy", "Male", "Bergstrom", "205-718-8790 x089", 3916.8499999999999 },
                    { 4, "293 Wyman Glens, Port Unique, Lebanon", 5, "Virgil_Torphy40@yahoo.com", "Javier", "Male", "Jones", "1-202-536-0999 x26574", 9365.3799999999992 },
                    { 5, "20583 Abner Port, South Warren, Macedonia", 1, "Kristofer.Brekke@gmail.com", "Jamil", "Male", "Leannon", "1-902-739-6221 x215", 9874.3799999999992 },
                    { 6, "4897 Christina Well, Hesselburgh, Monaco", 4, "Bulah39@gmail.com", "Aniya", "Female", "Dickens", "(718) 750-6800", 5686.2299999999996 },
                    { 7, "44571 Kovacek Mountain, New Vena, Pakistan", 2, "Ruben_Beahan12@yahoo.com", "Rebekah", "Male", "Kulas", "743-571-8792 x52356", 9442.5499999999993 },
                    { 8, "01806 Rippin Forges, Emmerichfort, Ukraine", 2, "Branson93@hotmail.com", "Claud", "Female", "Rolfson", "(357) 426-1157 x4329", 8128.0200000000004 },
                    { 9, "852 Nels Skyway, O'Reillymouth, Zambia", 2, "Haleigh.Zboncak@hotmail.com", "Lilly", "Male", "Mayert", "1-287-836-2209 x8720", 7352.1400000000003 },
                    { 10, "610 Melody Vista, Jodyfort, South Georgia and the South Sandwich Islands", 3, "Lora51@gmail.com", "Marcos", "Female", "Windler", "(953) 486-2780", 3069.04 },
                    { 11, "26801 Frami Forks, Aiyanaton, Papua New Guinea", 1, "Rhianna45@hotmail.com", "Dulce", "Female", "Lowe", "453.545.4683 x26433", 6773.9200000000001 },
                    { 12, "2550 Bayer Ramp, North Kelton, Ukraine", 2, "Lamar_Aufderhar@yahoo.com", "Johanna", "Female", "Cole", "1-995-468-0256", 4572.1199999999999 },
                    { 13, "7824 Lafayette Park, Oberbrunnerview, Virgin Islands, British", 2, "Brandy.Sporer@yahoo.com", "Lee", "Male", "Conroy", "(536) 421-0579 x3740", 9442.2900000000009 },
                    { 14, "456 West Bypass, South Jaime, Cocos (Keeling) Islands", 3, "Jaylin.Rodriguez@gmail.com", "Cassandre", "Male", "King", "(239) 637-7156 x44743", 8753.9899999999998 },
                    { 15, "676 Marks Meadow, South Malachi, Bouvet Island (Bouvetoya)", 3, "Dallas.Labadie@gmail.com", "Daphney", "Female", "O'Hara", "1-375-714-4701 x3845", 6880.3599999999997 },
                    { 16, "8839 Koch Mountain, South Calebchester, Somalia", 1, "Crawford.Koch@yahoo.com", "Bartholome", "Male", "Breitenberg", "(314) 648-6243 x41451", 6056.9899999999998 },
                    { 17, "21857 Hane Manors, Fayfurt, Holy See (Vatican City State)", 1, "Alanis_Bergstrom@hotmail.com", "Christelle", "Female", "Wilkinson", "(398) 830-1723 x6790", 1588.4200000000001 },
                    { 18, "60704 Orn Knolls, Macejkovicport, Antarctica (the territory South of 60 deg S)", 5, "Laurianne_Funk2@yahoo.com", "Dorothea", "Female", "Gusikowski", "1-664-885-9052 x70420", 1198.5 },
                    { 19, "1993 Williamson Stream, North Marysefurt, Puerto Rico", 5, "Carmella67@gmail.com", "Okey", "Female", "Nolan", "621.935.6362 x4168", 3538.9200000000001 },
                    { 20, "19090 Kris Spurs, South Adela, Gambia", 4, "Stone_Bosco@hotmail.com", "Elmira", "Female", "Bradtke", "630.701.5363 x44744", 7198.5900000000001 }
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
