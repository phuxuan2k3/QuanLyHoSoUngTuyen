using DTO;
//using iText.Kernel.Pdf;
//using iText.Layout;

namespace Ctrler.Sub;

public class Ctrler_PDF
{
	public static void Xuat(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_HoaDon hoaDon, IEnumerable<DTO_ChiTietHoaDon> chiTietHoaDons, string outPath)
	{
		using FileStream fs = new FileStream(outPath, FileMode.Create);
		//Document doc = new Document(new PdfDocument(new PdfWriter(outPath)));

		// Khai bao xuat hoa don sang PDF o day (nho xem cai ui: https://www.figma.com/design/yghrLwwIifLcGmLByToHW1/QuanLyHoSoUngTuyen?node-id=0-1&t=mJzrmRXODh28RUmv-0)

		//doc.Close();
	}
}
