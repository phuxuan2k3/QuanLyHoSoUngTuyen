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
    public partial class UC_NopHoSoUngTuyen : UserControl
    {
        public UC_NopHoSoUngTuyen()
        {
            InitializeComponent();
            rTxt_yeucau.Text = UC_TraCuuViTriUngTuyen.yeucau;
       
            Load_HS(UC_DienPhieuDangKyUngTuyen.mauv);
        }

        private void Load_HS(string mauv)
        {
            List<string> tmp = BUS_HS_CT_BC.Load_HS(mauv);

            if (tmp != null && tmp.Count > 0)
            {
                foreach (var item in tmp)
                {
                    ckLbx_HSCTBC.Items.Add(item);
                }
            }
        }

        private void Xoa_Phieu(int mattdt, string mauv)
        {
            if (BUS_CT_PDKUT.Xoa_Phieu(mattdt, mauv) == 1)
            {
                MessageBox.Show("Hủy phiếu đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            else
            {
                // Show error message if adding the record failed
                MessageBox.Show("Không thể hủy phiếu đăng ký ứng tuyển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(UC_DienPhieuDangKyUngTuyen.mattdt, out int maViTriUngTuyen))
            {
                for (int i = 0; i < ckLbx_HSCTBC.Items.Count; i++)
                {
                    if (ckLbx_HSCTBC.GetItemChecked(i))
                    {
                        if (BUS_CT_PDKUT.Them(maViTriUngTuyen, UC_DienPhieuDangKyUngTuyen.mauv, ckLbx_HSCTBC.Items[i].ToString()!) == 0)
                        {

                            Xoa_Phieu(maViTriUngTuyen, UC_DienPhieuDangKyUngTuyen.mauv);
                            MessageBox.Show("Không thể đăng ký ứng tuyển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
            }
            MessageBox.Show("Thêm phiếu ứng tuyển thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        
        private void home_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(UC_DienPhieuDangKyUngTuyen.mattdt, out int maViTriUngTuyen))
            {
                // Call the Xoa_Phieu method and check the result
                Xoa_Phieu(maViTriUngTuyen, UC_DienPhieuDangKyUngTuyen.mauv);
                this.Controls.Clear();
                
                
            }
            else
            {
                // Show error message if Txt_MaViTriUngTuyen.Text is not a valid integer
                MessageBox.Show("Mã vị trí ứng tuyển phải là số nguyên hợp lệ.", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
