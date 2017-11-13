using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BoundedContext.Migrations
{
    public partial class SeedArtistContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.NewGuid(), "Artist1" });
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.NewGuid(), "Artist2" });
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.NewGuid(), "Artist3" });
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.NewGuid(), "Artist4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
