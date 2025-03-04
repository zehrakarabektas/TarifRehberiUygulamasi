using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab1tarifrehberiprojesi.Database
{
    public class TarifRehberiDatabase
    {
        private readonly string _baglanti = "Server=DESKTOP-4PT8UQA\\SQLEXPRESS;Database=tarifrehberidatabase;";

        public TarifRehberiDatabase(string connectionString)
        {
            _baglanti = connectionString;
        }

        // Bağlantıyı aç
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_baglanti);
        }
    }
}
