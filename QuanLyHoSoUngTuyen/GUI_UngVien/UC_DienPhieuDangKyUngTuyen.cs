using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC
{
    public partial class UC_DienPhieuDangKyUngTuyen : UserControl
    {
        public static string mattdt = "", mauv = "";
        public UC_DienPhieuDangKyUngTuyen()
        {
            InitializeComponent();
            Txt_MaViTriUngTuyen.Text = UC_TraCuuViTriUngTuyen.dsViTriTimDuoc_MaViTri;
            Txt_ViTriUngTuyen.Text = UC_TraCuuViTriUngTuyen.dsViTriTimDuoc_TenViTri;

            mattdt = Txt_MaViTriUngTuyen.Text;
            mauv = Txt_CCCD.Text.ToString();
        }

        private void Btn_DienPhieu_Click(object sender, EventArgs e)
        {
            Utilis.QuickTryCatch.ExcuteWithTryCatchAndShowMessageBox(() =>
            {
                // Ensure that Txt_MaViTriUngTuyen.Text can be converted to an integer
                if (int.TryParse(Txt_MaViTriUngTuyen.Text, out int maViTriUngTuyen))
                {
                    // Call the Them_Phieu method and check the result
                    if (BUS_PhieuDangKyUngTuyen.Them_Phieu(maViTriUngTuyen, Txt_CCCD.Text, Txt_HoVaTenUngVien.Text) == 1)
                    {
                        // Show the next form
                        mattdt = Txt_MaViTriUngTuyen.Text;
                        mauv = Txt_CCCD.Text.ToString();
                        UC_NopHoSoUngTuyen uc = new UC_NopHoSoUngTuyen(QuayLaiHome!);
                        uc.Dock = DockStyle.Fill;
                        this.Controls.Clear();
                        this.Controls.Add(uc);
                        uc.BringToFront();
                    }
                    else
                    {
                        // Show error message if adding the record failed
                        MessageBox.Show("Không thể thêm phiếu đăng ký ứng tuyển. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Show error message if Txt_MaViTriUngTuyen.Text is not a valid integer
                    MessageBox.Show("Mã vị trí ứng tuyển phải là số nguyên hợp lệ.", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }, "Không thể thêm phiếu đăng ký ứng tuyển. Vui lòng kiểm tra lại thông tin.");
        }

        private void QuayLaiHome(object sender, EventArgs e)
        {
            UC_Home_UngVien uc = new UC_Home_UngVien();
            uc.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn dừng hành động điền phiếu đăng ký?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            UC_Home_UngVien uc = new UC_Home_UngVien();

            uc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
