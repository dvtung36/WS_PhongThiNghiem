using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSPhongThiNghiem.model;

namespace WSPhongThiNghiem
{
    /// <summary>
    /// Summary description for WS_PhongThiNghiem
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_PhongThiNghiem : System.Web.Services.WebService
    {
        private String QUERY_CONNECT = "data source=DESKTOP-81VHF3A;initial catalog=PhongTN;integrated security=True; Integrated Security=SSPI;";


        /*method này trả về danh sách các thiết bị trong phòng thí nghiệm, nhóm theo chủng loại*/
        [WebMethod]
        public DataSet getListThietBi(string mChungLoai)
        {
            SqlConnection con = new SqlConnection(QUERY_CONNECT);
            con.Open();
            string query = "select ThietBi.MaTB,ThietBi.tenTB,ThietBi.ChungLoai,ThietBi.PhanMem" +
                " from ThietBi where ThietBi.ChungLoai=N'" + mChungLoai+ "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }


        /*method này trả về danh sách các thiết bị đang được mượn sắp tới hạn trả (trước 05 ngày)*/
        [WebMethod]
        public DataSet getThietBiToiHan()
        {
            SqlConnection con = new SqlConnection(QUERY_CONNECT);
            con.Open();
            string query = "select ThietBi.MaTB,ThietBi.TenTB,ThietBi.ChungLoai,ThietBi.PhanMem from ThietBi, PhieuMuon," +
                " ChiTietPhieuMuon where ThietBi.MaTB = ChiTietPhieuMuon.MaTB" +
                " and ChiTietPhieuMuon.MaPhieuMuon = PhieuMuon.MaPhieuMuon and DATEDIFF(DAY, PhieuMuon.ThoiGianTra, GETDATE())> 5";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }




        /*method này trả về danh sách các thiết bị quá hạn trả*/
        [WebMethod]
        public DataSet getThietBiQuaHan()
        {
            SqlConnection con = new SqlConnection(QUERY_CONNECT);
            con.Open();
            string query = "select ThietBi.MaTB,ThietBi.TenTB,ThietBi.ChungLoai,ThietBi.PhanMem from ThietBi, PhieuMuon," +
                " ChiTietPhieuMuon where ThietBi.MaTB = ChiTietPhieuMuon.MaTB" +
                " and ChiTietPhieuMuon.MaPhieuMuon = PhieuMuon.MaPhieuMuon and DATEDIFF(DAY, PhieuMuon.ThoiGianTra, GETDATE())<0";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        /*method này trả về danh sách các bài thí nghiệm của giáo viên theo ID của giáo viên đó*/
        [WebMethod]
        public DataSet getListBaiThiNghiem(int MaGV)
        {
            SqlConnection con = new SqlConnection(QUERY_CONNECT);
            con.Open();
            string query = "select PhieuDangKiKhaiThac.BaiThiNghiem from GiaoVien," +
                "PhieuDangKiKhaiThac where PhieuDangKiKhaiThac.MaGV=N'" + MaGV + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }






    }
}
