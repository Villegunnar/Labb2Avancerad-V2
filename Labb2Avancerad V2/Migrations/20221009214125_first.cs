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
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
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
                    { 1, "Baby, Tools & Outdoors" },
                    { 2, "Baby, Games & Beauty" },
                    { 3, "Music, Grocery & Computers" },
                    { 4, "Grocery, Computers & Music" },
                    { 5, "Beauty & Automotive" },
                    { 6, "Toys, Grocery & Computers" },
                    { 7, "Industrial" },
                    { 8, "Music, Clothing & Books" },
                    { 9, "Kids & Jewelery" },
                    { 10, "Clothing & Automotive" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 1, "1396 Asa Light, East Kirafort, Norway", 4, "Jefferey.Haley28@hotmail.com", "Nasir", "Female", "Connelly", "(943) 882-6182", 24729m },
                    { 2, "5766 Gleichner Parkway, Lake Ruthland, Sweden", 5, "Jammie9@gmail.com", "Ahmed", "Female", "Wiza", "559-825-9580", 25315m },
                    { 3, "164 Kari Pine, North Nikitaport, Italy", 5, "Myron_Hartmann@gmail.com", "Ansley", "Female", "Kihn", "1-287-935-6544", 19980m },
                    { 4, "574 Mills Avenue, Cyrusbury, United States of America", 2, "Jazlyn.Lueilwitz98@gmail.com", "Maye", "Male", "Murphy", "(673) 417-6603", 27136m },
                    { 5, "6436 Marielle Street, Crooksfurt, French Guiana", 4, "Tina.Heidenreich73@hotmail.com", "Thurman", "Male", "Marquardt", "395-451-7319 x8885", 34084m },
                    { 6, "82855 Amiya Via, Ozellabury, Cocos (Keeling) Islands", 5, "Kayla43@gmail.com", "Mia", "Male", "Hansen", "1-401-933-4464 x83491", 31535m },
                    { 7, "603 Wolff Glens, Ortizborough, Cook Islands", 1, "Gavin.Spencer72@hotmail.com", "Nedra", "Male", "Kutch", "1-949-379-4848 x79356", 19277m },
                    { 8, "40691 Upton Mountain, Jaskolskiton, Sudan", 5, "Barton42@yahoo.com", "Vesta", "Male", "Zulauf", "979.663.7234 x5967", 30442m },
                    { 9, "87455 Collier Camp, Willmstown, Guyana", 4, "Brenden_Schowalter@yahoo.com", "Lawson", "Male", "Luettgen", "315.841.2998 x3350", 23352m },
                    { 10, "70280 Towne Crest, Janaeborough, Hong Kong", 3, "Rubie_Waelchi36@gmail.com", "Henry", "Male", "Carter", "(959) 545-7463 x068", 30465m },
                    { 11, "166 Schumm Haven, Chesleyburgh, Mauritania", 3, "Fidel.Klein@gmail.com", "Loma", "Female", "Streich", "908.309.0928 x80339", 34791m },
                    { 12, "5414 Hartmann Knoll, Rippinshire, Costa Rica", 3, "Hadley93@hotmail.com", "Bertram", "Male", "Bernier", "(529) 583-6344", 29988m },
                    { 13, "50793 Una Gardens, Cronamouth, Tanzania", 3, "Colin.Reilly81@gmail.com", "Edythe", "Female", "Mann", "(410) 343-7888 x53376", 20955m },
                    { 14, "8184 Cordelia Ranch, Port Janelle, Hong Kong", 3, "Adele_Labadie@yahoo.com", "Bonita", "Female", "Feest", "(638) 381-7657", 19103m },
                    { 15, "1213 Durgan Walks, New Mathiasbury, Cameroon", 1, "Terrill.Torphy@yahoo.com", "Zoe", "Male", "Friesen", "585-321-3530", 26400m },
                    { 16, "413 Ophelia Stravenue, Pattieberg, Tokelau", 5, "Donny.Okuneva54@yahoo.com", "Aubree", "Female", "Bernhard", "(630) 984-6922 x77425", 34044m },
                    { 17, "3809 Goldner Loaf, Prestonmouth, Hong Kong", 1, "Citlalli67@yahoo.com", "Juwan", "Male", "Abshire", "(716) 219-5219 x45214", 27680m },
                    { 18, "09660 Wisozk Hill, Zakaryborough, New Zealand", 1, "Alexzander_Turner13@yahoo.com", "Rene", "Female", "Bernhard", "756-701-8732", 21626m },
                    { 19, "3429 Leannon Branch, Esmeraldaville, Bosnia and Herzegovina", 3, "Odell_Hayes@hotmail.com", "Armand", "Female", "Pouros", "(884) 261-8429", 17912m },
                    { 20, "42795 Christa Trace, Tremaynetown, Hong Kong", 2, "Trace.Sporer@gmail.com", "Diana", "Male", "Krajcik", "373-534-2771 x818", 30036m },
                    { 21, "6847 Bert Corners, Romagueraburgh, Falkland Islands (Malvinas)", 1, "Jay_Larkin56@yahoo.com", "Eric", "Female", "Ferry", "(384) 765-1115", 33108m },
                    { 22, "75712 Clint Lane, Breitenbergland, Burkina Faso", 1, "Jonathan89@hotmail.com", "Mathilde", "Female", "Keeling", "369-648-6412 x07063", 26671m },
                    { 23, "147 Torp Corners, Kulasside, Cocos (Keeling) Islands", 5, "Ted6@yahoo.com", "Craig", "Male", "Okuneva", "699.864.7872 x48957", 18851m },
                    { 24, "1864 Astrid Roads, West Abel, Somalia", 1, "Michelle_Zulauf@hotmail.com", "Shaniya", "Male", "Sawayn", "1-716-484-9900", 33274m },
                    { 25, "5840 Santa Ramp, Dagmarfurt, Maldives", 2, "Ericka95@yahoo.com", "Chadd", "Female", "Dickens", "(565) 570-7489 x708", 20311m },
                    { 26, "865 Jeff Centers, Rodgerchester, Senegal", 2, "Nickolas54@hotmail.com", "Kelly", "Male", "Harvey", "(580) 473-8918 x45591", 32775m },
                    { 27, "155 Edyth Cove, New Forrestville, Ireland", 1, "Paige_Feil52@yahoo.com", "Maia", "Male", "Hodkiewicz", "946.539.0131 x87009", 25125m },
                    { 28, "440 Dasia Summit, North Fernandoport, Saint Martin", 4, "Arno.Pfeffer@gmail.com", "Mohammad", "Female", "Turner", "703-601-6762 x94431", 20833m },
                    { 29, "564 Bernard Station, South Colin, Central African Republic", 5, "Davion.Feest40@hotmail.com", "Joaquin", "Female", "Cummings", "615-902-6107", 21966m },
                    { 30, "49649 Hane Underpass, North Oren, South Georgia and the South Sandwich Islands", 1, "Fiona_Fisher@hotmail.com", "Sophia", "Male", "McClure", "1-687-651-4536 x41134", 31789m },
                    { 31, "283 Schaden Way, Madisonchester, Seychelles", 5, "Jack4@hotmail.com", "Andreanne", "Female", "Runolfsdottir", "402-851-3220 x9856", 21710m },
                    { 32, "395 Lafayette Mission, Izaiahfort, Mauritania", 4, "Jane_Hirthe@gmail.com", "Damien", "Female", "Predovic", "944-953-9203", 27974m },
                    { 33, "2810 Strosin Shore, East Elmiramouth, Falkland Islands (Malvinas)", 2, "Grayson.Wiza@gmail.com", "Alvera", "Female", "Hand", "743.803.1940", 33231m },
                    { 34, "446 Madalyn Courts, Roslynchester, Antarctica (the territory South of 60 deg S)", 2, "Zackery49@hotmail.com", "Claudia", "Female", "Stiedemann", "1-644-435-9672 x673", 19737m },
                    { 35, "6932 Hand Locks, New Dallas, Suriname", 2, "Sonya43@yahoo.com", "Leonor", "Male", "Bednar", "332-965-0168 x49055", 22245m },
                    { 36, "5382 Josiah Island, North Newell, Democratic People's Republic of Korea", 4, "Matt_Prohaska60@hotmail.com", "Benton", "Male", "Abshire", "790.590.8133 x720", 28102m },
                    { 37, "4633 Braeden Trail, Padbergshire, Anguilla", 1, "Delbert.Brown@gmail.com", "Deangelo", "Male", "Stiedemann", "(551) 662-4404 x853", 33171m },
                    { 38, "1867 Kunze Rest, Port Durward, Uruguay", 4, "Kathryne_Friesen16@yahoo.com", "Lyda", "Female", "Prosacco", "557-489-7738", 30980m },
                    { 39, "23696 Wisozk Islands, West Oren, Nepal", 5, "Vernon_Ortiz3@yahoo.com", "Ari", "Female", "McGlynn", "1-486-495-6159", 22283m },
                    { 40, "84173 Schultz Brooks, New Idell, Sri Lanka", 4, "Adele_Kozey@gmail.com", "Brando", "Male", "Streich", "914-872-7044", 32160m },
                    { 41, "2318 Travis Expressway, Keeblerfort, Norfolk Island", 1, "Garth89@gmail.com", "Libby", "Male", "Terry", "(530) 474-1852 x20722", 26455m },
                    { 42, "9480 Legros Point, Port Viva, Botswana", 2, "Shaniya26@yahoo.com", "Caitlyn", "Female", "Hilpert", "1-926-422-7711 x290", 31880m },
                    { 43, "43104 Demarcus Dale, Ricardoshire, United Arab Emirates", 2, "Bernice97@gmail.com", "Gudrun", "Female", "Stanton", "990.500.9846 x254", 23605m },
                    { 44, "33182 Dillan Falls, East Karliville, Lithuania", 3, "Drew80@gmail.com", "Stacey", "Male", "Bode", "951.285.1686", 33261m },
                    { 45, "67595 Kessler Ford, Port Erna, Wallis and Futuna", 1, "Julia.Deckow22@hotmail.com", "Harrison", "Male", "Nienow", "1-473-522-9392 x131", 26566m },
                    { 46, "03438 Nyasia Pass, Guidofurt, Senegal", 4, "Leatha.Kshlerin97@hotmail.com", "Rae", "Female", "Schiller", "(973) 676-7447 x176", 21188m },
                    { 47, "67858 Kemmer Estate, Naderside, Sao Tome and Principe", 2, "Koby_Brakus8@yahoo.com", "Vivian", "Female", "Bergstrom", "(749) 640-0866", 25009m },
                    { 48, "2257 Bergnaum Trace, Alishaborough, Azerbaijan", 1, "Tristian_Wisoky@yahoo.com", "Donna", "Male", "Greenholt", "1-642-312-2592 x942", 21223m },
                    { 49, "910 Karen Spring, Estellborough, Haiti", 4, "Imogene_Ryan33@yahoo.com", "Steve", "Female", "Mohr", "954-596-5881 x7675", 30620m },
                    { 50, "117 Devin Knolls, Port Mariane, Swaziland", 2, "Brice.Dicki@gmail.com", "Gerard", "Male", "Gusikowski", "647.972.2858 x7424", 21534m }
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
