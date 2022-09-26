using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumApi.DAL.Migrations
{
    public partial class UploadedFilePropertyChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UploadedFiles",
                newName: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "UploadedFiles",
                newName: "Name");
        }
    }
}
