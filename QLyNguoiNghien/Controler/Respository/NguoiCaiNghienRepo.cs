using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyNguoiNghien.Context;
using QLyNguoiNghien.DomainClass;


namespace QLyNguoiNghien.Controler.Respository
{
    internal class NguoiCaiNghienRepo
    {
        private DBContext _context;
        public NguoiCaiNghienRepo()
        {
            _context = new DBContext();
        }
        public List<NguoiCaiNghien> GetNguoiCaiNghiens(string search)
        {
            if (search == null)
            {
                List<NguoiCaiNghien> data = _context.NguoiCaiNghiens.ToList();
            return data;
            }
            return _context.NguoiCaiNghiens.Where(nn => nn.MaNghien.StartsWith(search) || nn.HoTen.StartsWith(search)).ToList();
        }
        public bool AddNguoiCaiNghien(NguoiCaiNghien nguoiCaiNghien)
        {
            if (nguoiCaiNghien == null)
            {
                return false;
            }
            else
            {
                nguoiCaiNghien.GuidId = Guid.NewGuid();
                _context.Add(nguoiCaiNghien);
                _context.SaveChanges();
                return true;
            }
        }
        public bool DeleteNguoiCaiNghien(NguoiCaiNghien nguoiCaiNghien)
        {
            if (nguoiCaiNghien == null)
            {
                return false;
            }
            else
            {
                _context.Remove(nguoiCaiNghien);
                _context.SaveChanges();
                return true;
            }
        }
        public bool UpdateNguoiCaiNghien(NguoiCaiNghien nguoiCaiNgien)
        {
            if (nguoiCaiNgien == null)
            {
                return false;
            }
        
                _context.Update(nguoiCaiNgien);
                _context.SaveChanges();
                return true;
           
        }

    }
}
