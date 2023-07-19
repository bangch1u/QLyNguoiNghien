using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyNguoiNghien.DomainClass;
using QLyNguoiNghien.Controler.Respository;
using QLyNguoiNghien.Controler.Service;

namespace QLyNguoiNghien.View
{
    public partial class fDataNguoiCaiNghien : Form
    {

        NguoiCaiNghienRepo _resNghien = new NguoiCaiNghienRepo();
        NguoiCaiNghienService _service = new NguoiCaiNghienService();
        Guid _idwhenclick;
        public fDataNguoiCaiNghien()
        {
            InitializeComponent();
            txtTuoi.KeyPress += txtTuoi_KeyPress; //đăng kí sự kiện KeyPress cho txtTuoi
            txtHoTen.KeyPress += txtHoTen_KeyPress_1;
            txtMaNN.KeyPress += txtMaNN_KeyPress;
            cmbPhuongPhap.SelectedIndex = 0;
            cmbPhuongPhap.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadGid(null);
        }

        private void txtHoTen_KeyPress(object? sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }
                     
        public void LoadGid(string input)
        {
            int stt = 1;
            Type type = typeof(NguoiCaiNghien);
            int slThuocTinh = type.GetProperties().Length;
            dtgNguoiCaiNghien.ColumnCount = slThuocTinh + 1;
            dtgNguoiCaiNghien.Columns[0].Name = "STT";
            dtgNguoiCaiNghien.Columns[1].Name = "Id";
            dtgNguoiCaiNghien.Columns[2].Name = "Mã";
            dtgNguoiCaiNghien.Columns[3].Name = "Tên";
            dtgNguoiCaiNghien.Columns[4].Name = "Tuổi";
            dtgNguoiCaiNghien.Columns[5].Name = "Địa chỉ";
            dtgNguoiCaiNghien.Columns[6].Name = "Loại Thuốc";
            dtgNguoiCaiNghien.Columns[7].Name = "Phương Pháp";

            dtgNguoiCaiNghien.Rows.Clear();
            //truyền data vào grid
            foreach (var item in _resNghien.GetNguoiCaiNghiens(input))
            {
                dtgNguoiCaiNghien.Rows.Add(stt++, item.GuidId, item.MaNghien, item.HoTen, item.Tuoi, item.DiaChi, item.LoaiThuoc, item.PhuongPhap);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _service.XoaNguoiCaiNghien(_idwhenclick);
            LoadGid(null);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            NguoiCaiNghien obj = new NguoiCaiNghien();
            if (txtMaNN.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã");
                return;
            }
            var list = _resNghien.GetNguoiCaiNghiens(null).ToList();
            foreach (var item in list)
            {
                if (item.MaNghien == txtMaNN.Text)
                {
                    MessageBox.Show("Mã đã tồn tại");
                    return;
                }
               
            }
            obj.MaNghien = txtMaNN.Text;
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên");
                return;
            }
            obj.HoTen = txtHoTen.Text;
        
            if (txtTuoi.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tuổi");
                return;
            }
            obj.Tuoi = Convert.ToInt32(txtTuoi.Text);
            if (rtxDiaChi.Text == "")
            {
                MessageBox.Show("Không được bỏ trống địa chỉ");
                return;
            }
            obj.DiaChi = rtxDiaChi.Text;
            if (txtLoaiThuoc.Text == "")
            {
                MessageBox.Show("Không được bỏ trống loại thuốc");
                return;
            }
            obj.LoaiThuoc = txtLoaiThuoc.Text;
            if (cmbPhuongPhap.Text == "")
            {
                MessageBox.Show("Không được bỏ trống phương pháp");
                return;
            }
            obj.PhuongPhap = cmbPhuongPhap.SelectedItem.ToString();
            _service.ThemNguoiCaiNghien(obj);

            LoadGid(null);
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.XoaNguoiCaiNghien(_idwhenclick);
            LoadGid(null);
        }

