using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class Updatenationalscenictrailnameanddescriptiondata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("01469432-69c7-4e24-838d-6f74886caec9"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Pacific Northwest National Scenic Trail is a hiking trail running from the Continental Divide in Montana to the Pacific Ocean on Washington's Olympic Coast. Along the way, the it crosses three national parks, seven national forests, and two other national scenic trails.", "Pacific Northwest National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Appalachian National Scenic Trail is a hiking trail in the Eastern United States, extending between Springer Mountain in Georgia and Mount Katahdin in Maine. The Appalachian Trail Conservancy claims the Appalachian Trail to be the longest hiking-only trail in the world. More than three million people hike segments of the trail each year.", "Appalachian National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("4c4d7e5e-b7c9-4a0b-9337-9de4e25d208b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Florida National Scenic Trail runs from Big Cypress National Preserve to Fort Pickens at Gulf Islands National Seashore, Pensacola Beach. It provides permanent non-motorized recreation opportunity for hiking and other compatible activities and is within an hour of most Floridians.", "Florida National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Natchez Trace National Scenic Trail is a trail whose route generally follows sections of the Natchez Trace Parkway. It commemorates the historic Natchez Trace, an ancient path that began as a wildlife and Native American trail, and has a rich history of use by colonizers, \"Kaintuck\" boatmen, post riders, and military men.", "Natchez Trace National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("6a403145-11aa-4194-9108-4bbab8700d09"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The North Country National Scenic Trail is a long-distance hiking trail in the Midwestern and Northeastern United States. The trail extends from Lake Sakakawea State Park in North Dakota to the Appalachian Trail in Green Mountain National Forest in Vermont.", "North Country National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Continental Divide National Scenic Trail is a trail between the U.S. border with Chihuahua, Mexico and the border with Alberta, Canada. It follows the Continental Divide of the Americas along the Rocky Mountains. Near the Canadian border the trail crosses Triple Divide Pass.", "Continental Divide National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("83c81f00-f422-499c-bb50-1d0405c2aea7"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Arizona National Scenic Trail is a trail from Mexico to Utah that traverses the whole north–south length of Arizona. It begins at the Coronado National Memorial near the US–Mexico border and moves north through parts of the Huachuca, Santa Rita, and Rincon Mountains, terminating near the Arizona–Utah border in the Kaibab Plateau region. The trail is designed as a primitive trail for hiking, equestrians, mountain biking, and even cross country skiing, showcasing the wide variety of mountain ranges and ecosystems of Arizona.", "Arizona National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("a4b04586-c423-49a6-8132-852666353eb2"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Ice Age National Scenic Trail is a trail that roughly follows the location of the terminal moraine from the last Ice Age. The western end of the trail is at Interstate State Park along the St. Croix River, and the eastern terminus lies at Potawatomi State Park near the city of Sturgeon Bay.", "Ice Age National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Pacific Crest National Scenic Trail is a long-distance hiking and equestrian trail closely aligned with the highest portion of the Cascade and Sierra Nevada mountain ranges. The trail's southern terminus is next to the Mexico–United States border, just south of Campo, California, and its northern terminus is on the Canada–US border.", "Pacific Crest National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The New England National Scenic Trail is a trail in southern New England, which includes most of the three single trails Metacomet-Monadnock Trail, Mattabesett Trail, and Metacomet Trail. It extends through 41 communities from Guilford, Connecticut, at Long Island Sound over the Metacomet Ridge, through the highlands of the Pioneer Valley of Massachusetts, to the New Hampshire state border.", "New England National Scenic Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("f5357e24-c626-4615-985b-7d836fa52369"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Potomac Heritage National Scenic Trail is a trail spanning parts of the mid-Atlantic region. The trail network includes existing and planned sections, tracing the natural, historical, and cultural features of the Potomac River corridor, the upper Ohio River watershed, and a portion of the Rappahannock River watershed.", "Potomac Heritage National Scenic Trail" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("01469432-69c7-4e24-838d-6f74886caec9"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Pacific Northwest Trail is a hiking trail running from the Continental Divide in Montana to the Pacific Ocean on Washington's Olympic Coast. Along the way, the it crosses three national parks, seven national forests, and two other national scenic trails.", "Pacific Northwest Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Appalachian Trail is a hiking trail in the Eastern United States, extending between Springer Mountain in Georgia and Mount Katahdin in Maine. The Appalachian Trail Conservancy claims the Appalachian Trail to be the longest hiking-only trail in the world. More than three million people hike segments of the trail each year.", "Appalachian Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("4c4d7e5e-b7c9-4a0b-9337-9de4e25d208b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Florida Trail runs from Big Cypress National Preserve to Fort Pickens at Gulf Islands National Seashore, Pensacola Beach. It provides permanent non-motorized recreation opportunity for hiking and other compatible activities and is within an hour of most Floridians.", "Florida Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("65f33fea-2ac4-4419-acd6-f44281ee643d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Natchez Trace Trail is a trail whose route generally follows sections of the Natchez Trace Parkway. It commemorates the historic Natchez Trace, an ancient path that began as a wildlife and Native American trail, and has a rich history of use by colonizers, \"Kaintuck\" boatmen, post riders, and military men.", "Natchez Trace Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("6a403145-11aa-4194-9108-4bbab8700d09"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The North Country Trail is a long-distance hiking trail in the Midwestern and Northeastern United States. The trail extends from Lake Sakakawea State Park in North Dakota to the Appalachian Trail in Green Mountain National Forest in Vermont.", "North Country Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("7c51cf47-a26e-401d-85ea-b906f66b6413"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Continental Divide Trail is a trail between the U.S. border with Chihuahua, Mexico and the border with Alberta, Canada. It follows the Continental Divide of the Americas along the Rocky Mountains. Near the Canadian border the trail crosses Triple Divide Pass.", "Continental Divide Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("83c81f00-f422-499c-bb50-1d0405c2aea7"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Arizona Trail is a trail from Mexico to Utah that traverses the whole north–south length of Arizona. It begins at the Coronado National Memorial near the US–Mexico border and moves north through parts of the Huachuca, Santa Rita, and Rincon Mountains, terminating near the Arizona–Utah border in the Kaibab Plateau region. The trail is designed as a primitive trail for hiking, equestrians, mountain biking, and even cross country skiing, showcasing the wide variety of mountain ranges and ecosystems of Arizona.", "Arizona Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("a4b04586-c423-49a6-8132-852666353eb2"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Ice Age Trail is a trail that roughly follows the location of the terminal moraine from the last Ice Age. The western end of the trail is at Interstate State Park along the St. Croix River, and the eastern terminus lies at Potawatomi State Park near the city of Sturgeon Bay.", "Ice Age Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("b6d432b2-442d-4cf6-964f-b88c72bdc972"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Pacific Crest Trail is a long-distance hiking and equestrian trail closely aligned with the highest portion of the Cascade and Sierra Nevada mountain ranges. The trail's southern terminus is next to the Mexico–United States border, just south of Campo, California, and its northern terminus is on the Canada–US border.", "Pacific Crest Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The New England Trail is a trail in southern New England, which includes most of the three single trails Metacomet-Monadnock Trail, Mattabesett Trail, and Metacomet Trail. It extends through 41 communities from Guilford, Connecticut, at Long Island Sound over the Metacomet Ridge, through the highlands of the Pioneer Valley of Massachusetts, to the New Hampshire state border.", "New England Trail" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: new Guid("f5357e24-c626-4615-985b-7d836fa52369"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Potomac Heritage Trail is a trail spanning parts of the mid-Atlantic region. The trail network includes existing and planned sections, tracing the natural, historical, and cultural features of the Potomac River corridor, the upper Ohio River watershed, and a portion of the Rappahannock River watershed.", "Potomac Heritage Trail" });
        }
    }
}
