﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajuLanches.Migrations
{
    public partial class populate_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome, Descricao)" +
                "VALUES('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome, Descricao)" +
                "VALUES('Natural', 'Lanche feito com ingredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CATEGORIAS");
        }
    }
}