        private void dtgNguoiCaiNghien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. lấy dữ liệu dòng
            int rowIndex = e.RowIndex;
            if (rowIndex == _service.GetNguoiCaiNghiens(null).Count || rowIndex < 0) // 
            {
                return;
            }
            // lấy dữ liệu của dòng có GUid ID
            _idwhenclick = Guid.Parse(dtgNguoiCaiNghien.Rows[rowIndex].Cells[1].Value.ToString());
            //Lấy ở row mình chọn, rồi chọn vào cell 1 nơi chứa GUid ID.
            //=> tìm đối tượng
            var obj = _service.GetNguoiCaiNghiens(null).FirstOrDefault(nv =>
                    nv.GuidId == _idwhenclick);
            // Sử dụng First or default để lấy ra dữ liệu trùng GuidID
            txtMaNN.Text = dtgNguoiCaiNghien.CurrentRow.Cells[2].Value.ToString();
            txtHoTen.Text = dtgNguoiCaiNghien.CurrentRow.Cells[3].Value.ToString();
            txtTuoi.Text = dtgNguoiCaiNghien.CurrentRow.Cells[4].Value.ToString();
            rtxDiaChi.Text = dtgNguoiCaiNghien.CurrentRow.Cells[5].Value.ToString();
            txtLoaiThuoc.Text = dtgNguoiCaiNghien.CurrentRow.Cells[6].Value.ToString();
            cmbPhuongPhap.Text = dtgNguoiCaiNghien.CurrentRow.Cells[7].Value.ToString();
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            NguoiCaiNghien obj = _service.GetNguoiCaiNghiens(null).FirstOrDefault(nn => nn.GuidId == _idwhenclick);
            if (txtMaNN.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã");
                return;
            }
            obj.MaNghien = txtMaNN.Text;
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên");
                return;
            }
            obj.HoTen = txtHoTen.Text;
            if (txtTuoi.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tuổi");
                return;
            }
            obj.Tuoi = Convert.ToInt32(txtTuoi.Text);
            if (rtxDiaChi.Text == "")
            {
                MessageBox.Show("Không được bỏ trống địa chỉ");
                return;
            }
            obj.DiaChi = rtxDiaChi.Text;
            if (txtLoaiThuoc.Text == "")
            {
                MessageBox.Show("Không được bỏ trống loại thuốc");
                return;
            }
            obj.LoaiThuoc = txtLoaiThuoc.Text;
            if (cmbPhuongPhap.Text == "")
            {
                MessageBox.Show("Không được bỏ trống phương pháp");
                return;
            }
            obj.PhuongPhap = cmbPhuongPhap.SelectedItem.ToString();
            _service.SuaNguoiCaiNghien(obj);
            LoadGid(obj.HoTen);


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string input = txtSearch.Text;
            LoadGid(input);
        }      

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = txtTuoi.Text;
            int length = input.Length;
            if (length > 3)
            {
                MessageBox.Show("Làm gì có người nào trên 100 tuổi!!");
                
            }
            // Kiểm tra nếu ký tự không phải là số và không phải là ký tự điều khiển
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy sự kiện KeyPress, ngăn người dùng nhập ký tự không hợp lệ
                MessageBox.Show("Tuổi chỉ được chứa kí tự số!!");
                e.Handled = true;
            }
        }

        private void txtHoTen_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string input = txtHoTen.Text;
            int length = input.Length;
            if (length > 50)
            {
                MessageBox.Show("Độ dài của tên không được quá 50 kí tự !!! ");
                e.Handled= true;
              
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))// kiểm tra có phải là kí tự chữ hay không
            {
                // Hủy sự kiện KeyPress, ngăn người dùng nhập ký tự không hợp lệ
                MessageBox.Show("Họ tên không được chứa kí tự số!!");
                e.Handled = true;
            }
        }

        private void txtMaNN_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = txtMaNN.Text;
            int length = input.Length;
            if(length > 7 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Độ dài mã không quá 7 kí tự");
                e.Handled = true;
            }
        }
    }
}
