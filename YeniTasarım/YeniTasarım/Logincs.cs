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
using YeniTasarım;

namespace ogrenci
{
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        void GirisYap()
        {
            con = new SqlConnection("server=DESKTOP-RPBUNGP\\SQLEXPRESS;Initial Catalog = okul;Integrated Security= SSPI;TrustServerCertificate=True");
            da = new SqlDataAdapter("Select * from kullanici", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kullanici");
            dr = cmd.ExecuteReader();
            con.Close();
        }

        private void Logincs_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from kullanici where kullaniciadi=" + txt_kullaniciadi.Text + ",and sifre =" + txt_sifre + "";
            if (dr.Read())
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
                MessageBox.Show("Yanlış Kullanıcıadı veya Sifre");
            GirisYap();
        }
    }
}
