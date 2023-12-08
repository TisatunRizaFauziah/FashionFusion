using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionFusion.Controller
{
    internal class Validasi
    {
        public bool valAdmin(string admin)
        {
            for (int a = 0; a < admin.Length; a++)
            {
                if (admin[a] >= '0' && admin[a] <= '9' || admin[0] == ' ' || admin[admin.Length - 1] == ' ' || admin[a] == ':' ||
                    admin[a] == ',' || admin[0] == '_' || admin[admin.Length - 1] == '_' || admin[a] == '/' || admin[a] == '\\' || admin[a] == '?' || admin[a] == '%' ||
                    admin[a] == '[' || admin[a] == ']' || admin[a] == '{' || admin[a] == '}' || admin[a] == '+' || admin[a] == '=' || admin[a] == '(' || admin[a] == ')' ||
                    admin[a] == '*' || admin[a] == '&' || admin[a] == '^' || admin[a] == '$' || admin[a] == '#' || admin[a] == '@' || admin[a] == '!' || admin[a] == '!')
                {
                    MessageBox.Show("Invalid Admin", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool valNama(string nama)
        {
            for (int a = 0; a < nama.Length; a++)
            {
                if (nama[a] >= '0' && nama[a] <= '9' || nama[0] == ' ' || nama[nama.Length - 1] == ' ' || nama[a] == ':' ||
                    nama[a] == ',' || nama[0] == '_' || nama[nama.Length - 1] == '_' || nama[a] == '/' || nama[a] == '\\' || nama[a] == '?' || nama[a] == '%' ||
                    nama[a] == '[' || nama[a] == ']' || nama[a] == '{' || nama[a] == '}' || nama[a] == '+' || nama[a] == '=' || nama[a] == '(' || nama[a] == ')' ||
                    nama[a] == '*' || nama[a] == '&' || nama[a] == '^' || nama[a] == '$' || nama[a] == '#' || nama[a] == '@' || nama[a] == '!' || nama[a] == '!')
                {
                    MessageBox.Show("Invalid Admin", "Validation Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool ValAlamat(string alamat)
        {
            for (int i = 0; i < alamat.Length; i++)
            {
                char currentChar = alamat[i];

                if (!char.IsLetterOrDigit(currentChar) && currentChar != ' ' && currentChar != '-' && currentChar != '\'' &&
                    currentChar != ',' && currentChar != ':' && currentChar != '_' && currentChar != '/' && currentChar != '?')
                {
                    MessageBox.Show("Invalid Alamat", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Pastikan Alamat tidak dimulai atau diakhiri dengan spasi, tanda strip, garis bawah, atau tanda tanya.
            if (alamat[0] == ' ' || alamat[0] == '-' || alamat[0] == '_' || alamat[0] == '?' ||
                alamat[alamat.Length - 1] == ' ' || alamat[alamat.Length - 1] == '-' || alamat[alamat.Length - 1] == '_' || alamat[alamat.Length - 1] == '?')
            {
                MessageBox.Show("Invalid Alamat", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        public bool Valharga(string hrg)
        {
            // Harga dapat terdiri dari angka, tanda koma, dan tanda titik sebagai pemisah desimal.
            if (!string.IsNullOrWhiteSpace(hrg) && Regex.IsMatch(hrg, @"^[0-9]+(\.|,)?[0-9]*$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Harga ", "Validation Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        int minLength = 8;
        int maxLength = 15;
        public bool ValNo(string nomor, int minLenght, int maxlenght)
        {
            // Nomor telepon hanya boleh mengandung angka, tanda tambah (+), dan tanda strip (-).
            // Selain itu, validasi panjang nomor telepon harus berada dalam rentang minLength dan maxLength.
            if (!string.IsNullOrWhiteSpace(nomor) &&
                Regex.IsMatch(nomor, @"^[0-9+\-]+$") &&
                nomor.Length >= minLength && nomor.Length <= maxLength)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Nomor Telepon", " Validation Eror ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool ValId(string id)
        {
            // Periksa setiap karakter dalam ID
            for (int i = 0; i < id.Length; i++)
            {
                char currentChar = id[i];

                // Periksa apakah karakter adalah huruf atau angka
                if (!(char.IsLetterOrDigit(currentChar)))
                {
                    MessageBox.Show("Invalid ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool ValPassword(string password)
        {
            bool containsLetter = false;
            bool containsDigit = false;

            foreach (char character in password)
            {
                if (char.IsLetter(character))
                {
                    containsLetter = true;
                }
                else if (char.IsDigit(character))
                {
                    containsDigit = true;
                }

                // Berhenti jika sudah ditemukan setidaknya satu huruf dan satu angka
                if (containsLetter && containsDigit)
                {
                    break;
                }
            }

            // Periksa apakah password memenuhi syarat
            if (containsLetter && containsDigit)
            {

                return true;
            }
            else
            {
                MessageBox.Show("The password must contain at least one letter and one digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool ValUkuran(string size)
        {

            string[] validSizes = { "s", "m", "l", "xl", "xs", "xxl" };

            // Periksa apakah ukuran yang diberikan ada dalam daftar ukuran yang valid
            if (Array.Exists(validSizes, s => s.Equals(size.ToLower())))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ukuran must be one of: S, M, L, XL, XS, XXL", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool ValStok(string stock)
        {
            // Periksa apakah stok hanya mengandung angka
            if (int.TryParse(stock, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Stock must contain only numeric digits.", " Validation Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


    }
}
