using DesktopDutaStoreApplication.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopDutaStoreApplication.Controller
{
    internal class Pelanggancontroller : Model.Connection
    {
        Connection Koneksi = new Connection();
        public DataTable tampilDataPelanggan()
        {
            DataTable data = new DataTable();
            try
            {
                string tampilData = "SELECT * FROM info_pelanggan";
                da = new MySqlConnector.MySqlDataAdapter(tampilData, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public DataTable tampilAkunPelanggan()
        {
            DataTable data = new DataTable();
            try
            {
                string tampilAkun = "SELECT * FROM akun_pelanggan";
                da = new MySqlConnector.MySqlDataAdapter(tampilAkun, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


        public DataTable searchDataPelanggan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM info_pelanggan WHERE CONCAT(user_id,nama,email)LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
        public DataTable searchAkunPelanggan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                ("SELECT * FROM akun_pelanggan WHERE CONCAT(account_id,username,pw)LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }



        public DataTable SelectDataPelanggan(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampilData = "SELECT * FROM info_pelanggan";
                da = new MySqlConnector.MySqlDataAdapter(tampilData, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable SelectAkunPelanggan(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampilAkun = "SELECT * FROM akun_pelanggan";
                da = new MySqlConnector.MySqlDataAdapter(tampilAkun, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }



        public void tambahAkunPelanggan(string accountid, string username, string pw)
        {
            string tambahAkun = "INSERT INTO akun_pelanggan VALUES(" + "@account_id,@username,@pw)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambahAkun, GetConn());
                cmd.Parameters.Add("@account_id", MySqlConnector.MySqlDbType.VarChar).Value = accountid;
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pw", MySqlConnector.MySqlDbType.VarChar).Value = pw;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Akun Pelanggan Gagal" + ex.Message);
            }
        }

        public void tambahDataPelanggan(string idpelanggan, string nama, string email)
        {
            string tambahData = "INSERT INTO info_pelanggan VALUES(" + "@user_id,@nama,@email)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambahData, GetConn());
                cmd.Parameters.Add("@user_id", MySqlConnector.MySqlDbType.VarChar).Value = idpelanggan;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Pelanggan Gagal" + ex.Message);
            }
        }


        public void updateAkunPelanggan(string accountid, string username, string pw)
        {
            string updateAkun = "UPDATE akun_pelanggan set " + "username=@username,pw=@pw " + "WHERE account_id=" + accountid;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(updateAkun, GetConn());
                cmd.Parameters.Add("@account_id", MySqlConnector.MySqlDbType.VarChar).Value = accountid;
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pw", MySqlConnector.MySqlDbType.VarChar).Value = pw;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Akun Pelanggan Gagal" + ex.Message);
            }
        }

        public void updateDataPelanggan(string idpelanggan, string nama, string email)
        {
            string updateData = "UPDATE info_pelanggan set " + "nama=@nama,email=@email " + "WHERE user_id=" + idpelanggan;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(updateData, GetConn());
                cmd.Parameters.Add("@user_id", MySqlConnector.MySqlDbType.VarChar).Value = idpelanggan;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Pelanggan Gagal" + ex.Message);
            }
        }


        public void hapusAkunPelanggan(string idakun)
        {
            string hapusAkun = "DELETE FROM akun_pelanggan WHERE account_id=" + idakun;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapusAkun, GetConn());
                cmd.Parameters.Add("@account_id", MySqlConnector.MySqlDbType.VarChar).Value = idakun;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Pelanggan Gagal" + ex.Message);
            }
        }

        public void hapusDataPelanggan(string idpelanggan)
        {
            string hapusData = "DELETE FROM info_pelanggan WHERE user_id=" + idpelanggan;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapusData, GetConn());
                cmd.Parameters.Add("@user_id", MySqlConnector.MySqlDbType.VarChar).Value = idpelanggan;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Pelanggan Gagal" + ex.Message);
            }
        }

    }
}
