using Microsoft.EntityFrameworkCore.Migrations;

namespace examenEmpleados.Data.Migrations
{
    public partial class AgregarEmpleados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeNombres = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EmployeeApodo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeDireccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeCodigoPostal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeTelefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeCelular = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeFax = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EmployeeObservaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
