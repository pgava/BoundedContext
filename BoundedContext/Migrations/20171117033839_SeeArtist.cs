using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BoundedContext.Migrations
{
    public partial class SeeArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.Parse("42E72293-4C9A-40EA-BAB6-049F0A2DF6F6"), "Artist1" });
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.Parse("333F5A53-B265-4CA2-9F65-22BA3AAB5A54"), "Artist2" });
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.Parse("84B596E3-7B7C-45EF-8C7D-AA388BE99443"), "Artist3" });
            migrationBuilder.InsertData("Artists", new[] { "Id", "Name" }, new Object[] { Guid.Parse("C22B11EF-5BAE-4035-B307-FD97740F7950"), "Artist4" });

            migrationBuilder.InsertData("Musics", new[] { "Id", "ArtistId", "Name" }, new Object[] { 1, Guid.Parse("42E72293-4C9A-40EA-BAB6-049F0A2DF6F6"), "Music1" });
            migrationBuilder.InsertData("Musics", new[] { "Id", "ArtistId", "Name" }, new Object[] { 2, Guid.Parse("333F5A53-B265-4CA2-9F65-22BA3AAB5A54"), "Music2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
