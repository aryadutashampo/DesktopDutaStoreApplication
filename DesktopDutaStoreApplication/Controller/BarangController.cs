using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopDutaStoreApplication.Model;
namespace DesktopDutaStoreApplication.Controller
{
    internal class BarangController : Model.Connection
    {
        Connection Koneksi = new Connection();
        public DataTable tampilBarang()
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM barang";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable SelectBarang(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM barang";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


        public void tambahBarang(string id, string nama, string harga, string stok, byte[] photo)
        {
            string tambah = "INSERT INTO barang VALUES (" + "@id_barang,@nama_barang,@harga,@stok,@photo)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_barang", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_barang", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = harga;
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.VarChar).Value = stok;
                cmd.Parameters.Add("@photo", MySqlConnector.MySqlDbType.Blob).Value = photo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Barang Gagal!" + ex.Message);
            }
        }

        public void updateBarang(string idbarang, string namabarang, string harga, string stok, byte[] photo)
        {
            string update = "UPDATE barang set " + "nama_barang=@nama_barang,harga=@harga,stok=@stok,photo=@photo " + "WHERE id_barang=" + idbarang;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_barang", MySqlConnector.MySqlDbType.VarChar).Value = idbarang;
                cmd.Parameters.Add("@nama_barang", MySqlConnector.MySqlDbType.VarChar).Value = namabarang;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = harga;
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.VarChar).Value = stok;
                cmd.Parameters.Add("@photo", MySqlConnector.MySqlDbType.Blob).Value = photo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Barang Gagal" + ex.Message);
            }
        }

        public DataTable searchBarang(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM barang WHERE CONCAT(id_barang,nama_barang,harga,stok) LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }


        public void hapusBarang(string idbarang)
        {
            string hapus = "DELETE FROM barang WHERE id_barang=" + idbarang;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_barang", MySqlConnector.MySqlDbType.VarChar).Value = idbarang;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Barang Gagal" + ex.Message);
            }
        }

    }
}
