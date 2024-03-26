using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class Seeddatafordifficultiesandstates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a02d28f-886c-441d-8820-52c7c30b41c4"), "Strenuous" },
                    { new Guid("6262a129-4480-400b-a995-2f5e6754a612"), "Easy" },
                    { new Guid("b6477ddd-ef84-45a6-a884-c1804dfe1734"), "Moderate" },
                    { new Guid("df9787f4-022c-419e-9eff-1686cacb41a3"), "Moderately Strenuous" },
                    { new Guid("f683d2b7-7c10-428c-9ede-327dcf0aa316"), "Very Strenuous" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Code", "Name", "StateImageUrl" },
                values: new object[,]
                {
                    { new Guid("01b78878-662c-4957-9333-cb249504f7df"), "WY", "Wyoming", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Wyoming_in_United_States.svg/1280px-Wyoming_in_United_States.svg.png" },
                    { new Guid("03f30dba-47b7-41db-bcb3-bc60144acaa2"), "MA", "Massachusetts", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Massachusetts_in_United_States.svg/1280px-Massachusetts_in_United_States.svg.png" },
                    { new Guid("0537c8b4-319e-44e8-b761-c93769d0934f"), "CA", "California", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/California_in_United_States.svg/1280px-California_in_United_States.svg.png" },
                    { new Guid("09856d4e-a374-4fd0-8b0f-a3daa2b30bdc"), "OH", "Ohio", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Ohio_in_United_States.svg/1280px-Ohio_in_United_States.svg.png" },
                    { new Guid("09b64fb9-b780-4bbc-8ee1-3db8ec957742"), "MD", "Maryland", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Maryland_in_United_States_%28zoom%29.svg/1280px-Maryland_in_United_States_%28zoom%29.svg.png" },
                    { new Guid("10817ba2-bfe9-4a11-ae2d-46ae7602ad72"), "MI", "Michigan", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Michigan_in_United_States.svg/1280px-Michigan_in_United_States.svg.png" },
                    { new Guid("1366d132-2e14-45db-8313-b7134c984ce5"), "MS", "Mississippi", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Mississippi_in_United_States.svg/1280px-Mississippi_in_United_States.svg.png" },
                    { new Guid("1bf3fec4-c27f-4196-b76c-7a0aae8b5826"), "WA", "Washington", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Washington_in_United_States.svg/1280px-Washington_in_United_States.svg.png" },
                    { new Guid("1f5dc017-9bcc-4779-b330-61e188d760c7"), "GA", "Georgia", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Georgia_in_United_States.svg/1280px-Georgia_in_United_States.svg.png" },
                    { new Guid("2f4d1f5d-c324-45ec-995c-998241a8abab"), "CO", "Colorado", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Colorado_in_United_States.svg/1280px-Colorado_in_United_States.svg.png" },
                    { new Guid("2fa13bd0-df50-40a0-844f-ae980b46a70f"), "HI", "Hawaii", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg/1280px-Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg.png" },
                    { new Guid("3544c4ce-0605-4e2d-b0e4-76a8b2f16538"), "AK", "Alaska", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Alaska_in_United_States_%28US50%29.svg/1280px-Alaska_in_United_States_%28US50%29.svg.png" },
                    { new Guid("35b0e64c-f16b-4ea5-a986-43cfbc6bc30a"), "DE", "Delaware", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Delaware_in_United_States_%28zoom%29.svg/1280px-Delaware_in_United_States_%28zoom%29.svg.png" },
                    { new Guid("3c84f6b1-326b-4f79-8b80-7310e56dc45b"), "VA", "Virginia", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/Virginia_in_United_States.svg/1280px-Virginia_in_United_States.svg.png" },
                    { new Guid("3e724f37-e25f-4a30-b54b-c1d031b86a67"), "VT", "Vermont", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Vermont_in_United_States_%28zoom%29.svg/1280px-Vermont_in_United_States_%28zoom%29.svg.png" },
                    { new Guid("43a2421e-479c-4701-b887-8ac81769cf93"), "MO", "Missouri", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Missouri_in_United_States.svg/1280px-Missouri_in_United_States.svg.png" },
                    { new Guid("458f2015-2a52-4636-ac64-a394d09b3c41"), "NY", "New York", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/New_York_in_United_States.svg/1280px-New_York_in_United_States.svg.png" },
                    { new Guid("469f0508-57e2-4940-b3d7-a53f5c624613"), "KS", "Kansas", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Kansas_in_United_States.svg/1280px-Kansas_in_United_States.svg.png" },
                    { new Guid("47b69816-bc48-4d2a-a2fd-f0e991415a11"), "MT", "Montana", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Montana_in_United_States.svg/1280px-Montana_in_United_States.svg.png" },
                    { new Guid("4ad8a60c-79eb-4375-9335-9fd8971c2a8a"), "NV", "Nevada", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Nevada_in_United_States.svg/1280px-Nevada_in_United_States.svg.png" },
                    { new Guid("4b78c1e0-c319-49d7-869e-b23c42412453"), "SC", "South Carolina", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/South_Carolina_in_United_States.svg/1280px-South_Carolina_in_United_States.svg.png" },
                    { new Guid("52e6e5c2-a14f-41cc-8e7a-82399b1dcb30"), "ND", "North Dakota", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/North_Dakota_in_United_States.svg/1280px-North_Dakota_in_United_States.svg.png" },
                    { new Guid("5407308f-0f66-495e-bcf9-539907ce05be"), "KY", "Kentucky", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Kentucky_in_United_States.svg/1280px-Kentucky_in_United_States.svg.png" },
                    { new Guid("59e4b4c5-4c0d-4c8b-b217-85dcfbad5ec9"), "UT", "Utah", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Utah_in_United_States.svg/1280px-Utah_in_United_States.svg.png" },
                    { new Guid("59ed625c-a10b-442f-994a-f5f84c3d5979"), "PA", "Pennsylvania", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Pennsylvania_in_United_States.svg/1280px-Pennsylvania_in_United_States.svg.png" },
                    { new Guid("6555e146-e35b-4703-bc2b-9eb7ff1ece88"), "TN", "Tennessee", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Tennessee_in_United_States.svg/1280px-Tennessee_in_United_States.svg.png" },
                    { new Guid("6709e992-470c-46f1-82bd-f100527662ed"), "TX", "Texas", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Texas_in_United_States.svg/1280px-Texas_in_United_States.svg.png" },
                    { new Guid("6cfc5be5-7117-4692-abb3-415c78f20a59"), "AR", "Arkansas", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Arkansas_in_United_States.svg/1280px-Arkansas_in_United_States.svg.png" },
                    { new Guid("6ff3a5c0-f6bb-4155-841a-f6307f6207a9"), "FL", "Florida", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Florida_in_United_States.svg/1280px-Florida_in_United_States.svg.png" },
                    { new Guid("73c07abe-c049-4b6e-8ab7-99cff7dcc8dc"), "WI", "Wisconsin", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Wisconsin_in_United_States.svg/1280px-Wisconsin_in_United_States.svg.png" },
                    { new Guid("762600ea-3bba-440b-bfd8-1882eb6f7964"), "OK", "Oklahoma", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Oklahoma_in_United_States.svg/1280px-Oklahoma_in_United_States.svg.png" },
                    { new Guid("7ac1ecd0-c771-44db-9eab-3dda80fe9069"), "IA", "Iowa", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Iowa_in_United_States.svg/1280px-Iowa_in_United_States.svg.png" },
                    { new Guid("7ee744c3-6eff-43c4-b4f1-f1c7a11efe2a"), "WV", "West Virginia", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/West_Virginia_in_United_States.svg/1280px-West_Virginia_in_United_States.svg.png" },
                    { new Guid("854dec35-37e8-4ea7-bc9f-168d36ba8c86"), "AZ", "Arizona", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Arizona_in_United_States.svg/1280px-Arizona_in_United_States.svg.png" },
                    { new Guid("856a70b8-f381-4a58-bd98-cc4910b86dea"), "NE", "Nebraska", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Nebraska_in_United_States.svg/1280px-Nebraska_in_United_States.svg.png" },
                    { new Guid("8a2f49bb-41ae-4e76-9c05-ffa5b91d453c"), "NC", "North Carolina", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/North_Carolina_in_United_States.svg/1280px-North_Carolina_in_United_States.svg.png" },
                    { new Guid("967feb0a-b817-436e-b972-3596ea0fc867"), "CT", "Connecticut", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Connecticut_in_United_States_%28zoom%29.svg/1280px-Connecticut_in_United_States_%28zoom%29.svg.png" },
                    { new Guid("9f378ece-c448-4f8d-bd5d-4edec7f86318"), "IN", "Indiana", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Indiana_in_United_States.svg/1280px-Indiana_in_United_States.svg.png" },
                    { new Guid("af74ab9f-c529-48f5-ab29-b5620a753c97"), "RI", "Rhode Island", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg/1280px-Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg.png" },
                    { new Guid("b4037d9f-3c34-41f2-9d15-a79ca34d5dd8"), "ID", "Idaho", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Idaho_in_United_States.svg/1280px-Idaho_in_United_States.svg.png" },
                    { new Guid("b7451c5d-3523-4ec7-bc31-decae478a3d2"), "OR", "Oregon", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Oregon_in_United_States.svg/1280px-Oregon_in_United_States.svg.png" },
                    { new Guid("b9a02294-cca4-46b8-a225-72f7ba6932a6"), "LA", "Louisiana", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Louisiana_in_United_States.svg/1280px-Louisiana_in_United_States.svg.png" },
                    { new Guid("c717f0e4-9c16-47a5-bbd5-5430dd0b50b2"), "ME", "Maine", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Maine_in_United_States.svg/1280px-Maine_in_United_States.svg.png" },
                    { new Guid("ca0eb5ca-1793-4818-b80b-60b6d9714e3a"), "MN", "Minnesota", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Minnesota_in_United_States.svg/1280px-Minnesota_in_United_States.svg.png" },
                    { new Guid("d1920c2b-4e46-44fd-9a03-2707d5b6feb4"), "NJ", "New Jersey", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/New_Jersey_in_United_States_%28zoom%29.svg/1280px-New_Jersey_in_United_States_%28zoom%29.svg.png" },
                    { new Guid("d8b404e7-8ab2-45d6-bcb3-bf897a2e81da"), "SD", "South Dakota", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/South_Dakota_in_United_States.svg/1280px-South_Dakota_in_United_States.svg.png" },
                    { new Guid("e14d2f64-2f75-4f89-b690-41132ed40627"), "NH", "New Hampshire", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/New_Hampshire_in_United_States.svg/1280px-New_Hampshire_in_United_States.svg.png" },
                    { new Guid("e3b504bf-70d5-4624-aaf8-a4b570cf89bf"), "NM", "New Mexico", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/New_Mexico_in_United_States.svg/1280px-New_Mexico_in_United_States.svg.png" },
                    { new Guid("e7cb93a5-be60-4dfb-a9be-0a956bdf8195"), "AL", "Alabama", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Alabama_in_United_States.svg/1280px-Alabama_in_United_States.svg.png" },
                    { new Guid("f54fde70-973f-40b5-9aa9-e2ee19f45064"), "IL", "Illinois", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Illinois_in_United_States.svg/1280px-Illinois_in_United_States.svg.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("0a02d28f-886c-441d-8820-52c7c30b41c4"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("6262a129-4480-400b-a995-2f5e6754a612"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b6477ddd-ef84-45a6-a884-c1804dfe1734"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("df9787f4-022c-419e-9eff-1686cacb41a3"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f683d2b7-7c10-428c-9ede-327dcf0aa316"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("01b78878-662c-4957-9333-cb249504f7df"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("03f30dba-47b7-41db-bcb3-bc60144acaa2"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("0537c8b4-319e-44e8-b761-c93769d0934f"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("09856d4e-a374-4fd0-8b0f-a3daa2b30bdc"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("09b64fb9-b780-4bbc-8ee1-3db8ec957742"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("10817ba2-bfe9-4a11-ae2d-46ae7602ad72"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("1366d132-2e14-45db-8313-b7134c984ce5"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("1bf3fec4-c27f-4196-b76c-7a0aae8b5826"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("1f5dc017-9bcc-4779-b330-61e188d760c7"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("2f4d1f5d-c324-45ec-995c-998241a8abab"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("2fa13bd0-df50-40a0-844f-ae980b46a70f"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("3544c4ce-0605-4e2d-b0e4-76a8b2f16538"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("35b0e64c-f16b-4ea5-a986-43cfbc6bc30a"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("3c84f6b1-326b-4f79-8b80-7310e56dc45b"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("3e724f37-e25f-4a30-b54b-c1d031b86a67"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("43a2421e-479c-4701-b887-8ac81769cf93"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("458f2015-2a52-4636-ac64-a394d09b3c41"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("469f0508-57e2-4940-b3d7-a53f5c624613"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("47b69816-bc48-4d2a-a2fd-f0e991415a11"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("4ad8a60c-79eb-4375-9335-9fd8971c2a8a"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("4b78c1e0-c319-49d7-869e-b23c42412453"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("52e6e5c2-a14f-41cc-8e7a-82399b1dcb30"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("5407308f-0f66-495e-bcf9-539907ce05be"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("59e4b4c5-4c0d-4c8b-b217-85dcfbad5ec9"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("59ed625c-a10b-442f-994a-f5f84c3d5979"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("6555e146-e35b-4703-bc2b-9eb7ff1ece88"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("6709e992-470c-46f1-82bd-f100527662ed"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("6cfc5be5-7117-4692-abb3-415c78f20a59"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("6ff3a5c0-f6bb-4155-841a-f6307f6207a9"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("73c07abe-c049-4b6e-8ab7-99cff7dcc8dc"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("762600ea-3bba-440b-bfd8-1882eb6f7964"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("7ac1ecd0-c771-44db-9eab-3dda80fe9069"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("7ee744c3-6eff-43c4-b4f1-f1c7a11efe2a"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("854dec35-37e8-4ea7-bc9f-168d36ba8c86"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("856a70b8-f381-4a58-bd98-cc4910b86dea"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("8a2f49bb-41ae-4e76-9c05-ffa5b91d453c"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("967feb0a-b817-436e-b972-3596ea0fc867"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("9f378ece-c448-4f8d-bd5d-4edec7f86318"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("af74ab9f-c529-48f5-ab29-b5620a753c97"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("b4037d9f-3c34-41f2-9d15-a79ca34d5dd8"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("b7451c5d-3523-4ec7-bc31-decae478a3d2"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("b9a02294-cca4-46b8-a225-72f7ba6932a6"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("c717f0e4-9c16-47a5-bbd5-5430dd0b50b2"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("ca0eb5ca-1793-4818-b80b-60b6d9714e3a"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("d1920c2b-4e46-44fd-9a03-2707d5b6feb4"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("d8b404e7-8ab2-45d6-bcb3-bf897a2e81da"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("e14d2f64-2f75-4f89-b690-41132ed40627"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("e3b504bf-70d5-4624-aaf8-a4b570cf89bf"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("e7cb93a5-be60-4dfb-a9be-0a956bdf8195"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("f54fde70-973f-40b5-9aa9-e2ee19f45064"));
        }
    }
}
