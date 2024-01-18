using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CONST
    {   
        //Thong bao
        public const string themTC = "Thêm thành công!";
        public const string themTB = "Thêm thất bại!";
        public const string suaTC = "Sửa thành công!";
        public const string suaTB = "Sửa thất bại!";
        public const string xoaTC = "Xóa thành công!";
        public const string xoaTB = "Xóa thất bại!";
        public const string xoaTBTonTaiTrongHoaDon = "Không thể xóa vì sản phẩm đang bán!";
        public const string CapNhatTC = "Cập nhật thành công!";
        public const string CapNhatTB = "Cập nhật thất bại!";
        public const string CapNhatMKMTC = "Cập nhật mật khẩu thành công!";
        public const string CapNhatMKMTB = "Cập nhật mật khẩu thất bại!";
        


        public const string TB = "Thông báo";
        public const string XN = "Xác nhận";
        public const string TBSpTonTai = "Sản phẩm đã tồn tại ";
        public const string TBTKSaiTkNhapLai = "Sai tên đăng nhập mới ";
        public const string TBCapNhatTKTC = "Cập nhật tên đăng nhập thành công thành công";
        public const string TBCapNhatTKTB = "Cập nhật tên đăng nhập thất bại";
        public const string TBSaiMkCu = "Sai mật khẩu cũ";
        public const string TBSaiMkMoi = "Sai mật khẩu mới";
        public const string TBNhapMaHD = "Vui lòng nhập mã hóa đơn!";
        public const string TBSaiNgay = "Ngày kết thúc không thể lớn hơn ngày bắt đầu !";
        public const string TBTrong = "Trống";
        public const string TBCoNguoi = "Có người";
        public const string TBChuaChonBan = "Vui lòng chọn bàn";
        public const string TBChuaChonMon = "Vui lòng chọn món cần thêm!";
        public const string TBChuaChonMonXoa = "Vui lòng chọn món cần xóa!";
        public const string TBNhapSoDuong = "Số lượng sản phẩm phải là một số nguyên dương";
        public const string TBChuaHD = "Chưa có hóa đơn";
        public const string TBXacNhapThanhToan = "Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}";
        public const string TBKhongHD = "Không có hóa đơn";
        public const string TBXNInHD = "Bạn có muốn in hóa đơn không";
        public const string TBNhapMaDM = "Vui lòng nhập mã danh mục cần xóa";
        public const string TBChonSuaDM = "Vui lòng chọn danh mục muốn sửa";
        public const string TBChonThemDM = "Vui lòng nhập tên danh mục muốn thêm";
        public const string TBNhapTenVaMK = "Tên tài khoản hoặc mật khẩu không đúng";
        public const string TBDangXuat = "Bạn có muốn đăng xuất tài khoản không";
        public const string TBBanTonTai = "Bàn đã tồn tại ";
        public const string TBBanCanSua = "Vui lòng chọn bàn cần sửa";
        public const string TBBanCanXoa = "Vui lòng chọn bàn cần xóa";
        public const string TBBanCoNguoi = "Bàn đang trong quá trình bán hàng";
        public const string TBTrungSDT = "Số điện thoại trùng với nhân viên khác!";
        public const string TBTrungBan = "Bàn đã có trong cửa hàng!";
        public const string TBTrungDanhMuc = "Danh mục đã có trong cửa hàng!";
        public const string TBTrungDanhMucSP = "Không thể xóa vì đây là danh mục chính";
        public const string TBTrungDanhMucTrongDm = "Không thể xóa vì tồn tại sản phẩm trong danh mục";
        public const string TBKhongcoNV = "Không tìm thấy nhân viên cần làm mới mật khẩu!";







        //canh bao
        public const string CanhBaoNV = "Nhân viên đang sử dụng ứng dụng không thể xóa";
        public const string CanhBaoDeTrong = "Không được để dữ liệu trống";
        public const string CanhBaoChuaNhapMaXoa = "Vui lòng nhập mã khách cần xóa";
        public const string CanhBaoChuaChonSpSua = "Vui lòng chọn sản phẩm cần sửa";
        public const string CanhBaoSĐTTrung = "Số điện thoại bị trùng với khách hàng khách!";
        public const string CanhBaoDoDaiSDT = "Số điện thoại quá dài!";
        public const string CanhBaoTenSanPhamTrung = "Sản phẩm đã có trong cửa hàng!";
        public const string CanhBaokytusdt = "Số điện thoại không vượt quá 10 ký tự";
        public const string CanhBaoDeTrongtkmk = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!";
        public const string CanhBaoDeTrongmkm = "Vui lòng nhập mật khẩu mới!";
        public const string CanhBaoDeTrongtkm = "Vui lòng nhập tên đăng nhập mới!";


        //xac nhan
        public const string xacnhanxoaDM = "Bạn có chắc chắn muốn xóa danh mục?";
        public const string xacnhanxoaSPHD = "Bạn có chắc chắn muốn xóa sản phẩm ra khỏi hóa đơn không?";
        public const string xacnhanxoaKH = "Bạn có chắc chắn muốn xóa khách hàng không?";
        public const string xacnhanxoaSP = "Bạn có chắc chắn muốn xóa sản phẩm không?";
        public const string xacnhanxoaBan = "Bạn có chắc chắn muốn bàn không không?";
        public const string xacnhanRSMatKhau = "Bạn có chắc chắn muốn làm mới mật khẩu không?";

        //MaMau
        public const string MaMauChung = "#EF7712";





    }
}
