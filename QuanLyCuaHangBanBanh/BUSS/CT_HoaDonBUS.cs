using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUSS
{
    public class CT_HoaDonBUS
    {
        public List<CT_HoaDonDTO> Load(int id)
        {
            return CT_HoaDonDAO.Instance.GetList(id);
        }
    }
}
