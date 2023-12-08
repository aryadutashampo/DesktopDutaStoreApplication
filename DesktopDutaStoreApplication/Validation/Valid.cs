using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication.Validation
{
    internal class Valid
    {
        //Validasi id
        public bool valId(string valId)
        {
            for (int a = 0; a < valId.Length; a++)
            {
                if ((valId[0] == '0') || valId[0] == ' ')
                {
                    MessageBox.Show("Input Id failed", "add Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        //Validasi Username
        public bool valUsername(string uname)
        {
            for (int a = 0; a < uname.Length; a++)
            {
                if ((uname[0] == ' ' || uname[uname.Length - 1] == ' ' || uname[a] == '_' ||
                    uname[a] == '&' || uname[0] == '-' || uname[uname.Length - 1] == '-' ||
                    uname[a] == '/' || uname[a] == '\\' || uname[a] == '+' || uname[a] == '-' || uname[a] == ',' || uname[a] == '\'' || uname[a] == '<' ||
                    uname[a] == '>'))
                {
                    MessageBox.Show("Input Username failed", "add username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        //Validasi Password
        public bool valPassword(string pw)
        {
            for (int a = 0; a < pw.Length; a++)
            {
                if ((pw[0] == ' ' || pw[pw.Length - 1] == ' ' ||
                    pw[pw.Length - 1] == '-' || pw[a] == '/' || pw[a] == '\\' || pw[a] == '?' ||
                    pw[a] == '!' || pw[a] == '@' || pw[a] == '#' || pw[a] == '$' || pw[a] == '%' ||
                    pw[a] == '^' || pw[a] == '&' || pw[a] == '*' || pw[a] == '(' || pw[a] == ')' ||
                    pw[a] == '`' || pw[a] == '~' || pw[a] == '-' || pw[a] == '+' || pw[a] == '=' ||
                    pw[a] == '[' || pw[a] == ']' || pw[a] == '{' || pw[a] == '}' || pw[a] == ';' ||
                    pw[a] == '\'' || pw[a] == ':' || pw[a] == '\"' || pw[a] == ',' || pw[a] == '.' ||
                    pw[a] == '/' || pw[a] == '>' || pw[a] == '<' || pw[a] == '|'))
                {
                    MessageBox.Show("Input Password failed", "add Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        //Validasi Nama
        public bool valNama(string nama)
        {
            for (int a = 0; a < nama.Length; a++)
            {
                if (((nama[a] >= '0' && nama[a] <= '9') || nama[nama.Length - 1] == ' ' ||
                    nama[nama.Length - 1] == '-' || nama[a] == '/' || nama[a] == '\\' || nama[a] == '?' ||
                    nama[a] == '!' || nama[a] == '@' || nama[a] == '#' || nama[a] == '$' || nama[a] == '%' ||
                    nama[a] == '^' || nama[a] == '&' || nama[a] == '*' || nama[a] == '(' || nama[a] == ')' ||
                    nama[a] == '`' || nama[a] == '~' || nama[a] == '-' || nama[a] == '+' || nama[a] == '=' ||
                    nama[a] == '[' || nama[a] == ']' || nama[a] == '{' || nama[a] == '}' || nama[a] == ';' ||
                    nama[a] == '\'' || nama[a] == ':' || nama[a] == '\"' || nama[a] == ',' || nama[a] == '.' ||
                    nama[a] == '/' || nama[a] == '>' || nama[a] == '<' || nama[a] == '|'))
                {
                    MessageBox.Show("Input Nama failed", "add nama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        //Validasi Alamat Email
        public bool valEmail(string email)
        {
            for (int a = 0; a < email.Length; a++)
            {
                if ((email[0] == ' ' || email[email.Length - 1] == ' ' ||
                    email[email.Length - 1] == '-' || email[a] == '/' || email[a] == '\\' || email[a] == '?' ||
                    email[a] == '!' || email[a] == '#' || email[a] == '$' || email[a] == '%' ||
                    email[a] == '^' || email[a] == '&' || email[a] == '*' || email[a] == '(' || email[a] == ')' ||
                    email[a] == '`' || email[a] == '~' || email[a] == '-' || email[a] == '+' || email[a] == '=' ||
                    email[a] == '[' || email[a] == ']' || email[a] == '{' || email[a] == '}' || email[a] == ';' ||
                    email[a] == '\'' || email[a] == ':' || email[a] == '\"' || email[a] == ',' ||
                    email[a] == '/' || email[a] == '>' || email[a] == '<' || email[a] == '|'))
                {
                    MessageBox.Show("Input email failed", "add email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool ValHarga(string harga)
        {
            for (int a = 0; a < harga.Length; a++)
            {
                if ((harga[a] >= 'A' && harga[a] <= 'Z' || harga[0] == ' ' || harga[0] == '0' || harga[harga.Length - 1] == ' ' ||
                    harga[a] == ',' || harga[0] == '-' || harga[harga.Length - 1] == '-' || harga[a] == '/' || harga[a] == '\\' ||
                    harga[a] == '?' || harga[a] == '`' || harga[a] == '~' || harga[a] == '!' ||
                    harga[a] == '@' || harga[a] == '#' || harga[a] == '$' || harga[a] == '%' || harga[a] == '^' || harga[a] == '&' || harga[a] == '*'))
                {
                    MessageBox.Show("Input Harga failed", "add Harga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;

        }
    }
}
