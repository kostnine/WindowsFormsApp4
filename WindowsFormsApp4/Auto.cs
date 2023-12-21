using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal class Auto : DbConnect
    {
        static public DataTable dbAuto = new DataTable();
        static public void GetAuto()
        {
            try
            {
                DbConnect.msCommand.CommandText = "SELECT * FROM autumobiliai";
                dbAuto.Clear();
                DbConnect.msDataAdapter.SelectCommand = DbConnect.msCommand;
                DbConnect.msDataAdapter.Fill(dbAuto);
            }
            catch
            {
                MessageBox.Show("Klaida gaunat duomenius", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static public bool AddAuto(string Kebulas, string Modelis, string Komplektacija, string Degalai, string Variklio_Galia, string Kaina)
        {
            try
            {
                DbConnect.msCommand.CommandText = "INSERT INTO autumobiliai (id_auto, Modelis, Kebulas, Komplektacija, Degalai, Variklio_Galia, Kaina) " +
                                                  $"VALUES (null, '{Modelis}', '{Kebulas}', '{Komplektacija}', '{Degalai}', '{Variklio_Galia}', '{Kaina}')";

                if (DbConnect.msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Klaida pridedant!");
                return false;
            }
        }

    }
}

