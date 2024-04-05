﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USTrails.API.Data;

#nullable disable

namespace USTrails.API.Migrations
{
    [DbContext(typeof(USTrailsDbContext))]
    partial class USTrailsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StateTrail", b =>
                {
                    b.Property<byte>("StatesId")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("TrailId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StatesId", "TrailId");

                    b.HasIndex("TrailId");

                    b.ToTable("StateTrail");
                });

            modelBuilder.Entity("USTrails.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Name = "Easy"
                        },
                        new
                        {
                            Id = (byte)2,
                            Name = "Moderate"
                        },
                        new
                        {
                            Id = (byte)3,
                            Name = "Moderately Strenuous"
                        },
                        new
                        {
                            Id = (byte)4,
                            Name = "Strenuous"
                        },
                        new
                        {
                            Id = (byte)5,
                            Name = "Very Strenuous"
                        });
                });

            modelBuilder.Entity("USTrails.API.Models.Domain.State", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Code = "AL",
                            Name = "Alabama",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Alabama_in_United_States.svg/1280px-Alabama_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)2,
                            Code = "AK",
                            Name = "Alaska",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Alaska_in_United_States_%28US50%29.svg/1280px-Alaska_in_United_States_%28US50%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)3,
                            Code = "AZ",
                            Name = "Arizona",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Arizona_in_United_States.svg/1280px-Arizona_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)4,
                            Code = "AR",
                            Name = "Arkansas",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Arkansas_in_United_States.svg/1280px-Arkansas_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)5,
                            Code = "CA",
                            Name = "California",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/California_in_United_States.svg/1280px-California_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)6,
                            Code = "CO",
                            Name = "Colorado",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Colorado_in_United_States.svg/1280px-Colorado_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)7,
                            Code = "CT",
                            Name = "Connecticut",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Connecticut_in_United_States_%28zoom%29.svg/1280px-Connecticut_in_United_States_%28zoom%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)8,
                            Code = "DE",
                            Name = "Delaware",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Delaware_in_United_States_%28zoom%29.svg/1280px-Delaware_in_United_States_%28zoom%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)9,
                            Code = "FL",
                            Name = "Florida",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Florida_in_United_States.svg/1280px-Florida_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)10,
                            Code = "GA",
                            Name = "Georgia",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Georgia_in_United_States.svg/1280px-Georgia_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)11,
                            Code = "HI",
                            Name = "Hawaii",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg/1280px-Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)12,
                            Code = "ID",
                            Name = "Idaho",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Idaho_in_United_States.svg/1280px-Idaho_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)13,
                            Code = "IL",
                            Name = "Illinois",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Illinois_in_United_States.svg/1280px-Illinois_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)14,
                            Code = "IN",
                            Name = "Indiana",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Indiana_in_United_States.svg/1280px-Indiana_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)15,
                            Code = "IA",
                            Name = "Iowa",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Iowa_in_United_States.svg/1280px-Iowa_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)16,
                            Code = "KS",
                            Name = "Kansas",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Kansas_in_United_States.svg/1280px-Kansas_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)17,
                            Code = "KY",
                            Name = "Kentucky",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Kentucky_in_United_States.svg/1280px-Kentucky_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)18,
                            Code = "LA",
                            Name = "Louisiana",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Louisiana_in_United_States.svg/1280px-Louisiana_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)19,
                            Code = "ME",
                            Name = "Maine",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Maine_in_United_States.svg/1280px-Maine_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)20,
                            Code = "MD",
                            Name = "Maryland",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Maryland_in_United_States_%28zoom%29.svg/1280px-Maryland_in_United_States_%28zoom%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)21,
                            Code = "MA",
                            Name = "Massachusetts",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Massachusetts_in_United_States.svg/1280px-Massachusetts_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)22,
                            Code = "MI",
                            Name = "Michigan",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Michigan_in_United_States.svg/1280px-Michigan_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)23,
                            Code = "MN",
                            Name = "Minnesota",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Minnesota_in_United_States.svg/1280px-Minnesota_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)24,
                            Code = "MS",
                            Name = "Mississippi",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Mississippi_in_United_States.svg/1280px-Mississippi_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)25,
                            Code = "MO",
                            Name = "Missouri",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Missouri_in_United_States.svg/1280px-Missouri_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)26,
                            Code = "MT",
                            Name = "Montana",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Montana_in_United_States.svg/1280px-Montana_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)27,
                            Code = "NE",
                            Name = "Nebraska",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Nebraska_in_United_States.svg/1280px-Nebraska_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)28,
                            Code = "NV",
                            Name = "Nevada",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Nevada_in_United_States.svg/1280px-Nevada_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)29,
                            Code = "NH",
                            Name = "New Hampshire",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/New_Hampshire_in_United_States.svg/1280px-New_Hampshire_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)30,
                            Code = "NJ",
                            Name = "New Jersey",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/New_Jersey_in_United_States_%28zoom%29.svg/1280px-New_Jersey_in_United_States_%28zoom%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)31,
                            Code = "NM",
                            Name = "New Mexico",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/New_Mexico_in_United_States.svg/1280px-New_Mexico_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)32,
                            Code = "NY",
                            Name = "New York",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/New_York_in_United_States.svg/1280px-New_York_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)33,
                            Code = "NC",
                            Name = "North Carolina",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/North_Carolina_in_United_States.svg/1280px-North_Carolina_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)34,
                            Code = "ND",
                            Name = "North Dakota",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/North_Dakota_in_United_States.svg/1280px-North_Dakota_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)35,
                            Code = "OH",
                            Name = "Ohio",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Ohio_in_United_States.svg/1280px-Ohio_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)36,
                            Code = "OK",
                            Name = "Oklahoma",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Oklahoma_in_United_States.svg/1280px-Oklahoma_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)37,
                            Code = "OR",
                            Name = "Oregon",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Oregon_in_United_States.svg/1280px-Oregon_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)38,
                            Code = "PA",
                            Name = "Pennsylvania",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Pennsylvania_in_United_States.svg/1280px-Pennsylvania_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)39,
                            Code = "RI",
                            Name = "Rhode Island",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg/1280px-Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)40,
                            Code = "SC",
                            Name = "South Carolina",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/South_Carolina_in_United_States.svg/1280px-South_Carolina_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)41,
                            Code = "SD",
                            Name = "South Dakota",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/South_Dakota_in_United_States.svg/1280px-South_Dakota_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)42,
                            Code = "TN",
                            Name = "Tennessee",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Tennessee_in_United_States.svg/1280px-Tennessee_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)43,
                            Code = "TX",
                            Name = "Texas",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Texas_in_United_States.svg/1280px-Texas_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)44,
                            Code = "UT",
                            Name = "Utah",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Utah_in_United_States.svg/1280px-Utah_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)45,
                            Code = "VT",
                            Name = "Vermont",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Vermont_in_United_States_%28zoom%29.svg/1280px-Vermont_in_United_States_%28zoom%29.svg.png"
                        },
                        new
                        {
                            Id = (byte)46,
                            Code = "VA",
                            Name = "Virginia",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/Virginia_in_United_States.svg/1280px-Virginia_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)47,
                            Code = "WA",
                            Name = "Washington",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Washington_in_United_States.svg/1280px-Washington_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)48,
                            Code = "WV",
                            Name = "West Virginia",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/West_Virginia_in_United_States.svg/1280px-West_Virginia_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)49,
                            Code = "WI",
                            Name = "Wisconsin",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Wisconsin_in_United_States.svg/1280px-Wisconsin_in_United_States.svg.png"
                        },
                        new
                        {
                            Id = (byte)50,
                            Code = "WY",
                            Name = "Wyoming",
                            StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Wyoming_in_United_States.svg/1280px-Wyoming_in_United_States.svg.png"
                        });
                });

            modelBuilder.Entity("USTrails.API.Models.Domain.Trail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("DifficultyId")
                        .HasColumnType("tinyint");

                    b.Property<double>("LengthInMi")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.ToTable("Trails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5"),
                            Description = "The Appalachian Trail is a hiking trail in the Eastern United States, extending between Springer Mountain in Georgia and Mount Katahdin in Maine. The Appalachian Trail Conservancy claims the Appalachian Trail to be the longest hiking-only trail in the world. More than three million people hike segments of the trail each year.",
                            DifficultyId = (byte)4,
                            LengthInMi = 2197.4000000000001,
                            Name = "Appalachian Trail",
                            StateIds = "[7,10,21,20,19,33,29,30,32,38,42,46,45,48]",
                            TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0f/Map_of_Appalachian_Trail.png"
                        },
                        new
                        {
                            Id = new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972"),
                            Description = "The Pacific Crest Trail is a long-distance hiking and equestrian trail closely aligned with the highest portion of the Cascade and Sierra Nevada mountain ranges. The trail's southern terminus is next to the Mexico–United States border, just south of Campo, California, and its northern terminus is on the Canada–US border.",
                            DifficultyId = (byte)2,
                            LengthInMi = 2653.0,
                            Name = "Pacific Crest Trail",
                            StateIds = "[5,37,47]",
                            TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3f/Locator_Map_of_the_Pacific_Crest_Trail.png"
                        },
                        new
                        {
                            Id = new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413"),
                            Description = "The Continental Divide Trail is a trail between the U.S. border with Chihuahua, Mexico and the border with Alberta, Canada. It follows the Continental Divide of the Americas along the Rocky Mountains. Near the Canadian border the trail crosses Triple Divide Pass.",
                            DifficultyId = (byte)5,
                            LengthInMi = 3028.0,
                            Name = "Continental Divide Trail",
                            StateIds = "[26,12,50,6,31]",
                            TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/ba/Condivm.png"
                        },
                        new
                        {
                            Id = new Guid("6a403145-11aa-4194-9108-4bbab8700d09"),
                            Description = "The North Country Trail is a long-distance hiking trail in the Midwestern and Northeastern United States. The trail extends from Lake Sakakawea State Park in North Dakota to the Appalachian Trail in Green Mountain National Forest in Vermont.",
                            DifficultyId = (byte)3,
                            LengthInMi = 4800.0,
                            Name = "North Country Trail",
                            StateIds = "[34,23,49,22,35,38,32,45]",
                            TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/41/North_Country_Trail_Locator_Map_US.svg"
                        },
                        new
                        {
                            Id = new Guid("a4b04586-c423-49a6-8132-852666353eb2"),
                            Description = "The Ice Age Trail is a trail that roughly follows the location of the terminal moraine from the last Ice Age. The western end of the trail is at Interstate State Park along the St. Croix River, and the eastern terminus lies at Potawatomi State Park near the city of Sturgeon Bay.",
                            DifficultyId = (byte)1,
                            LengthInMi = 1200.0,
                            Name = "Ice Age Trail",
                            StateIds = "[49]",
                            TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/47/USNPS_Ice-Age-Trail_6d05am.jpg"
                        },
                        new
                        {
                            Id = new Guid("f5357e24-c626-4615-985b-7d836fa52369"),
                            Description = "The Potomac Heritage Trail is a trail spanning parts of the mid-Atlantic region. The trail network includes existing and planned sections, tracing the natural, historical, and cultural features of the Potomac River corridor, the upper Ohio River watershed, and a portion of the Rappahannock River watershed.",
                            DifficultyId = (byte)2,
                            LengthInMi = 710.0,
                            Name = "Potomac Heritage Trail",
                            StateIds = "[46,20,38]",
                            TrailImageUrl = "https://pnts.org/new/wp-content/uploads/2014/12/Potomac-Heritage-NST-Map.png"
                        },
                        new
                        {
                            Id = new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d"),
                            Description = "The Natchez Trace Trail is a trail whose route generally follows sections of the Natchez Trace Parkway. It commemorates the historic Natchez Trace, an ancient path that began as a wildlife and Native American trail, and has a rich history of use by colonizers, \"Kaintuck\" boatmen, post riders, and military men.",
                            DifficultyId = (byte)3,
                            LengthInMi = 60.0,
                            Name = "Natchez Trace Trail",
                            StateIds = "[1,24,42]",
                            TrailImageUrl = "https://pnts.org/new/wp-content/uploads/2014/12/Pink-Natchez-Trace-Map.png"
                        },
                        new
                        {
                            Id = new Guid("4c4d7e5e-b7c9-4a0b-9337-9de4e25d208b"),
                            Description = "The Florida Trail runs from Big Cypress National Preserve to Fort Pickens at Gulf Islands National Seashore, Pensacola Beach. It provides permanent non-motorized recreation opportunity for hiking and other compatible activities and is within an hour of most Floridians.",
                            DifficultyId = (byte)3,
                            LengthInMi = 1500.0,
                            Name = "Florida Trail",
                            StateIds = "[9]",
                            TrailImageUrl = "https://www.journaloffloridastudies.org/images/Florida-Trail-Map.jpg"
                        },
                        new
                        {
                            Id = new Guid("83c81f00-f422-499c-bb50-1d0405c2aea7"),
                            Description = "The Arizona Trail is a trail from Mexico to Utah that traverses the whole north–south length of Arizona. It begins at the Coronado National Memorial near the US–Mexico border and moves north through parts of the Huachuca, Santa Rita, and Rincon Mountains, terminating near the Arizona–Utah border in the Kaibab Plateau region. The trail is designed as a primitive trail for hiking, equestrians, mountain biking, and even cross country skiing, showcasing the wide variety of mountain ranges and ecosystems of Arizona.",
                            DifficultyId = (byte)2,
                            LengthInMi = 800.0,
                            Name = "Arizona Trail",
                            StateIds = "[3]",
                            TrailImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKKuZO-kxEsTowdn4Mu9j46IAqPXd5KUW89vSi5XUu5g&s"
                        },
                        new
                        {
                            Id = new Guid("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa"),
                            Description = "The New England Trail is a trail in southern New England, which includes most of the three single trails Metacomet-Monadnock Trail, Mattabesett Trail, and Metacomet Trail. It extends through 41 communities from Guilford, Connecticut, at Long Island Sound over the Metacomet Ridge, through the highlands of the Pioneer Valley of Massachusetts, to the New Hampshire state border.",
                            DifficultyId = (byte)3,
                            LengthInMi = 215.0,
                            Name = "New England Trail",
                            StateIds = "[7,21]",
                            TrailImageUrl = "https://i0.wp.com/www.jeffryanauthor.com/wp-content/uploads/2019/06/Screen-Shot-2019-06-05-at-4.22.01-PM-1.jpg"
                        },
                        new
                        {
                            Id = new Guid("01469432-69c7-4e24-838d-6f74886caec9"),
                            Description = "The Pacific Northwest Trail is a hiking trail running from the Continental Divide in Montana to the Pacific Ocean on Washington's Olympic Coast. Along the way, the it crosses three national parks, seven national forests, and two other national scenic trails.",
                            DifficultyId = (byte)5,
                            LengthInMi = 1200.0,
                            Name = "Pacific Northwest Trail",
                            StateIds = "[26,12,47]",
                            TrailImageUrl = "https://ep1.pinkbike.org/trailstaticmap/35000/route_35184_0_600x315.png"
                        });
                });

            modelBuilder.Entity("StateTrail", b =>
                {
                    b.HasOne("USTrails.API.Models.Domain.State", null)
                        .WithMany()
                        .HasForeignKey("StatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USTrails.API.Models.Domain.Trail", null)
                        .WithMany()
                        .HasForeignKey("TrailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("USTrails.API.Models.Domain.Trail", b =>
                {
                    b.HasOne("USTrails.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");
                });
#pragma warning restore 612, 618
        }
    }
}
