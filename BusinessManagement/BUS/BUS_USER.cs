using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class BUS_USER
    {
        DAL_User user_func = new DAL_User();
        DAL_NhanVien nhanvien_func = new DAL_NhanVien();
        DAL_CTCV ctcv_func = new DAL_CTCV();
        DAL_CTLT ctlt_func = new DAL_CTLT();
        DAL_CTT ctt_func = new DAL_CTT();
        DAL_KyKet kyket_func = new DAL_KyKet();
        DAL_HopDong hopdong_func = new DAL_HopDong();
        DAL_DSKyNang dskynang_func = new DAL_DSKyNang();
        DAL_NhaCC nhacc_func = new DAL_NhaCC();
        DAL_KhachHang khachHang_func = new DAL_KhachHang();
        DAL_HangHoa hanghoa_func = new DAL_HangHoa();
        DAL_CTGiaCa giaca_func = new DAL_CTGiaCa();
        List<string> random = new List<string>();

        public UserData get_user_from_id(string nUid)
        {
            DAL_User user_func = new DAL_User();
            return user_func.get_user(nUid);
        }
        public Nhanvien get_nv_from_id(string nNVID)
        {
            DAL_NhanVien nhanvien_func = new DAL_NhanVien();
            return nhanvien_func.get_NV(nNVID);
        }


        public bool add_new_nv(string sName, string sNVID, string sUsername, string sPassword, string sDOB, string sGioitinh
           , string sNoisinh, string sDiachi, string sCVtype, string sHopDongID, string sTGKyket, string sTrinhdo, string sPBID)
        {
            foreach (Nhanvien data in nhanvien_func.getall_NV())
            {
                if (sNVID == data.NVID) return false;
            }
            string uid = null;
            uid = DateTime.Now.Ticks.ToString();
            //them tai khoan
            user_func.add_user(uid, sUsername, sPassword, sNVID, sPBID);
            //them chi tiet chuc vu cho nguoi dung
            string nCTCVID = "CTCV" + uid;
            string dtnow = null;
            dtnow = DateTime.Now.ToString();
            ctcv_func.add_CTCV(nCTCVID, sCVtype, dtnow);
            //them chi tiet lam them thang nay
            string nCTLamthemID = "CTLT" + uid;
            int thismonth = DateTime.Now.Month;
            ctlt_func.add_CTLT(nCTLamthemID, 0, thismonth);
            //them chi tiet thuong mac dinh
            string nCTThuongID = "CTT" + uid;
            string mucthuongid = "MT00";
            int thang = thismonth;
            ctt_func.add_CTThuong(nCTThuongID, mucthuongid, thang);
            //them chi tiet ky ket hop dong
            string nKyketID = "Kyket" + uid;
            Hopdong hopdong_inst = hopdong_func.get_HopDong(sHopDongID);
            long luongkyket = hopdong_inst.luongtoithieu;
            string ngaybd = null;
            string ngaykt = null;
            ngaybd = DateTime.Now.ToString();
            ngaykt = sTGKyket;
            kyket_func.add_CTKyKet(nKyketID, sHopDongID, luongkyket, ngaybd, ngaykt);
            //them ds ky nang moi
            string nDSKynangID = "DSKN" + uid;
            string tenkn = "none";
            string mucdo = "none";
            string ngaydanhgia = "none";
            dskynang_func.add_DSKyNang(nDSKynangID, tenkn, mucdo, ngaydanhgia);
            //them nhan vien vao DB
            nhanvien_func.add_NV(sNVID, sCVtype, sName, "none@", sDOB, sGioitinh, sNoisinh, sDiachi, sTrinhdo, nCTCVID, nCTLamthemID, nCTThuongID,
                nKyketID, nDSKynangID);
            return true;
        }
        public bool add_new_NCC(string sName, string sID, string sSDT)
        {
            foreach (Nhacc data in nhacc_func.getall_NhaCC())
            {
                if (sID == data.NhaccID) return false;
            }
            nhacc_func.add_NhaCC(sID, sName, sSDT);
            return true;
        }
        public bool add_new_KH(string sName, string sSDT, string sDiacChi)
        {
            string KHID = "KH" + DateTime.Now.Ticks.ToString();
            khachHang_func.add_KhachHang(KHID, sName, sSDT, sDiacChi);
            return true;
        }
        public bool add_new_HH(string sName, string sNCC, string sDVT, string sNhomMN, string sGia)
        {
            string sID = sNhomMN + "-" + sNCC + "-" + sName;
            string sIDDT = DateTime.Now.Ticks.ToString();
            foreach (Hanghoa data in hanghoa_func.getall_HangHoa())
            {
                if ( sID== data.HanghoaID) return false;
            }
            hanghoa_func.add_HangHoa(sID, sName, sNhomMN, sDVT, sNCC, sIDDT);
            string sNgay = DateTime.Now.ToString();
            giaca_func.add_CTGiaCa(sIDDT, sGia, sNgay);
            return true;
        }
    }
}
