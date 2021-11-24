using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TASK.Data.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuAns",
                columns: table => new
                {
                    MaDuAn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDuAn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuAns", x => x.MaDuAn);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    MaModule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenModule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.MaModule);
                });

            migrationBuilder.CreateTable(
                name: "Quyens",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyens", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenUser = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.MaUser);
                });

            migrationBuilder.CreateTable(
                name: "TuanLamViecs",
                columns: table => new
                {
                    MaThangLamViec = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaTri = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaDuAn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuanLamViecs", x => x.MaThangLamViec);
                    table.ForeignKey(
                        name: "FK_TuanLamViecs_DuAns_MaDuAn",
                        column: x => x.MaDuAn,
                        principalTable: "DuAns",
                        principalColumn: "MaDuAn",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDuAns",
                columns: table => new
                {
                    MaDuAn = table.Column<int>(type: "int", nullable: false),
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaQuyen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDuAns", x => new { x.MaDuAn, x.MaUser });
                    table.ForeignKey(
                        name: "FK_ChiTietDuAns_DuAns_MaDuAn",
                        column: x => x.MaDuAn,
                        principalTable: "DuAns",
                        principalColumn: "MaDuAn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDuAns_Quyens_MaQuyen",
                        column: x => x.MaQuyen,
                        principalTable: "Quyens",
                        principalColumn: "MaQuyen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietDuAns_Users_MaUser",
                        column: x => x.MaUser,
                        principalTable: "Users",
                        principalColumn: "MaUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    MaTodo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayGiao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayDenHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MaDuAn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.MaTodo);
                    table.ForeignKey(
                        name: "FK_ToDos_DuAns_MaDuAn",
                        column: x => x.MaDuAn,
                        principalTable: "DuAns",
                        principalColumn: "MaDuAn",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ToDos_Users_MaUser",
                        column: x => x.MaUser,
                        principalTable: "Users",
                        principalColumn: "MaUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTuans",
                columns: table => new
                {
                    MaTuanChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTuan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiaTri = table.Column<int>(type: "int", nullable: false),
                    SoGioLam = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MaThangLamViec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTuans", x => x.MaTuanChiTiet);
                    table.ForeignKey(
                        name: "FK_ChiTietTuans_TuanLamViecs_MaThangLamViec",
                        column: x => x.MaThangLamViec,
                        principalTable: "TuanLamViecs",
                        principalColumn: "MaThangLamViec",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaThangs",
                columns: table => new
                {
                    MaDanhGiaThang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoiLuong = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TienDo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ChatLuong = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TrungBinhThang = table.Column<float>(type: "real", nullable: false),
                    XepLoai = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    NhanXet = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MaTuanLamViec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaThangs", x => x.MaDanhGiaThang);
                    table.ForeignKey(
                        name: "FK_DanhGiaThangs_TuanLamViecs_MaTuanLamViec",
                        column: x => x.MaTuanLamViec,
                        principalTable: "TuanLamViecs",
                        principalColumn: "MaThangLamViec",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CongViecs",
                columns: table => new
                {
                    MaCongViec = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaModule = table.Column<int>(type: "int", nullable: true),
                    IssueURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TenIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenCongViec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nguon = table.Column<int>(type: "int", nullable: false),
                    ThoiGianLam = table.Column<int>(type: "int", nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaThangLamViec = table.Column<int>(type: "int", nullable: true),
                    MaTuanChiTiet = table.Column<int>(type: "int", nullable: true),
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecs", x => x.MaCongViec);
                    table.ForeignKey(
                        name: "FK_CongViecs_ChiTietTuans_MaTuanChiTiet",
                        column: x => x.MaTuanChiTiet,
                        principalTable: "ChiTietTuans",
                        principalColumn: "MaTuanChiTiet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongViecs_Modules_MaModule",
                        column: x => x.MaModule,
                        principalTable: "Modules",
                        principalColumn: "MaModule",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongViecs_TuanLamViecs_MaThangLamViec",
                        column: x => x.MaThangLamViec,
                        principalTable: "TuanLamViecs",
                        principalColumn: "MaThangLamViec",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongViecs_Users_MaUser",
                        column: x => x.MaUser,
                        principalTable: "Users",
                        principalColumn: "MaUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaTuans",
                columns: table => new
                {
                    MaDanhGiaTuan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoanThanh = table.Column<float>(type: "real", nullable: false),
                    KhoiLuong = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TienDo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ChatLuong = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LoiTrongTuan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NhanXetTuan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MaDanhGiaThang = table.Column<int>(type: "int", nullable: true),
                    MaChiTietTuan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaTuans", x => x.MaDanhGiaTuan);
                    table.ForeignKey(
                        name: "FK_DanhGiaTuans_ChiTietTuans_MaChiTietTuan",
                        column: x => x.MaChiTietTuan,
                        principalTable: "ChiTietTuans",
                        principalColumn: "MaTuanChiTiet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhGiaTuans_DanhGiaThangs_MaDanhGiaThang",
                        column: x => x.MaDanhGiaThang,
                        principalTable: "DanhGiaThangs",
                        principalColumn: "MaDanhGiaThang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDuAns_MaQuyen",
                table: "ChiTietDuAns",
                column: "MaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDuAns_MaUser",
                table: "ChiTietDuAns",
                column: "MaUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTuans_MaThangLamViec",
                table: "ChiTietTuans",
                column: "MaThangLamViec");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaModule",
                table: "CongViecs",
                column: "MaModule");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaThangLamViec",
                table: "CongViecs",
                column: "MaThangLamViec");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaTuanChiTiet",
                table: "CongViecs",
                column: "MaTuanChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaUser",
                table: "CongViecs",
                column: "MaUser");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaThangs_MaTuanLamViec",
                table: "DanhGiaThangs",
                column: "MaTuanLamViec");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaTuans_MaChiTietTuan",
                table: "DanhGiaTuans",
                column: "MaChiTietTuan");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaTuans_MaDanhGiaThang",
                table: "DanhGiaTuans",
                column: "MaDanhGiaThang");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_MaDuAn",
                table: "ToDos",
                column: "MaDuAn");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_MaUser",
                table: "ToDos",
                column: "MaUser");

            migrationBuilder.CreateIndex(
                name: "IX_TuanLamViecs_MaDuAn",
                table: "TuanLamViecs",
                column: "MaDuAn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDuAns");

            migrationBuilder.DropTable(
                name: "CongViecs");

            migrationBuilder.DropTable(
                name: "DanhGiaTuans");

            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "Quyens");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "ChiTietTuans");

            migrationBuilder.DropTable(
                name: "DanhGiaThangs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TuanLamViecs");

            migrationBuilder.DropTable(
                name: "DuAns");
        }
    }
}
