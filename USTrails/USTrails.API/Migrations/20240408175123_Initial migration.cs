using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Difficulties",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthInMi = table.Column<double>(type: "float", nullable: false),
                    TrailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyId = table.Column<short>(type: "smallint", nullable: false),
                    StateIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trails_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateTrail",
                columns: table => new
                {
                    TrailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTrail", x => new { x.StateId, x.TrailId });
                    table.ForeignKey(
                        name: "FK_StateTrail_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateTrail_Trails_TrailId",
                        column: x => x.TrailId,
                        principalTable: "Trails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (short)1, "Easy" },
                    { (short)2, "Moderate" },
                    { (short)3, "Moderately Strenuous" },
                    { (short)4, "Strenuous" },
                    { (short)5, "Very Strenuous" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Code", "Name", "StateImageUrl" },
                values: new object[,]
                {
                    { (short)1, "AL", "Alabama", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Alabama_in_United_States.svg/1280px-Alabama_in_United_States.svg.png" },
                    { (short)2, "AK", "Alaska", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Alaska_in_United_States_%28US50%29.svg/1280px-Alaska_in_United_States_%28US50%29.svg.png" },
                    { (short)3, "AZ", "Arizona", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Arizona_in_United_States.svg/1280px-Arizona_in_United_States.svg.png" },
                    { (short)4, "AR", "Arkansas", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Arkansas_in_United_States.svg/1280px-Arkansas_in_United_States.svg.png" },
                    { (short)5, "CA", "California", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/California_in_United_States.svg/1280px-California_in_United_States.svg.png" },
                    { (short)6, "CO", "Colorado", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Colorado_in_United_States.svg/1280px-Colorado_in_United_States.svg.png" },
                    { (short)7, "CT", "Connecticut", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Connecticut_in_United_States_%28zoom%29.svg/1280px-Connecticut_in_United_States_%28zoom%29.svg.png" },
                    { (short)8, "DE", "Delaware", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Delaware_in_United_States_%28zoom%29.svg/1280px-Delaware_in_United_States_%28zoom%29.svg.png" },
                    { (short)9, "FL", "Florida", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Florida_in_United_States.svg/1280px-Florida_in_United_States.svg.png" },
                    { (short)10, "GA", "Georgia", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Georgia_in_United_States.svg/1280px-Georgia_in_United_States.svg.png" },
                    { (short)11, "HI", "Hawaii", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg/1280px-Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg.png" },
                    { (short)12, "ID", "Idaho", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Idaho_in_United_States.svg/1280px-Idaho_in_United_States.svg.png" },
                    { (short)13, "IL", "Illinois", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Illinois_in_United_States.svg/1280px-Illinois_in_United_States.svg.png" },
                    { (short)14, "IN", "Indiana", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Indiana_in_United_States.svg/1280px-Indiana_in_United_States.svg.png" },
                    { (short)15, "IA", "Iowa", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Iowa_in_United_States.svg/1280px-Iowa_in_United_States.svg.png" },
                    { (short)16, "KS", "Kansas", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Kansas_in_United_States.svg/1280px-Kansas_in_United_States.svg.png" },
                    { (short)17, "KY", "Kentucky", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Kentucky_in_United_States.svg/1280px-Kentucky_in_United_States.svg.png" },
                    { (short)18, "LA", "Louisiana", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Louisiana_in_United_States.svg/1280px-Louisiana_in_United_States.svg.png" },
                    { (short)19, "ME", "Maine", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Maine_in_United_States.svg/1280px-Maine_in_United_States.svg.png" },
                    { (short)20, "MD", "Maryland", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Maryland_in_United_States_%28zoom%29.svg/1280px-Maryland_in_United_States_%28zoom%29.svg.png" },
                    { (short)21, "MA", "Massachusetts", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Massachusetts_in_United_States.svg/1280px-Massachusetts_in_United_States.svg.png" },
                    { (short)22, "MI", "Michigan", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Michigan_in_United_States.svg/1280px-Michigan_in_United_States.svg.png" },
                    { (short)23, "MN", "Minnesota", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Minnesota_in_United_States.svg/1280px-Minnesota_in_United_States.svg.png" },
                    { (short)24, "MS", "Mississippi", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Mississippi_in_United_States.svg/1280px-Mississippi_in_United_States.svg.png" },
                    { (short)25, "MO", "Missouri", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Missouri_in_United_States.svg/1280px-Missouri_in_United_States.svg.png" },
                    { (short)26, "MT", "Montana", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Montana_in_United_States.svg/1280px-Montana_in_United_States.svg.png" },
                    { (short)27, "NE", "Nebraska", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Nebraska_in_United_States.svg/1280px-Nebraska_in_United_States.svg.png" },
                    { (short)28, "NV", "Nevada", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Nevada_in_United_States.svg/1280px-Nevada_in_United_States.svg.png" },
                    { (short)29, "NH", "New Hampshire", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/New_Hampshire_in_United_States.svg/1280px-New_Hampshire_in_United_States.svg.png" },
                    { (short)30, "NJ", "New Jersey", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/New_Jersey_in_United_States_%28zoom%29.svg/1280px-New_Jersey_in_United_States_%28zoom%29.svg.png" },
                    { (short)31, "NM", "New Mexico", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/New_Mexico_in_United_States.svg/1280px-New_Mexico_in_United_States.svg.png" },
                    { (short)32, "NY", "New York", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/New_York_in_United_States.svg/1280px-New_York_in_United_States.svg.png" },
                    { (short)33, "NC", "North Carolina", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/North_Carolina_in_United_States.svg/1280px-North_Carolina_in_United_States.svg.png" },
                    { (short)34, "ND", "North Dakota", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/North_Dakota_in_United_States.svg/1280px-North_Dakota_in_United_States.svg.png" },
                    { (short)35, "OH", "Ohio", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Ohio_in_United_States.svg/1280px-Ohio_in_United_States.svg.png" },
                    { (short)36, "OK", "Oklahoma", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Oklahoma_in_United_States.svg/1280px-Oklahoma_in_United_States.svg.png" },
                    { (short)37, "OR", "Oregon", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Oregon_in_United_States.svg/1280px-Oregon_in_United_States.svg.png" },
                    { (short)38, "PA", "Pennsylvania", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Pennsylvania_in_United_States.svg/1280px-Pennsylvania_in_United_States.svg.png" },
                    { (short)39, "RI", "Rhode Island", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg/1280px-Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg.png" },
                    { (short)40, "SC", "South Carolina", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/South_Carolina_in_United_States.svg/1280px-South_Carolina_in_United_States.svg.png" },
                    { (short)41, "SD", "South Dakota", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/South_Dakota_in_United_States.svg/1280px-South_Dakota_in_United_States.svg.png" },
                    { (short)42, "TN", "Tennessee", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Tennessee_in_United_States.svg/1280px-Tennessee_in_United_States.svg.png" },
                    { (short)43, "TX", "Texas", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Texas_in_United_States.svg/1280px-Texas_in_United_States.svg.png" },
                    { (short)44, "UT", "Utah", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Utah_in_United_States.svg/1280px-Utah_in_United_States.svg.png" },
                    { (short)45, "VT", "Vermont", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Vermont_in_United_States_%28zoom%29.svg/1280px-Vermont_in_United_States_%28zoom%29.svg.png" },
                    { (short)46, "VA", "Virginia", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/Virginia_in_United_States.svg/1280px-Virginia_in_United_States.svg.png" },
                    { (short)47, "WA", "Washington", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Washington_in_United_States.svg/1280px-Washington_in_United_States.svg.png" },
                    { (short)48, "WV", "West Virginia", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/West_Virginia_in_United_States.svg/1280px-West_Virginia_in_United_States.svg.png" },
                    { (short)49, "WI", "Wisconsin", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Wisconsin_in_United_States.svg/1280px-Wisconsin_in_United_States.svg.png" },
                    { (short)50, "WY", "Wyoming", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Wyoming_in_United_States.svg/1280px-Wyoming_in_United_States.svg.png" }
                });

            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "Id", "Description", "DifficultyId", "LengthInMi", "Name", "StateIds", "TrailImageUrl" },
                values: new object[,]
                {
                    { new Guid("01469432-69c7-4e24-838d-6f74886caec9"), "The Pacific Northwest Trail is a hiking trail running from the Continental Divide in Montana to the Pacific Ocean on Washington's Olympic Coast. Along the way, the it crosses three national parks, seven national forests, and two other national scenic trails.", (short)5, 1200.0, "Pacific Northwest Trail", "[]", "https://ep1.pinkbike.org/trailstaticmap/35000/route_35184_0_600x315.png" },
                    { new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5"), "The Appalachian Trail is a hiking trail in the Eastern United States, extending between Springer Mountain in Georgia and Mount Katahdin in Maine. The Appalachian Trail Conservancy claims the Appalachian Trail to be the longest hiking-only trail in the world. More than three million people hike segments of the trail each year.", (short)4, 2197.4000000000001, "Appalachian Trail", "[]", "https://upload.wikimedia.org/wikipedia/commons/0/0f/Map_of_Appalachian_Trail.png" },
                    { new Guid("4c4d7e5e-b7c9-4a0b-9337-9de4e25d208b"), "The Florida Trail runs from Big Cypress National Preserve to Fort Pickens at Gulf Islands National Seashore, Pensacola Beach. It provides permanent non-motorized recreation opportunity for hiking and other compatible activities and is within an hour of most Floridians.", (short)3, 1500.0, "Florida Trail", "[]", "https://www.journaloffloridastudies.org/images/Florida-Trail-Map.jpg" },
                    { new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d"), "The Natchez Trace Trail is a trail whose route generally follows sections of the Natchez Trace Parkway. It commemorates the historic Natchez Trace, an ancient path that began as a wildlife and Native American trail, and has a rich history of use by colonizers, \"Kaintuck\" boatmen, post riders, and military men.", (short)3, 60.0, "Natchez Trace Trail", "[]", "https://pnts.org/new/wp-content/uploads/2014/12/Pink-Natchez-Trace-Map.png" },
                    { new Guid("6a403145-11aa-4194-9108-4bbab8700d09"), "The North Country Trail is a long-distance hiking trail in the Midwestern and Northeastern United States. The trail extends from Lake Sakakawea State Park in North Dakota to the Appalachian Trail in Green Mountain National Forest in Vermont.", (short)3, 4800.0, "North Country Trail", "[]", "https://upload.wikimedia.org/wikipedia/commons/4/41/North_Country_Trail_Locator_Map_US.svg" },
                    { new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413"), "The Continental Divide Trail is a trail between the U.S. border with Chihuahua, Mexico and the border with Alberta, Canada. It follows the Continental Divide of the Americas along the Rocky Mountains. Near the Canadian border the trail crosses Triple Divide Pass.", (short)5, 3028.0, "Continental Divide Trail", "[]", "https://upload.wikimedia.org/wikipedia/commons/b/ba/Condivm.png" },
                    { new Guid("83c81f00-f422-499c-bb50-1d0405c2aea7"), "The Arizona Trail is a trail from Mexico to Utah that traverses the whole north–south length of Arizona. It begins at the Coronado National Memorial near the US–Mexico border and moves north through parts of the Huachuca, Santa Rita, and Rincon Mountains, terminating near the Arizona–Utah border in the Kaibab Plateau region. The trail is designed as a primitive trail for hiking, equestrians, mountain biking, and even cross country skiing, showcasing the wide variety of mountain ranges and ecosystems of Arizona.", (short)2, 800.0, "Arizona Trail", "[]", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKKuZO-kxEsTowdn4Mu9j46IAqPXd5KUW89vSi5XUu5g&s" },
                    { new Guid("a4b04586-c423-49a6-8132-852666353eb2"), "The Ice Age Trail is a trail that roughly follows the location of the terminal moraine from the last Ice Age. The western end of the trail is at Interstate State Park along the St. Croix River, and the eastern terminus lies at Potawatomi State Park near the city of Sturgeon Bay.", (short)1, 1200.0, "Ice Age Trail", "[]", "https://upload.wikimedia.org/wikipedia/commons/4/47/USNPS_Ice-Age-Trail_6d05am.jpg" },
                    { new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972"), "The Pacific Crest Trail is a long-distance hiking and equestrian trail closely aligned with the highest portion of the Cascade and Sierra Nevada mountain ranges. The trail's southern terminus is next to the Mexico–United States border, just south of Campo, California, and its northern terminus is on the Canada–US border.", (short)2, 2653.0, "Pacific Crest Trail", "[]", "https://upload.wikimedia.org/wikipedia/commons/3/3f/Locator_Map_of_the_Pacific_Crest_Trail.png" },
                    { new Guid("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa"), "The New England Trail is a trail in southern New England, which includes most of the three single trails Metacomet-Monadnock Trail, Mattabesett Trail, and Metacomet Trail. It extends through 41 communities from Guilford, Connecticut, at Long Island Sound over the Metacomet Ridge, through the highlands of the Pioneer Valley of Massachusetts, to the New Hampshire state border.", (short)3, 215.0, "New England Trail", "[]", "https://i0.wp.com/www.jeffryanauthor.com/wp-content/uploads/2019/06/Screen-Shot-2019-06-05-at-4.22.01-PM-1.jpg" },
                    { new Guid("f5357e24-c626-4615-985b-7d836fa52369"), "The Potomac Heritage Trail is a trail spanning parts of the mid-Atlantic region. The trail network includes existing and planned sections, tracing the natural, historical, and cultural features of the Potomac River corridor, the upper Ohio River watershed, and a portion of the Rappahannock River watershed.", (short)2, 710.0, "Potomac Heritage Trail", "[]", "https://pnts.org/new/wp-content/uploads/2014/12/Potomac-Heritage-NST-Map.png" }
                });

            migrationBuilder.InsertData(
                table: "StateTrail",
                columns: new[] { "StateId", "TrailId" },
                values: new object[,]
                {
                    { (short)1, new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d") },
                    { (short)3, new Guid("83c81f00-f422-499c-bb50-1d0405c2aea7") },
                    { (short)5, new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972") },
                    { (short)6, new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413") },
                    { (short)7, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)7, new Guid("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa") },
                    { (short)9, new Guid("4c4d7e5e-b7c9-4a0b-9337-9de4e25d208b") },
                    { (short)10, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)12, new Guid("01469432-69c7-4e24-838d-6f74886caec9") },
                    { (short)12, new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413") },
                    { (short)19, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)20, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)20, new Guid("f5357e24-c626-4615-985b-7d836fa52369") },
                    { (short)21, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)21, new Guid("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa") },
                    { (short)22, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)23, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)24, new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d") },
                    { (short)26, new Guid("01469432-69c7-4e24-838d-6f74886caec9") },
                    { (short)26, new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413") },
                    { (short)29, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)30, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)31, new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413") },
                    { (short)32, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)33, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)34, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)35, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)37, new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972") },
                    { (short)38, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)38, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)38, new Guid("f5357e24-c626-4615-985b-7d836fa52369") },
                    { (short)42, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)42, new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d") },
                    { (short)45, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)45, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)46, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)46, new Guid("f5357e24-c626-4615-985b-7d836fa52369") },
                    { (short)47, new Guid("01469432-69c7-4e24-838d-6f74886caec9") },
                    { (short)47, new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972") },
                    { (short)48, new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5") },
                    { (short)49, new Guid("6a403145-11aa-4194-9108-4bbab8700d09") },
                    { (short)49, new Guid("a4b04586-c423-49a6-8132-852666353eb2") },
                    { (short)50, new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateTrail_TrailId",
                table: "StateTrail",
                column: "TrailId");

            migrationBuilder.CreateIndex(
                name: "IX_Trails_DifficultyId",
                table: "Trails",
                column: "DifficultyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateTrail");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Trails");

            migrationBuilder.DropTable(
                name: "Difficulties");
        }
    }
}
