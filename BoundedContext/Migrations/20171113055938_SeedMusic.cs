using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BoundedContext.Migrations
{
    public partial class SeedMusic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musics", new[] { "Id", "ArtistId", "Name" }, new Object[] { 1, Guid.NewGuid(), "Music1" });
            migrationBuilder.InsertData("Musics", new[] { "Id", "ArtistId", "Name" }, new Object[] { 2, Guid.NewGuid(), "Music2" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
