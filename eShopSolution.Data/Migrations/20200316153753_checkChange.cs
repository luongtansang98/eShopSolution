using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class checkChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 22, 37, 51, 829, DateTimeKind.Local).AddTicks(4488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 6, 9, 22, 8, 124, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "371c3e7b-ea9d-4fe0-973e-b19fcef83a53");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36283b5c-175b-4e69-a0ac-3bcc45f54811", "AQAAAAEAACcQAAAAENuEQtUx++srPKXNrhrfVGIMOS7v2ywv/Sxm6gLMmoC8rL5I06jEqCCOiaJUmVWY7w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 3, 16, 22, 37, 51, 865, DateTimeKind.Local).AddTicks(7326), 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 6, 9, 22, 8, 124, DateTimeKind.Local).AddTicks(7028),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 22, 37, 51, 829, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "393b245d-ba04-4d53-88d6-cd91e0a46a28");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c4e25a8-03d5-4aa5-b29a-90b82c20a80a", "AQAAAAEAACcQAAAAEDwk57Wf+sEmN9WMAYavWITGaEE7a4m6rSmsK/igWHR11NHC9EAQJd0cJZcg0VU3MQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 3, 6, 9, 22, 8, 178, DateTimeKind.Local).AddTicks(1371), 200000m });
        }
    }
}
