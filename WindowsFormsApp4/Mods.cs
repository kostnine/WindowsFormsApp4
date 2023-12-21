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
    internal class Mods : DbConnect
    {

        static public DataTable dbMods = new DataTable();
        static public DataTable dbMod = new DataTable();
        static public DataTable dbMod1 = new DataTable();
        static public void GetKebulas()
        {
            try
            {
                DbConnect.msCommand.CommandText = "SELECT Kebulai FROM kebulai";
                dbMods.Clear();
                DbConnect.msDataAdapter.SelectCommand = DbConnect.msCommand;
                DbConnect.msDataAdapter.Fill(dbMods);
            }
            catch
            {
                MessageBox.Show("Klaida gaunat duomenius", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static public void GetDegalai()
        {
            try
            {
                DbConnect.msCommand.CommandText = "SELECT Degalas FROM degalas";
                dbMod.Clear();
                DbConnect.msDataAdapter.SelectCommand = DbConnect.msCommand;
                DbConnect.msDataAdapter.Fill(dbMod);
            }
            catch
            {
                MessageBox.Show("Klaida gaunat duomenius", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static public void GetKompl()
        {
            try
            {
                DbConnect.msCommand.CommandText = "SELECT kompls FROM kompl";
                dbMod1.Clear();
                DbConnect.msDataAdapter.SelectCommand = DbConnect.msCommand;
                DbConnect.msDataAdapter.Fill(dbMod1);
            }
            catch
            {
                MessageBox.Show("Klaida gaunat duomenius", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
        
}
