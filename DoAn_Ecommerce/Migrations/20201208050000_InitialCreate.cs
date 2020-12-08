using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAn_Ecommerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<int>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHang = table.Column<int>(nullable: false),
                    NgayLapHD = table.Column<DateTime>(nullable: false),
                    TrangThaiGiaoHang = table.Column<int>(nullable: false),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHang",
                        column: x => x.KhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    SoLuongTon = table.Column<int>(nullable: false),
                    Gia = table.Column<decimal>(nullable: false),
                    Mota = table.Column<string>(nullable: true),
                    MaLoai = table.Column<int>(nullable: false),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSP_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false),
                    QuyenHan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_Quyen_QuyenHan",
                        column: x => x.QuyenHan,
                        principalTable: "Quyen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiBinhLuan = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    SanPhamBinhLuan = table.Column<int>(nullable: false),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BinhLuan_KhachHang_NguoiBinhLuan",
                        column: x => x.NguoiBinhLuan,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BinhLuan_SanPham_SanPhamBinhLuan",
                        column: x => x.SanPhamBinhLuan,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    HoaDon = table.Column<int>(nullable: false),
                    SanPham = table.Column<int>(nullable: false),
                    SoLuongMua = table.Column<int>(nullable: false),
                    DonGia = table.Column<decimal>(nullable: false),
                    ThanhTien = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => new { x.HoaDon, x.SanPham });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_HoaDon",
                        column: x => x.HoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_SanPham_SanPham",
                        column: x => x.SanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TinTuc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(nullable: true),
                    TomTat = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    NgayDang = table.Column<DateTime>(nullable: false),
                    LuotXem = table.Column<int>(nullable: false),
                    TrangThai = table.Column<bool>(nullable: false),
                    NguoiDang = table.Column<int>(nullable: false),
                    HinhAnh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTuc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TinTuc_NhanVien_NguoiDang",
                        column: x => x.NguoiDang,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_NguoiBinhLuan",
                table: "BinhLuan",
                column: "NguoiBinhLuan");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_SanPhamBinhLuan",
                table: "BinhLuan",
                column: "SanPhamBinhLuan");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_SanPham",
                table: "ChiTietHoaDon",
                column: "SanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHang",
                table: "HoaDon",
                column: "KhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_QuyenHan",
                table: "NhanVien",
                column: "QuyenHan");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoai",
                table: "SanPham",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_TinTuc_NguoiDang",
                table: "TinTuc",
                column: "NguoiDang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuan");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "TinTuc");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "Quyen");
        }
    }
}
