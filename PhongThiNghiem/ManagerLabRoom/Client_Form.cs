using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerLabRoom
{
    public partial class Client_Form : Form
    {
        private WS_PTN.WS_PhongThiNghiemSoapClient mWsPhongthinghiemsoapclient;
        public Client_Form()
        {
            InitializeComponent();
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            mWsPhongthinghiemsoapclient = new WS_PTN.WS_PhongThiNghiemSoapClient();
          
            if (tbchungloai.Text != "") {

                string chungloai = tbchungloai.Text;
                DataSet dataSet = new DataSet();
                dataSet = mWsPhongthinghiemsoapclient.getListThietBi(chungloai);


                DataTable dataTable = new DataTable();
                dataTable = dataSet.Tables[0];

                dgvDATA.DataSource = dataTable;
            }
       


        }

        private void btnBaiThiNghiem_Click(object sender, EventArgs e)
        {
            mWsPhongthinghiemsoapclient = new WS_PTN.WS_PhongThiNghiemSoapClient();
       
            if (tvIDGV.Text != "") {
                int idGV = int.Parse(tvIDGV.Text);
                DataSet dataSet = new DataSet();
                dataSet = mWsPhongthinghiemsoapclient.getListBaiThiNghiem(idGV);

                DataTable dataTable = new DataTable();
                dataTable = dataSet.Tables[0];

                dgvDATA.DataSource = dataTable;
            }
         
        }

        private void btnToiHan_Click(object sender, EventArgs e)
        {
            mWsPhongthinghiemsoapclient = new WS_PTN.WS_PhongThiNghiemSoapClient();
            DataSet dataSet = new DataSet();
            dataSet = mWsPhongthinghiemsoapclient.getThietBiToiHan();

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];


            dgvDATA.DataSource = dataTable;
        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            mWsPhongthinghiemsoapclient = new WS_PTN.WS_PhongThiNghiemSoapClient();
            DataSet dataSet = new DataSet();
            dataSet = mWsPhongthinghiemsoapclient.getThietBiQuaHan();

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            dgvDATA.DataSource = dataTable;
        }
    }
}
