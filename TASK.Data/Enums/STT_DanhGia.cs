using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Enums
{
    public enum STT_KhoiLuong
    {
        BinhThuong = 1,
        Nhieu = 2,
        Thap = 3
    }

    public enum STT_TienDo
    {
        KipTienDo = 1,
        SomHonKH = 2,
        TreTienDo = 3
    }

    public enum ChatLuongGird
    {
        LoiNoiBoTrienKhaiTestLoai1 = 1,
        LoiNoiBoTrienKhaiTestLoai2 = 2,
        LoiNoiBoHoacLoiKHBao = 3,
        LoiNghiemTrong = 4
    }

    public enum ChatLuongCombobox
    {
        Tot = 1,
        Kha = 2,
        TrungBinh = 3,
        Yeu = 4
    }

    public enum XepLoai
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5
    }

    public class DanhGia
    {
        public int Value { get; set; }

        public string Name { get; set; }
    }
}
