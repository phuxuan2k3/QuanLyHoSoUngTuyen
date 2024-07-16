using Ctrler;
using DAO;
using DTO;
using GUI.GUIException;
using MimeKit;
using Ctrler.DoanhNghiep;


namespace GUI;

public partial class GUI_DanhSachPhieuDK_DN : UserControl
{
    private Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;

    public GUI_DanhSachPhieuDK_DN()
    {
        InitializeComponent();
    }
    public Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
    {
        get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
        private set => _ctrler_ChiTietThongTinDangTuyen = value;
    }
    public void HienThi(Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
    {
        _ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
        DTO_ThongTinDangTuyen ttdt = new();
        List<DTO_ThongTinHoSo> ttpdk = new();
        ctrler_ChiTietThongTinDangTuyen.DanhSachHoSo(ref ttdt, ref ttpdk);

        ttpdk = ttpdk.OrderBy(x => x.UuTien)
.ToList();

        lbTTDT.Text = "Mã TTDT: " + ttdt.MaTTDT.ToString();
        tenViTri.Text = ttdt.TenViTri.ToString();
        foreach (var pdk in ttpdk)
        {
            int rowId = dsPhieuDangKy.Rows.Add();
            DataGridViewRow row = dsPhieuDangKy.Rows[rowId];
            row.Cells["_maUV"].Value = pdk.MaUV;
            row.Cells["_trangThai"].Value = pdk.TrangThai;
            row.Cells["_uuTien"].Value = pdk.UuTien;
        }

    }

    private void dsPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dsPhieuDangKy.Rows[e.RowIndex].Cells["_maUV"].Value is string maUV)
        {
            string[] parts = lbTTDT.Text.Split(':');
            if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int maTTDT))
            {
                var ctrler = new Ctrler_ThongTinPhieuDangKy(maTTDT.ToString(), maUV);
                GUI_DuyetPhieuDangKy_DN content = new();
                content.HienThi(ctrler);
                GUI_DoanhNghiep.Instance.SwitchContent(content);
            }


        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string[] parts = lbTTDT.Text.Split(':');
        if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int maTTDT))
        {
            List<DTO_UngVienDat> danhSachUngVien = DAO_PhieuDangKyUngTuyen.LayDanhSachUngVienDat(maTTDT.ToString());
            if (danhSachUngVien.Count > 0)
            {
                string noiDung = "Bạn đã đạt kết quả phỏng vấn. Vui lòng liên hệ với chúng tôi để biết thêm chi tiết.";
                GuiEmailThongBao(danhSachUngVien, noiDung);
                MessageBox.Show("Đã gửi email thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có ứng viên nào đạt kết quả để gửi thông báo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public static void GuiEmailThongBao(List<DTO_UngVienDat> danhSachUngVien, string noiDung)
    {
        string fromEmail = "nhattruonggcv@gmail.com";
        string fromPassword = "iwjl zmig psdq lqpk";

        foreach (var ungVien in danhSachUngVien)
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("NTruong", fromEmail));
            message.To.Add(new MailboxAddress(ungVien.TenUV, ungVien.Email));

            message.Subject = "Thông báo kết quả tuyển dụng";
            message.Body = new TextPart("plain")
            {
                Text = "This is a test email sent from the application."
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(fromEmail, fromPassword);
                    client.Send(message);
                    Console.WriteLine("Email sent successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to send email: " + ex.Message);
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
    public static void LogMessage(string message)
    {
        string logFilePath = "email_log.txt";
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        string[] parts = lbTTDT.Text.Split(':');
        if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int maTTDT))
        {
            GUI_DanhSachThongTinDangTuyen_DN content = new();
            content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
            GUI_DoanhNghiep.Instance.SwitchContent(content);
        }
    }

}
