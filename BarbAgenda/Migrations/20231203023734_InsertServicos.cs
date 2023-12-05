using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarbAgenda.Migrations
{
    /// <inheritdoc />
    public partial class InsertServicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Servicos",
               columns: new[] { "Nome", "Preco" },
               values: new object[,]
               {
                    { "Cabelo", 45.00m },
                    { "Barba", 30.00m },
                    { "Cabelo + Barba", 70.00m },
                    { "Cabelo + Sobrancelha", 50.00m },
                    { "Sobrancelha", 10.00m },
                    { "Completo", 80.00m }
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //Não é necessário fazer um down nessa migration
        }
    }
}
