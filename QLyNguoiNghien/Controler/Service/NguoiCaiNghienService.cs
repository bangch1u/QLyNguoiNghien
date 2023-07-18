using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyNguoiNghien.Context;
using QLyNguoiNghien.DomainClass;
using QLyNguoiNghien.Controler.Respository;
using QLyNguoiNghien.View;

namespace QLyNguoiNghien.Controler.Service
{
    internal class NguoiCaiNghienService
    {
        NguoiCaiNghienRepo _repos;

        public NguoiCaiNghienService()
        {
            _repos = new NguoiCaiNghienRepo();
           
        }
        public void ThemNguoiCaiNghien(NguoiCaiNghien obj)
        {
            if (_repos.AddNguoiCaiNghien(obj) == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void XoaNguoiCaiNghien(Guid guiID)
        {
            var obj = _repos.GetNguoiCaiNghiens(null).FirstOrDefault(nn => nn.GuidId == guiID);
            if (_repos.DeleteNguoiCaiNghien(obj) == true) 
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        public void SuaNguoiCaiNghien(NguoiCaiNghien obj)
        {
            //NguoiCaiNghien nguoiNghien = GetNguoiCaiNghiens(null).FirstOrDefault(ncn => ncn.GuidId == obj.GuidId);
            //nguoiNghien.HoTen = obj.HoTen;
            //nguoiNghien.MaNghien = obj.MaNghien;
            //nguoiNghien.Tuoi = obj.Tuoi;
            //nguoiNghien.DiaChi = obj.DiaChi;
            //nguoiNghien.LoaiThuoc = obj.LoaiThuoc;
            //nguoiNghien.PhuongPhap = obj.PhuongPhap;
            

            if (_repos.UpdateNguoiCaiNghien(obj) == true)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            
        }
        public List<NguoiCaiNghien> GetNguoiCaiNghiens(string input)
        {
            return _repos.GetNguoiCaiNghiens(input);
        }


    }
}
