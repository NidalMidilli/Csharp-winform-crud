using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeniTasarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        // True yerine SSPI kullanılabilir //

        void vericek()
        {
            con = new SqlConnection("server=DESKTOP-RPBUNGP\\SQLEXPRESS;Initial Catalog = okul;Integrated Security= SSPI;TrustServerCertificate=True");
            da = new SqlDataAdapter("Select * from ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dtg_ogrenci.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vericek();
        }

        private void lbl_numara_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ogrenci(ogrenci_num,ogrenci_isim,ogrenci_soyisim,ogrenci_sehir) values(" + txt_ogrencino.Text + ",'" + txt_oisim.Text + "','" + txt_osoyisim.Text + "','" + txt_osehir.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            vericek();
                
           }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update ogrenci set ogrenci_isim = '" + txt_oisim.Text + "',ogrenci_soyisim='" + txt_osoyisim.Text + "',ogrenci_sehir='" + txt_osehir.Text + "' where ogrenci_num=" + txt_ogrencino.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            vericek();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ogrenci where ogrenci_num = "+txt_ogrencino.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            vericek();
        }
    }
}
