using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTickets.Web.Migrations
{
    /// <inheritdoc />
    public partial class newseeddataformovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeatureImage",
                table: "Actors_Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "FeatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 },
                column: "FeatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 19, 2, 52, 0, 775, DateTimeKind.Local).AddTicks(1019), new DateTime(2025, 2, 27, 2, 52, 0, 775, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[] { 2, 1, "This is the Life movie description", new DateTime(2025, 3, 19, 2, 52, 0, 775, DateTimeKind.Local).AddTicks(1023), "http://dotnethow.net/images/movies/movie-3.jpeg", 3, "Death", 39.5, 1, new DateTime(2025, 2, 27, 2, 52, 0, 775, DateTimeKind.Local).AddTicks(1022) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "FeatureImage",
                table: "Actors_Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 12, 6, 23, 4, 294, DateTimeKind.Local).AddTicks(2493), new DateTime(2025, 2, 20, 6, 23, 4, 294, DateTimeKind.Local).AddTicks(2479) });
        }
    }
}
