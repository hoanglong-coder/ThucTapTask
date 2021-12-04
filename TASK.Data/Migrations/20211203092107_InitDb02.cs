using Microsoft.EntityFrameworkCore.Migrations;

namespace TASK.Data.Migrations
{
    public partial class InitDb02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhGiaThangs_TuanLamViecs_MaTuanLamViec",
                table: "DanhGiaThangs");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhGiaTuans_ChiTietTuans_MaChiTietTuan",
                table: "DanhGiaTuans");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhGiaTuans_DanhGiaThangs_MaDanhGiaThang",
                table: "DanhGiaTuans");

            migrationBuilder.DropIndex(
                name: "IX_DanhGiaThangs_MaTuanLamViec",
                table: "DanhGiaThangs");

            migrationBuilder.DropColumn(
                name: "MaTuanLamViec",
                table: "DanhGiaThangs");

            migrationBuilder.AlterColumn<int>(
                name: "TienDo",
                table: "DanhGiaTuans",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "MaDanhGiaThang",
                table: "DanhGiaTuans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaChiTietTuan",
                table: "DanhGiaTuans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KhoiLuong",
                table: "DanhGiaTuans",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "HoanThanh",
                table: "DanhGiaTuans",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "ChatLuong",
                table: "DanhGiaTuans",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "XepLoai",
                table: "DanhGiaThangs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<int>(
                name: "TrungBinhThang",
                table: "DanhGiaThangs",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "TienDo",
                table: "DanhGiaThangs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "KhoiLuong",
                table: "DanhGiaThangs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ChatLuong",
                table: "DanhGiaThangs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "MaThangLamViec",
                table: "DanhGiaThangs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaThangs_MaThangLamViec",
                table: "DanhGiaThangs",
                column: "MaThangLamViec");

            migrationBuilder.AddForeignKey(
                name: "FK_DanhGiaThangs_TuanLamViecs_MaThangLamViec",
                table: "DanhGiaThangs",
                column: "MaThangLamViec",
                principalTable: "TuanLamViecs",
                principalColumn: "MaThangLamViec",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhGiaTuans_ChiTietTuans_MaChiTietTuan",
                table: "DanhGiaTuans",
                column: "MaChiTietTuan",
                principalTable: "ChiTietTuans",
                principalColumn: "MaTuanChiTiet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhGiaTuans_DanhGiaThangs_MaDanhGiaThang",
                table: "DanhGiaTuans",
                column: "MaDanhGiaThang",
                principalTable: "DanhGiaThangs",
                principalColumn: "MaDanhGiaThang",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhGiaThangs_TuanLamViecs_MaThangLamViec",
                table: "DanhGiaThangs");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhGiaTuans_ChiTietTuans_MaChiTietTuan",
                table: "DanhGiaTuans");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhGiaTuans_DanhGiaThangs_MaDanhGiaThang",
                table: "DanhGiaTuans");

            migrationBuilder.DropIndex(
                name: "IX_DanhGiaThangs_MaThangLamViec",
                table: "DanhGiaThangs");

            migrationBuilder.DropColumn(
                name: "MaThangLamViec",
                table: "DanhGiaThangs");

            migrationBuilder.AlterColumn<string>(
                name: "TienDo",
                table: "DanhGiaTuans",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaDanhGiaThang",
                table: "DanhGiaTuans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaChiTietTuan",
                table: "DanhGiaTuans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "KhoiLuong",
                table: "DanhGiaTuans",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "HoanThanh",
                table: "DanhGiaTuans",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChatLuong",
                table: "DanhGiaTuans",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XepLoai",
                table: "DanhGiaThangs",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TrungBinhThang",
                table: "DanhGiaThangs",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TienDo",
                table: "DanhGiaThangs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KhoiLuong",
                table: "DanhGiaThangs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChatLuong",
                table: "DanhGiaThangs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaTuanLamViec",
                table: "DanhGiaThangs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaThangs_MaTuanLamViec",
                table: "DanhGiaThangs",
                column: "MaTuanLamViec");

            migrationBuilder.AddForeignKey(
                name: "FK_DanhGiaThangs_TuanLamViecs_MaTuanLamViec",
                table: "DanhGiaThangs",
                column: "MaTuanLamViec",
                principalTable: "TuanLamViecs",
                principalColumn: "MaThangLamViec",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhGiaTuans_ChiTietTuans_MaChiTietTuan",
                table: "DanhGiaTuans",
                column: "MaChiTietTuan",
                principalTable: "ChiTietTuans",
                principalColumn: "MaTuanChiTiet",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhGiaTuans_DanhGiaThangs_MaDanhGiaThang",
                table: "DanhGiaTuans",
                column: "MaDanhGiaThang",
                principalTable: "DanhGiaThangs",
                principalColumn: "MaDanhGiaThang",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
