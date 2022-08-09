using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_2.Migrations
{
    public partial class nocheckfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
               ("ALTER TABLE Pets CHECK CONSTRAINT FK_Pets_Pessoas_PersonId");
        }
    }
}
