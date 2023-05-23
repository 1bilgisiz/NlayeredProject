using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DataAccessLAyer
{
    public class baglanti
    {

        public static SqlConnection bgl = new SqlConnection(@"Data Source=1BILGISIZ\SQLEXPRESS01;Initial Catalog=DbPersonel;Integrated Security=True");
    }
}
