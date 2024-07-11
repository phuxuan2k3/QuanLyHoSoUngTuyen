using DTO;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Exceptions;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Utilis;

namespace Ctrler.Sub;

public class Ctrler_PDF
{
	public static void Xuat(DTO_DoanhNghiep doanhNghiep, DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_HoaDon hoaDon, IEnumerable<DTO_ChiTietHoaDon> chiTietHoaDons, string outPath)
	{
		// Ensure the output directory exists
		var directory = Path.GetDirectoryName(outPath) ?? "";
		if (!Directory.Exists(directory))
		{
			Directory.CreateDirectory(directory);
		}

		string fontPath = Path.Combine("Fonts", "OpenSans-VariableFont_wdth,wght.ttf");

		// Create a PDF writer
		using (PdfWriter writer = new PdfWriter(outPath))
		{
			// Initialize a PDF document
			using (PdfDocument pdf = new PdfDocument(writer))
			{
				// Initialize a document
				using (Document document = new Document(pdf))
				{
					// Load Vietnamese font
					PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

					// Add title
					document.Add(new Paragraph("CÔNG TY TUYỂN DỤNG ABC")
						.SetTextAlignment(TextAlignment.CENTER)
						.SetFont(font)
						.SetBold()
						.SetFontSize(24));

					// Add space
					document.Add(new Paragraph("\n"));

					// Add Enterprise Information
					document.Add(new Paragraph("Thông Tin Doanh Nghiệp")
						.SetBold()
						.SetFont(font));

					Table enterpriseTable = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth();
					enterpriseTable.AddCell(new Cell().Add(new Paragraph("Tên Doanh Nghiệp").SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph(doanhNghiep.TenDN).SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph("Mã Số Thuế").SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph(doanhNghiep.MaSoThue).SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph("Người Đại Diện").SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph(doanhNghiep.NguoiDaiDien).SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph("Địa Chỉ").SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph(doanhNghiep.DiaChi).SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph("Email").SetFont(font)));
					enterpriseTable.AddCell(new Cell().Add(new Paragraph(doanhNghiep.Email).SetFont(font)));
					document.Add(enterpriseTable);

					// Add space
					document.Add(new Paragraph("\n"));

					// Add Recruitment Information
					document.Add(new Paragraph("Thông Tin Đăng Tuyển")
						.SetBold()
						.SetFont(font));

					Table recruitmentTable = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth();
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Mã Đăng Tuyển").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(thongTinDangTuyen.MaTTDT).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Số Ngày Đăng Tuyển").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(thongTinDangTuyen.SoNgayDangTuyen.ToString()).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Hình Thức Đăng Tuyển").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(hinhThucDangTuyen.TenHinhThuc).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Giá Cho Hình Thức Đăng Tuyển").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(hinhThucDangTuyen.Gia.ToVNDString()).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Mô Tả Cho Hình Thức Đăng Tuyển").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(hinhThucDangTuyen.MoTa).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Thời Gian Đăng Tuyển").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(thongTinDangTuyen.ThoiGianDangTuyen.ToDateString()).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Tên Vị Trí Tuyển Dụng").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(thongTinDangTuyen.TenViTri).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Số Lượng Tuyển Dụng").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(thongTinDangTuyen.SoLuong.ToString()).SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph("Yêu Cầu").SetFont(font)));
					recruitmentTable.AddCell(new Cell().Add(new Paragraph(thongTinDangTuyen.YeuCau).SetFont(font)));
					document.Add(recruitmentTable);

					// Add space
					document.Add(new Paragraph("\n"));

					// Add Invoice Information
					document.Add(new Paragraph("Thông Tin Hóa Đơn")
						.SetBold()
						.SetFont(font));

					Table invoiceTable = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth();
					invoiceTable.AddCell(new Cell().Add(new Paragraph("Tổng Số Tiền").SetFont(font)));
					invoiceTable.AddCell(new Cell().Add(new Paragraph(hoaDon.TongTien.ToVNDString()).SetFont(font)));
					invoiceTable.AddCell(new Cell().Add(new Paragraph("Cách Thức Thanh Toán").SetFont(font)));
					invoiceTable.AddCell(new Cell().Add(new Paragraph(hoaDon.CachThucThanhToan.ToDisplayString()).SetFont(font)));
					invoiceTable.AddCell(new Cell().Add(new Paragraph("Ngày Lập Hóa Đơn").SetFont(font)));
					invoiceTable.AddCell(new Cell().Add(new Paragraph(hoaDon.NgayLap.ToDateString()).SetFont(font)));
					document.Add(invoiceTable);

					// Add space
					document.Add(new Paragraph("\n"));

					// Add Invoice Details
					document.Add(new Paragraph("Chi Tiết Hóa Đơn")
						.SetBold()
						.SetFont(font));

					Table detailsTable = new Table(UnitValue.CreatePercentArray(3)).UseAllAvailableWidth();
					detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Lần Thanh Toán").SetFont(font)));
					detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số Tiền Thanh Toán").SetFont(font)));
					detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Ngày Thanh Toán").SetFont(font)));

					foreach (var ct in chiTietHoaDons)
					{
						detailsTable.AddCell(new Cell().Add(new Paragraph(ct.LanThanhToan.ToString()).SetFont(font)));
						detailsTable.AddCell(new Cell().Add(new Paragraph(ct.SoTienCanThanhToan.ToVNDString()).SetFont(font)));
						detailsTable.AddCell(new Cell().Add(new Paragraph(ct.NgayThanhToan.ToDateString()).SetFont(font)));
					}

					document.Add(detailsTable);

					// Add thank you note
					document.Add(new Paragraph("\nCảm ơn quý khách hàng!")
						.SetTextAlignment(TextAlignment.CENTER)
						.SetFont(font));
				}
			}
		}
	}
}
