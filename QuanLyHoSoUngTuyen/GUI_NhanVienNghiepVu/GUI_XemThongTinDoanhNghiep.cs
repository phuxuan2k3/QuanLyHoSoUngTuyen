using Ctrler;
using Ctrler.NhanVienNghiepVu;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_XemThongTinDoanhNghiep : UserControl
    {
        public GUI_XemThongTinDoanhNghiep()
        {
            InitializeComponent();
            HienThi();
        }

        private void HienThi()
        {
            var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiep();
            dsDN.DataSource = lsDN;
        }

        private void radChuaXacThuc_CheckedChanged(object sender, EventArgs e)
        {
            var rad = sender as RadioButton;
            if (rad!.Checked)
            {
                var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepChuaXacThuc();
                dsDN.DataSource = lsDN;
            }
        }

        private void radKhongHopLe_CheckedChanged(object sender, EventArgs e)
        {
            var rad = sender as RadioButton;
            if (rad!.Checked)
            {
                var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepKhongHopLe();
                dsDN.DataSource = lsDN;
            }
        }

        private void radHopLe_CheckedChanged(object sender, EventArgs e)
        {
            var rad = sender as RadioButton;
            if (rad!.Checked)
            {
                var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepHopLe();
                dsDN.DataSource = lsDN;
            }
        }

        private void radTiemNang_CheckedChanged(object sender, EventArgs e)
        {
            var rad = sender as RadioButton;
            if (rad!.Checked)
            {
                var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepTiemNang();
                dsDN.DataSource = lsDN;
            }
        }
        private void LocDoanhNghiep()
        {
            foreach (var con in Controls)
            {
                if (con is RadioButton radio)
                {
                    if (radio.Checked)
                    {
                        switch (radio.Text)
                        {
                            case "Không hợp lệ":
                                {
                                    var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepKhongHopLe();
                                    dsDN.DataSource = lsDN;
                                }
                                break;
                            case "Hợp lệ":
                                {
                                    var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepHopLe();
                                    dsDN.DataSource = lsDN;
                                }
                                break;
                            case "Chưa xác thực":
                                {
                                    var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepChuaXacThuc();
                                    dsDN.DataSource = lsDN;
                                }
                                break;
                            case "Tiềm năng":
                                {
                                    var lsDN = Ctrler_XemThongTinDoanhNghiep.LayDanhSachDoanhNghiepTiemNang();
                                    dsDN.DataSource = lsDN;
                                }
                                break;
                        }
                    }
                    return;
                }
            }
        }

        private void dsDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var dnHienTai = (dsDN.DataSource as List<DTO_DoanhNghiep>)![e.RowIndex];
                var lsUD = Ctrler_XemThongTinDoanhNghiep.LayDanhSachUuDai(dnHienTai.MaDN);
                dsUD.DataSource = lsUD;
            }
        }
    }
}
