using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CapCuuDAL
    {
        private static CapCuuDAL instance;
        public static CapCuuDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CapCuuDAL();
                return instance;
            }
        }

        private CapCuuDAL() { }

        public bool InsertBenhNhanCapCuu(BenhNhanCapCuu benhNhan)
        {
            string connectionString = DataProvider.Instance.connectionString;

            string query = "INSERT INTO BenhNhanCapCuu (HoTen, DiaChi, NamSinh, SDT, GioiTinh, Email, TienSuBenh, TrieuChung, ChuanDoan, KeHoachDieuTri, ThoiGian, GhiChu) " +
                           "VALUES (@HoTen, @DiaChi, @NamSinh, @SDT, @GioiTinh, @Email, @TienSuBenh, @TrieuChung, @ChuanDoan, @KeHoachDieuTri, @ThoiGian, @GhiChu)";
            int result = 0; // Khởi tạo giá trị kết quả

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm các tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@HoTen", benhNhan.HoTen);
                    command.Parameters.AddWithValue("@DiaChi", benhNhan.DiaChi);
                    command.Parameters.AddWithValue("@NamSinh", benhNhan.NamSinh);
                    command.Parameters.AddWithValue("@SDT", benhNhan.SDT);
                    command.Parameters.AddWithValue("@GioiTinh", benhNhan.GioiTinh);
                    command.Parameters.AddWithValue("@Email", benhNhan.Email);
                    command.Parameters.AddWithValue("@TienSuBenh", benhNhan.TienSuBenh);
                    command.Parameters.AddWithValue("@TrieuChung", benhNhan.TrieuChung);
                    command.Parameters.AddWithValue("@ChuanDoan", benhNhan.ChuanDoan);
                    command.Parameters.AddWithValue("@KeHoachDieuTri", benhNhan.KeHoachDieuTri);
                    command.Parameters.AddWithValue("@ThoiGian", benhNhan.ThoiGian);
                    command.Parameters.AddWithValue("@GhiChu", benhNhan.GhiChu);

                    result = command.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log, thông báo lỗi)
                throw ex;
            }

            // Trả về kết quả (số hàng bị ảnh hưởng), lớn hơn 0 nếu thêm thành công
            return result > 0;




        }
    }
}
