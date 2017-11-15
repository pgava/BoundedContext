using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BoundedContext.Migrations.User
{
    public partial class AddUsersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Users", new[] { "Id", "Tfn", "Name" }, new Object[] { Guid.NewGuid(), "Tfn1",  "User1" });
            migrationBuilder.InsertData("Users", new[] { "Id", "Tfn", "Name" }, new Object[] { Guid.NewGuid(), "Tfn2", "User2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
