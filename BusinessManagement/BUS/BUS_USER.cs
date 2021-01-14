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
        DAL_PB pb_func = new DAL_PB();
        DAL_DonHang donhang_func = new DAL_DonHang();
        DAL_HoaDon hoadon_func = new DAL_HoaDon();
        DAL_YTLT lamthem_func = new DAL_YTLT();
        DAL_MucThuong mucthuong_func = new DAL_MucThuong();
        DAL_ChucVu chucvu_func = new DAL_ChucVu();
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
        public string get_user_password(string nUid)
        {
            DAL_User user_func = new DAL_User();
            if (user_func.get_user(nUid) != null)
            {
                return user_func.get_user(nUid).matkhau;
            }
            else return null;
        }
        public bool update_ctlt(CTLamthem data)
        {
            return ctlt_func.update_CTLT(data.CTLamthemID, data.sogiolamthem, data.thang, data.tennv);
        }
        public List<CTLamthem> get_allctlt()
        {
            return ctlt_func.getall_CTLT();
        }
        public List<string> getallNCC_ID()
        {
            DAL_NhaCC nhacc_func = new DAL_NhaCC();
            //List<Nhacc> list = nhacc_func.getall_NhaCC();
            List<string> list = new List<string>();
            foreach (Nhacc data in nhacc_func.getall_NhaCC())
            {
                string dataID = data.NhaccID;
                list.Add(dataID);
            }
            if (list != null)
                return list;

            return null;
        }

        public List<string> getallKH_ID()
        {
            DAL_KhachHang khach_funcc = new DAL_KhachHang();
            List<string> list = new List<string>();
            foreach (Khachhang data in khach_funcc.getall_KhachHang())
            {
                list.Add(data.KhachhangID);
            }
            if (list != null)
                return list;
            return null;
        }

        public List<string> getallHD_ID()
        {
            DAL_HopDong hd_funcc = new DAL_HopDong();
            List<string> list = new List<string>();
            foreach (Hopdong data in hd_funcc.getall_HopDong())
            {
                list.Add(data.HopdongID);
            }
            if (list != null)
                return list;
            return null;
        }
        public Khachhang getkh(string sKhachhangID)
        {
            return khachHang_func.get_KhachHang(sKhachhangID);
        }
        public List<Nhanvien> getallnv_fromPB(PBData pb)
        {
            int i = 0;
            List<Nhanvien> list = new List<Nhanvien>();
            PBData pb_rep = pb;
            string subNVID = null;
            while (pb.NVID.Length > i + 1)
            {
                while (pb_rep.NVID[i] == '/')
                    i++;
                while (pb_rep.NVID[i] != '/')
                {
                    subNVID += pb_rep.NVID[i];
                    i++;
                }
                Nhanvien nv = new Nhanvien();
                nv = nhanvien_func.get_NV(subNVID);
                list.Add(nv);
                subNVID = null;
            }
            return list;
        }
        public bool add_new_dh(string nDonhangID, string nHanghoaID, string nNgaythem, string nSoluong, string nKhachhangID)
        {
            return donhang_func.add_DonHang(nDonhangID, nHanghoaID, nNgaythem, nSoluong, nKhachhangID);
        }
        public List<Donhang> getallDH()
        {
            return donhang_func.getall_DonHang();
        }
        public bool add_newHoadon(string nHoadonID, string nDonhangID, string nNgaylap, string nNgayxuat, string nNhanvienID
            , string nKhachhangID)
        {
            return hoadon_func.add_HoaDon(nHoadonID, nDonhangID, nNgaylap, nNgayxuat, nNhanvienID, nKhachhangID);
        }
        public List<CTHoadonforShow> getallHDListforShow()
        {
            List<CTHoadonforShow> list = new List<CTHoadonforShow>();
            foreach (Hoadon data in hoadon_func.getall_HoaDon())
            {
                CTHoadonforShow inst = new CTHoadonforShow();
                inst.DonhangID = data.DonhangID;
                inst.HoadonID = data.DonhangID.Replace("DH", "HD");
                inst.ngaylap = DateTime.Now.ToString();
                inst.ngayxuat = data.ngayxuat;
                inst.tenkh = getkh(data.KhachhangID).tenkh;
                inst.tennv = CurrentUser.nhanvien.tennv;
                inst.trigia = 1;
                foreach (CTDonhangforListing var in transferCTDH(donhang_func.get_DonHang(data.DonhangID)))
                {
                    inst.trigia += var.giaca * int.Parse(var.soluong);
                }
                list.Add(inst);
            }
            return list;
        }
        public List<CTDonhangforListing> transferCTDH(Donhang data)
        {
            Donhang datarep = data;
            List<CTDonhangforListing> list = new List<CTDonhangforListing>();
            int i = 0;
            int j = 0;
            string subHHID = null;
            string subHHSL = null;
            while (datarep.HanghoaID.Length > i + 1)
            {

                if (datarep.HanghoaID[i] == '/')
                {
                    i++;
                    j++;
                }
                while (datarep.HanghoaID[i] != '/')
                {
                    subHHID += datarep.HanghoaID[i];
                    i++;
                }

                while (datarep.soluong[j] != '/')
                {
                    subHHSL += datarep.soluong[j];
                    j++;
                }
                CTDonhangforListing ctdh = new CTDonhangforListing();
                ctdh.DonhangID = datarep.DonhangID;
                ctdh.HanghoaID = subHHID;
                ctdh.soluong = subHHSL;
                ctdh.tenhh = hanghoa_func.get_HangHoa(subHHID).tenhh;
                ctdh.giaca = giaca_func.get_CTGiaCa(hanghoa_func.get_HangHoa(subHHID).CTGiacaID).giaca;
                list.Add(ctdh);
                subHHID = null;
                subHHSL = null;
            }
            return list;
        }
        public Mucthuong getmucthuong_fromctt(string sCTThuongID)
        {
            return mucthuong_func.get_MucThuong(ctt_func.get_CTThuong(sCTThuongID).MucthuongID);
        }
        public Donhang getdonhang(string sDHID)
        {
            return donhang_func.get_DonHang(sDHID);
        }
        public Chucvu getchucvu(string sCVID)
        {
            return chucvu_func.get_CV(sCVID);
        }
        public List<string> getallPB_ID()
        {
            List<string> list = new List<string>();
            foreach (PBData pb in pb_func.getall_PB())
            {
                list.Add(pb.PBID);
            }
            return list;
        }
        public List<string> getallMH_ID()
        {
            DAL_HangHoa hh_funcc = new DAL_HangHoa();
            List<string> list = new List<string>();
            foreach (Hanghoa data in hh_funcc.getall_HangHoa())
            {
                list.Add(data.HanghoaID);
            }
            if (list != null)
                return list;
            return null;
        }

        public List<Hanghoa> getallMH()
        {
            return hanghoa_func.getall_HangHoa();
        }
        public CTGiaca getCTGiaca(string nCTGiacaID)
        {
            return giaca_func.get_CTGiaCa(nCTGiacaID);
        }
        public List<HanghoaLV> get_listof_hanghoalv()
        {
            List<HanghoaLV> list = new List<HanghoaLV>();
            foreach (Hanghoa data in hanghoa_func.getall_HangHoa())
            {
                HanghoaLV item = new HanghoaLV();
                item.HanghoaID = data.HanghoaID;
                item.tenhh = data.tenhh;
                item.nhomhang = data.nhomhang;
                item.dvt = data.dvt;
                item.nhacc = nhacc_func.get_NhaCC(data.NhaccID).tennhacc;
                item.giatien = giaca_func.get_CTGiaCa(data.CTGiacaID).giaca;
                list.Add(item);
            }
            return list;
        }
        public bool update_chucvuNV(Nhanvien nv, string nCVID)
        {
            CTChucVu inst = ctcv_func.get_CTCV(nv.CTChucvuID);
            inst.ChucvuID += nCVID + "/";
            inst.NgayUpdate += DateTime.Now.ToString() + "-";
            return ctcv_func.update_CTCV(inst.CTChucvuID, inst.ChucvuID, inst.NgayUpdate);

        }
        public List<Khachhang> getallKH()
        {
            return khachHang_func.getall_KhachHang();
        }

        public List<Nhanvien> getallNV()
        {
            return nhanvien_func.getall_NV();
        }
        public PBData getpb(string nPBID)
        {
            return pb_func.get_PB(nPBID);
        }
        public List<PBData> getallPB()
        {
            return pb_func.getall_PB();
        }
        public CTKyket getkyket(string sCTKyketID)
        {
            return kyket_func.get_CTKyKet(sCTKyketID);
        }
        public CTLamthem getctlamthem(string sCTLamthemID)
        {
            return ctlt_func.get_CTLT(sCTLamthemID);
        }
        public CTChucVu getctcv(string sCTChucvuID)
        {
            return ctcv_func.get_CTCV(sCTChucvuID);
        }
        public DSKynang get_dskn(string sDSKNID)
        {
            return dskynang_func.get_DSKyNang(sDSKNID);
        }
        public bool update_dskn(DSKynang data)
        {
            return dskynang_func.update_DSKyNang(data.DSKynangID, data.tenkynang, data.mucdo, data.ngaydanhgia);
        }
        public bool add_new_nv(string sName, string sNVID, string sUsername, string sPassword, string sDOB, string sGioitinh
           , string sNoisinh, string sDiachi, string sCVtype, string sHopDongID, string sTGKyket, string sTrinhdo, string sPBID, string sEmail, string sLTT)
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
            ctcv_func.add_CTCV(nCTCVID, sCVtype + "/", dtnow + "-");
            //them chi tiet lam them thang nay
            string nCTLamthemID = "CTLT" + uid;
            int thismonth = DateTime.Now.Month;
            ctlt_func.add_CTLT(nCTLamthemID, 0, thismonth);
            ctlt_func.add_tennv(sName, nCTLamthemID);
            //them chi tiet thuong mac dinh
            string nCTThuongID = "CTT" + uid;
            string mucthuongid = "MT00";
            int thang = thismonth;
            ctt_func.add_CTThuong(nCTThuongID, mucthuongid, thang);
            //them chi tiet ky ket hop dong
            string nKyketID = "Kyket" + uid;
            Hopdong hopdong_inst = hopdong_func.get_HopDong(sHopDongID);
            long luongkyket = long.Parse(sLTT);
            string ngaybd = null;
            string ngaykt = null;
            ngaybd = DateTime.Now.ToString();
            ngaykt = sTGKyket;
            kyket_func.add_CTKyKet(nKyketID, sHopDongID, luongkyket, ngaybd, ngaykt);
            //them ds ky nang moi
            string nDSKynangID = "DSKN" + uid;
            string tenkn = "/";
            string mucdo = "/";
            string ngaydanhgia = "-";
            dskynang_func.add_DSKyNang(nDSKynangID, tenkn, mucdo, ngaydanhgia);
            //them nhan vien vao DB
            PBData phongban = pb_func.get_PB(sPBID);
            phongban.NVID += sNVID + "/";
            pb_func.update_PB(phongban.PBID, phongban.tenpb, phongban.sdt, phongban.email, phongban.QLID, phongban.NVID);
            nhanvien_func.add_NV(sNVID, sCVtype, sName, sEmail, sDOB, sGioitinh, sNoisinh, sDiachi, sTrinhdo, sPBID, nCTCVID, nCTLamthemID, nCTThuongID,
                nKyketID, nDSKynangID);
            return true;
        }
        public bool update_hoadon(Hoadon data)
        {
            return hoadon_func.update_HoaDon(data.HoadonID, data.DonhangID, data.ngaylap, data.ngayxuat, data.NhanvienID, data.KhachhangID);
        }
        public Hoadon gethd(string HoadonId)
        {
            return hoadon_func.get_HoaDon(HoadonId);
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
            string KHID = "KH" + new_KhachhangID();
            khachHang_func.add_KhachHang(KHID, sName, sSDT, sDiacChi);
            return true;
        }
        public Chucvu get_lastcv(string sCTCVID)
        {

            CTChucVu inst = ctcv_func.get_CTCV(sCTCVID);
            Chucvu cv = new Chucvu();
            string subcv = null;
            int i = 0;
            while (inst.ChucvuID.Length > i + 1)
            {
                if (inst.ChucvuID[i] == '/')
                {
                    i++;
                }
                while (inst.ChucvuID[i] != '/')
                {
                    subcv += inst.ChucvuID[i];
                    i++;
                }
                cv = chucvu_func.get_CV(subcv);
                subcv = null;
            }
            return cv;

        }
        public bool add_new_HH(string sMahang, string sName, string sNCC, string sDVT, string sNhomMN, long sGia)
        {
            string sIDDT = DateTime.Now.Ticks.ToString();
            foreach (Hanghoa data in hanghoa_func.getall_HangHoa())
            {
                if (sMahang == data.HanghoaID) return false;
            }
            hanghoa_func.add_HangHoa(sMahang, sName, sNhomMN, sDVT, sNCC, sIDDT);
            string sNgay = DateTime.Now.ToString();
            giaca_func.add_CTGiaCa(sIDDT, sGia, sNgay);
            return true;
        }
        public int new_DonhangID()
        {
            return donhang_func.new_DonHangID();
        }
        public int new_KhachhangID()
        {
            return khachHang_func.new_KhachHangID();
        }
        public bool add_new_HD(string sID, string sName, long sLuong, string sCT)
        {
            foreach (Hopdong data in hopdong_func.getall_HopDong())
            {
                if (sID == data.HopdongID) return false;
            }
            hopdong_func.add_HopDong(sID, sName, sCT, sLuong);
            return true;
        }

        public UserData search_user(string nTaikhoan)
        {
            DAL_User user_func = new DAL_User();
            return user_func.search_user(nTaikhoan);
        }
        public bool remove_KH(string sKhachhangID)
        {
            return khachHang_func.remove_KhachHang(sKhachhangID);
        }
        public bool update_KH(Khachhang kh)
        {
            return khachHang_func.update_KhachHang(kh.KhachhangID, kh.tenkh, kh.sdt, kh.diachi);
        }
        public bool add_new_PB(string nPBID, string nTenpb, string nSdt, string nEmail, string nQLID, string nNVID)
        {
            return pb_func.add_PB(nPBID, nTenpb, nSdt, nEmail, nQLID, nNVID);
        }

    }
}
