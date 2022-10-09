﻿// <auto-generated />
using System;
using Labb2_Avancerad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2AvanceradV2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221009214125_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.1.22426.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb2_Avancerad.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Baby, Tools & Outdoors"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Baby, Games & Beauty"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Music, Grocery & Computers"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Grocery, Computers & Music"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Beauty & Automotive"
                        },
                        new
                        {
                            DepartmentId = 6,
                            DepartmentName = "Toys, Grocery & Computers"
                        },
                        new
                        {
                            DepartmentId = 7,
                            DepartmentName = "Industrial"
                        },
                        new
                        {
                            DepartmentId = 8,
                            DepartmentName = "Music, Clothing & Books"
                        },
                        new
                        {
                            DepartmentId = 9,
                            DepartmentName = "Kids & Jewelery"
                        },
                        new
                        {
                            DepartmentId = 10,
                            DepartmentName = "Clothing & Automotive"
                        });
                });

            modelBuilder.Entity("Labb2_Avancerad.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Adress = "1396 Asa Light, East Kirafort, Norway",
                            DepartmentId = 4,
                            Email = "Jefferey.Haley28@hotmail.com",
                            FirstName = "Nasir",
                            Gender = "Female",
                            LastName = "Connelly",
                            PhoneNumber = "(943) 882-6182",
                            Salary = 24729m
                        },
                        new
                        {
                            EmployeeId = 2,
                            Adress = "5766 Gleichner Parkway, Lake Ruthland, Sweden",
                            DepartmentId = 5,
                            Email = "Jammie9@gmail.com",
                            FirstName = "Ahmed",
                            Gender = "Female",
                            LastName = "Wiza",
                            PhoneNumber = "559-825-9580",
                            Salary = 25315m
                        },
                        new
                        {
                            EmployeeId = 3,
                            Adress = "164 Kari Pine, North Nikitaport, Italy",
                            DepartmentId = 5,
                            Email = "Myron_Hartmann@gmail.com",
                            FirstName = "Ansley",
                            Gender = "Female",
                            LastName = "Kihn",
                            PhoneNumber = "1-287-935-6544",
                            Salary = 19980m
                        },
                        new
                        {
                            EmployeeId = 4,
                            Adress = "574 Mills Avenue, Cyrusbury, United States of America",
                            DepartmentId = 2,
                            Email = "Jazlyn.Lueilwitz98@gmail.com",
                            FirstName = "Maye",
                            Gender = "Male",
                            LastName = "Murphy",
                            PhoneNumber = "(673) 417-6603",
                            Salary = 27136m
                        },
                        new
                        {
                            EmployeeId = 5,
                            Adress = "6436 Marielle Street, Crooksfurt, French Guiana",
                            DepartmentId = 4,
                            Email = "Tina.Heidenreich73@hotmail.com",
                            FirstName = "Thurman",
                            Gender = "Male",
                            LastName = "Marquardt",
                            PhoneNumber = "395-451-7319 x8885",
                            Salary = 34084m
                        },
                        new
                        {
                            EmployeeId = 6,
                            Adress = "82855 Amiya Via, Ozellabury, Cocos (Keeling) Islands",
                            DepartmentId = 5,
                            Email = "Kayla43@gmail.com",
                            FirstName = "Mia",
                            Gender = "Male",
                            LastName = "Hansen",
                            PhoneNumber = "1-401-933-4464 x83491",
                            Salary = 31535m
                        },
                        new
                        {
                            EmployeeId = 7,
                            Adress = "603 Wolff Glens, Ortizborough, Cook Islands",
                            DepartmentId = 1,
                            Email = "Gavin.Spencer72@hotmail.com",
                            FirstName = "Nedra",
                            Gender = "Male",
                            LastName = "Kutch",
                            PhoneNumber = "1-949-379-4848 x79356",
                            Salary = 19277m
                        },
                        new
                        {
                            EmployeeId = 8,
                            Adress = "40691 Upton Mountain, Jaskolskiton, Sudan",
                            DepartmentId = 5,
                            Email = "Barton42@yahoo.com",
                            FirstName = "Vesta",
                            Gender = "Male",
                            LastName = "Zulauf",
                            PhoneNumber = "979.663.7234 x5967",
                            Salary = 30442m
                        },
                        new
                        {
                            EmployeeId = 9,
                            Adress = "87455 Collier Camp, Willmstown, Guyana",
                            DepartmentId = 4,
                            Email = "Brenden_Schowalter@yahoo.com",
                            FirstName = "Lawson",
                            Gender = "Male",
                            LastName = "Luettgen",
                            PhoneNumber = "315.841.2998 x3350",
                            Salary = 23352m
                        },
                        new
                        {
                            EmployeeId = 10,
                            Adress = "70280 Towne Crest, Janaeborough, Hong Kong",
                            DepartmentId = 3,
                            Email = "Rubie_Waelchi36@gmail.com",
                            FirstName = "Henry",
                            Gender = "Male",
                            LastName = "Carter",
                            PhoneNumber = "(959) 545-7463 x068",
                            Salary = 30465m
                        },
                        new
                        {
                            EmployeeId = 11,
                            Adress = "166 Schumm Haven, Chesleyburgh, Mauritania",
                            DepartmentId = 3,
                            Email = "Fidel.Klein@gmail.com",
                            FirstName = "Loma",
                            Gender = "Female",
                            LastName = "Streich",
                            PhoneNumber = "908.309.0928 x80339",
                            Salary = 34791m
                        },
                        new
                        {
                            EmployeeId = 12,
                            Adress = "5414 Hartmann Knoll, Rippinshire, Costa Rica",
                            DepartmentId = 3,
                            Email = "Hadley93@hotmail.com",
                            FirstName = "Bertram",
                            Gender = "Male",
                            LastName = "Bernier",
                            PhoneNumber = "(529) 583-6344",
                            Salary = 29988m
                        },
                        new
                        {
                            EmployeeId = 13,
                            Adress = "50793 Una Gardens, Cronamouth, Tanzania",
                            DepartmentId = 3,
                            Email = "Colin.Reilly81@gmail.com",
                            FirstName = "Edythe",
                            Gender = "Female",
                            LastName = "Mann",
                            PhoneNumber = "(410) 343-7888 x53376",
                            Salary = 20955m
                        },
                        new
                        {
                            EmployeeId = 14,
                            Adress = "8184 Cordelia Ranch, Port Janelle, Hong Kong",
                            DepartmentId = 3,
                            Email = "Adele_Labadie@yahoo.com",
                            FirstName = "Bonita",
                            Gender = "Female",
                            LastName = "Feest",
                            PhoneNumber = "(638) 381-7657",
                            Salary = 19103m
                        },
                        new
                        {
                            EmployeeId = 15,
                            Adress = "1213 Durgan Walks, New Mathiasbury, Cameroon",
                            DepartmentId = 1,
                            Email = "Terrill.Torphy@yahoo.com",
                            FirstName = "Zoe",
                            Gender = "Male",
                            LastName = "Friesen",
                            PhoneNumber = "585-321-3530",
                            Salary = 26400m
                        },
                        new
                        {
                            EmployeeId = 16,
                            Adress = "413 Ophelia Stravenue, Pattieberg, Tokelau",
                            DepartmentId = 5,
                            Email = "Donny.Okuneva54@yahoo.com",
                            FirstName = "Aubree",
                            Gender = "Female",
                            LastName = "Bernhard",
                            PhoneNumber = "(630) 984-6922 x77425",
                            Salary = 34044m
                        },
                        new
                        {
                            EmployeeId = 17,
                            Adress = "3809 Goldner Loaf, Prestonmouth, Hong Kong",
                            DepartmentId = 1,
                            Email = "Citlalli67@yahoo.com",
                            FirstName = "Juwan",
                            Gender = "Male",
                            LastName = "Abshire",
                            PhoneNumber = "(716) 219-5219 x45214",
                            Salary = 27680m
                        },
                        new
                        {
                            EmployeeId = 18,
                            Adress = "09660 Wisozk Hill, Zakaryborough, New Zealand",
                            DepartmentId = 1,
                            Email = "Alexzander_Turner13@yahoo.com",
                            FirstName = "Rene",
                            Gender = "Female",
                            LastName = "Bernhard",
                            PhoneNumber = "756-701-8732",
                            Salary = 21626m
                        },
                        new
                        {
                            EmployeeId = 19,
                            Adress = "3429 Leannon Branch, Esmeraldaville, Bosnia and Herzegovina",
                            DepartmentId = 3,
                            Email = "Odell_Hayes@hotmail.com",
                            FirstName = "Armand",
                            Gender = "Female",
                            LastName = "Pouros",
                            PhoneNumber = "(884) 261-8429",
                            Salary = 17912m
                        },
                        new
                        {
                            EmployeeId = 20,
                            Adress = "42795 Christa Trace, Tremaynetown, Hong Kong",
                            DepartmentId = 2,
                            Email = "Trace.Sporer@gmail.com",
                            FirstName = "Diana",
                            Gender = "Male",
                            LastName = "Krajcik",
                            PhoneNumber = "373-534-2771 x818",
                            Salary = 30036m
                        },
                        new
                        {
                            EmployeeId = 21,
                            Adress = "6847 Bert Corners, Romagueraburgh, Falkland Islands (Malvinas)",
                            DepartmentId = 1,
                            Email = "Jay_Larkin56@yahoo.com",
                            FirstName = "Eric",
                            Gender = "Female",
                            LastName = "Ferry",
                            PhoneNumber = "(384) 765-1115",
                            Salary = 33108m
                        },
                        new
                        {
                            EmployeeId = 22,
                            Adress = "75712 Clint Lane, Breitenbergland, Burkina Faso",
                            DepartmentId = 1,
                            Email = "Jonathan89@hotmail.com",
                            FirstName = "Mathilde",
                            Gender = "Female",
                            LastName = "Keeling",
                            PhoneNumber = "369-648-6412 x07063",
                            Salary = 26671m
                        },
                        new
                        {
                            EmployeeId = 23,
                            Adress = "147 Torp Corners, Kulasside, Cocos (Keeling) Islands",
                            DepartmentId = 5,
                            Email = "Ted6@yahoo.com",
                            FirstName = "Craig",
                            Gender = "Male",
                            LastName = "Okuneva",
                            PhoneNumber = "699.864.7872 x48957",
                            Salary = 18851m
                        },
                        new
                        {
                            EmployeeId = 24,
                            Adress = "1864 Astrid Roads, West Abel, Somalia",
                            DepartmentId = 1,
                            Email = "Michelle_Zulauf@hotmail.com",
                            FirstName = "Shaniya",
                            Gender = "Male",
                            LastName = "Sawayn",
                            PhoneNumber = "1-716-484-9900",
                            Salary = 33274m
                        },
                        new
                        {
                            EmployeeId = 25,
                            Adress = "5840 Santa Ramp, Dagmarfurt, Maldives",
                            DepartmentId = 2,
                            Email = "Ericka95@yahoo.com",
                            FirstName = "Chadd",
                            Gender = "Female",
                            LastName = "Dickens",
                            PhoneNumber = "(565) 570-7489 x708",
                            Salary = 20311m
                        },
                        new
                        {
                            EmployeeId = 26,
                            Adress = "865 Jeff Centers, Rodgerchester, Senegal",
                            DepartmentId = 2,
                            Email = "Nickolas54@hotmail.com",
                            FirstName = "Kelly",
                            Gender = "Male",
                            LastName = "Harvey",
                            PhoneNumber = "(580) 473-8918 x45591",
                            Salary = 32775m
                        },
                        new
                        {
                            EmployeeId = 27,
                            Adress = "155 Edyth Cove, New Forrestville, Ireland",
                            DepartmentId = 1,
                            Email = "Paige_Feil52@yahoo.com",
                            FirstName = "Maia",
                            Gender = "Male",
                            LastName = "Hodkiewicz",
                            PhoneNumber = "946.539.0131 x87009",
                            Salary = 25125m
                        },
                        new
                        {
                            EmployeeId = 28,
                            Adress = "440 Dasia Summit, North Fernandoport, Saint Martin",
                            DepartmentId = 4,
                            Email = "Arno.Pfeffer@gmail.com",
                            FirstName = "Mohammad",
                            Gender = "Female",
                            LastName = "Turner",
                            PhoneNumber = "703-601-6762 x94431",
                            Salary = 20833m
                        },
                        new
                        {
                            EmployeeId = 29,
                            Adress = "564 Bernard Station, South Colin, Central African Republic",
                            DepartmentId = 5,
                            Email = "Davion.Feest40@hotmail.com",
                            FirstName = "Joaquin",
                            Gender = "Female",
                            LastName = "Cummings",
                            PhoneNumber = "615-902-6107",
                            Salary = 21966m
                        },
                        new
                        {
                            EmployeeId = 30,
                            Adress = "49649 Hane Underpass, North Oren, South Georgia and the South Sandwich Islands",
                            DepartmentId = 1,
                            Email = "Fiona_Fisher@hotmail.com",
                            FirstName = "Sophia",
                            Gender = "Male",
                            LastName = "McClure",
                            PhoneNumber = "1-687-651-4536 x41134",
                            Salary = 31789m
                        },
                        new
                        {
                            EmployeeId = 31,
                            Adress = "283 Schaden Way, Madisonchester, Seychelles",
                            DepartmentId = 5,
                            Email = "Jack4@hotmail.com",
                            FirstName = "Andreanne",
                            Gender = "Female",
                            LastName = "Runolfsdottir",
                            PhoneNumber = "402-851-3220 x9856",
                            Salary = 21710m
                        },
                        new
                        {
                            EmployeeId = 32,
                            Adress = "395 Lafayette Mission, Izaiahfort, Mauritania",
                            DepartmentId = 4,
                            Email = "Jane_Hirthe@gmail.com",
                            FirstName = "Damien",
                            Gender = "Female",
                            LastName = "Predovic",
                            PhoneNumber = "944-953-9203",
                            Salary = 27974m
                        },
                        new
                        {
                            EmployeeId = 33,
                            Adress = "2810 Strosin Shore, East Elmiramouth, Falkland Islands (Malvinas)",
                            DepartmentId = 2,
                            Email = "Grayson.Wiza@gmail.com",
                            FirstName = "Alvera",
                            Gender = "Female",
                            LastName = "Hand",
                            PhoneNumber = "743.803.1940",
                            Salary = 33231m
                        },
                        new
                        {
                            EmployeeId = 34,
                            Adress = "446 Madalyn Courts, Roslynchester, Antarctica (the territory South of 60 deg S)",
                            DepartmentId = 2,
                            Email = "Zackery49@hotmail.com",
                            FirstName = "Claudia",
                            Gender = "Female",
                            LastName = "Stiedemann",
                            PhoneNumber = "1-644-435-9672 x673",
                            Salary = 19737m
                        },
                        new
                        {
                            EmployeeId = 35,
                            Adress = "6932 Hand Locks, New Dallas, Suriname",
                            DepartmentId = 2,
                            Email = "Sonya43@yahoo.com",
                            FirstName = "Leonor",
                            Gender = "Male",
                            LastName = "Bednar",
                            PhoneNumber = "332-965-0168 x49055",
                            Salary = 22245m
                        },
                        new
                        {
                            EmployeeId = 36,
                            Adress = "5382 Josiah Island, North Newell, Democratic People's Republic of Korea",
                            DepartmentId = 4,
                            Email = "Matt_Prohaska60@hotmail.com",
                            FirstName = "Benton",
                            Gender = "Male",
                            LastName = "Abshire",
                            PhoneNumber = "790.590.8133 x720",
                            Salary = 28102m
                        },
                        new
                        {
                            EmployeeId = 37,
                            Adress = "4633 Braeden Trail, Padbergshire, Anguilla",
                            DepartmentId = 1,
                            Email = "Delbert.Brown@gmail.com",
                            FirstName = "Deangelo",
                            Gender = "Male",
                            LastName = "Stiedemann",
                            PhoneNumber = "(551) 662-4404 x853",
                            Salary = 33171m
                        },
                        new
                        {
                            EmployeeId = 38,
                            Adress = "1867 Kunze Rest, Port Durward, Uruguay",
                            DepartmentId = 4,
                            Email = "Kathryne_Friesen16@yahoo.com",
                            FirstName = "Lyda",
                            Gender = "Female",
                            LastName = "Prosacco",
                            PhoneNumber = "557-489-7738",
                            Salary = 30980m
                        },
                        new
                        {
                            EmployeeId = 39,
                            Adress = "23696 Wisozk Islands, West Oren, Nepal",
                            DepartmentId = 5,
                            Email = "Vernon_Ortiz3@yahoo.com",
                            FirstName = "Ari",
                            Gender = "Female",
                            LastName = "McGlynn",
                            PhoneNumber = "1-486-495-6159",
                            Salary = 22283m
                        },
                        new
                        {
                            EmployeeId = 40,
                            Adress = "84173 Schultz Brooks, New Idell, Sri Lanka",
                            DepartmentId = 4,
                            Email = "Adele_Kozey@gmail.com",
                            FirstName = "Brando",
                            Gender = "Male",
                            LastName = "Streich",
                            PhoneNumber = "914-872-7044",
                            Salary = 32160m
                        },
                        new
                        {
                            EmployeeId = 41,
                            Adress = "2318 Travis Expressway, Keeblerfort, Norfolk Island",
                            DepartmentId = 1,
                            Email = "Garth89@gmail.com",
                            FirstName = "Libby",
                            Gender = "Male",
                            LastName = "Terry",
                            PhoneNumber = "(530) 474-1852 x20722",
                            Salary = 26455m
                        },
                        new
                        {
                            EmployeeId = 42,
                            Adress = "9480 Legros Point, Port Viva, Botswana",
                            DepartmentId = 2,
                            Email = "Shaniya26@yahoo.com",
                            FirstName = "Caitlyn",
                            Gender = "Female",
                            LastName = "Hilpert",
                            PhoneNumber = "1-926-422-7711 x290",
                            Salary = 31880m
                        },
                        new
                        {
                            EmployeeId = 43,
                            Adress = "43104 Demarcus Dale, Ricardoshire, United Arab Emirates",
                            DepartmentId = 2,
                            Email = "Bernice97@gmail.com",
                            FirstName = "Gudrun",
                            Gender = "Female",
                            LastName = "Stanton",
                            PhoneNumber = "990.500.9846 x254",
                            Salary = 23605m
                        },
                        new
                        {
                            EmployeeId = 44,
                            Adress = "33182 Dillan Falls, East Karliville, Lithuania",
                            DepartmentId = 3,
                            Email = "Drew80@gmail.com",
                            FirstName = "Stacey",
                            Gender = "Male",
                            LastName = "Bode",
                            PhoneNumber = "951.285.1686",
                            Salary = 33261m
                        },
                        new
                        {
                            EmployeeId = 45,
                            Adress = "67595 Kessler Ford, Port Erna, Wallis and Futuna",
                            DepartmentId = 1,
                            Email = "Julia.Deckow22@hotmail.com",
                            FirstName = "Harrison",
                            Gender = "Male",
                            LastName = "Nienow",
                            PhoneNumber = "1-473-522-9392 x131",
                            Salary = 26566m
                        },
                        new
                        {
                            EmployeeId = 46,
                            Adress = "03438 Nyasia Pass, Guidofurt, Senegal",
                            DepartmentId = 4,
                            Email = "Leatha.Kshlerin97@hotmail.com",
                            FirstName = "Rae",
                            Gender = "Female",
                            LastName = "Schiller",
                            PhoneNumber = "(973) 676-7447 x176",
                            Salary = 21188m
                        },
                        new
                        {
                            EmployeeId = 47,
                            Adress = "67858 Kemmer Estate, Naderside, Sao Tome and Principe",
                            DepartmentId = 2,
                            Email = "Koby_Brakus8@yahoo.com",
                            FirstName = "Vivian",
                            Gender = "Female",
                            LastName = "Bergstrom",
                            PhoneNumber = "(749) 640-0866",
                            Salary = 25009m
                        },
                        new
                        {
                            EmployeeId = 48,
                            Adress = "2257 Bergnaum Trace, Alishaborough, Azerbaijan",
                            DepartmentId = 1,
                            Email = "Tristian_Wisoky@yahoo.com",
                            FirstName = "Donna",
                            Gender = "Male",
                            LastName = "Greenholt",
                            PhoneNumber = "1-642-312-2592 x942",
                            Salary = 21223m
                        },
                        new
                        {
                            EmployeeId = 49,
                            Adress = "910 Karen Spring, Estellborough, Haiti",
                            DepartmentId = 4,
                            Email = "Imogene_Ryan33@yahoo.com",
                            FirstName = "Steve",
                            Gender = "Female",
                            LastName = "Mohr",
                            PhoneNumber = "954-596-5881 x7675",
                            Salary = 30620m
                        },
                        new
                        {
                            EmployeeId = 50,
                            Adress = "117 Devin Knolls, Port Mariane, Swaziland",
                            DepartmentId = 2,
                            Email = "Brice.Dicki@gmail.com",
                            FirstName = "Gerard",
                            Gender = "Male",
                            LastName = "Gusikowski",
                            PhoneNumber = "647.972.2858 x7424",
                            Salary = 21534m
                        });
                });

            modelBuilder.Entity("Labb2_Avancerad.Models.Employee", b =>
                {
                    b.HasOne("Labb2_Avancerad.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}