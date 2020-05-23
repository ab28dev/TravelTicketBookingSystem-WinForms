using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingSystem
{
    class TicketClass
    {

        public String source { get; set; }
        public String destination { get; set;}

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        // source checking for bus
        public bool search_stations(TicketClass c)
        {
            //c.source = comboBoxSource.Text;
            bool isSuccess = false;

            // Connect database
             SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql;
                int bus_flag = 0;
                MessageBox.Show(bus_flag.ToString());


                // Create Sql Query
                sql = "SELECT Bus FROM tbl_stations WHERE StationName = @source";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@source", c.source);
                SqlDataReader reader = null;
                conn.Open();
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        bus_flag = reader.GetInt32(0);
                    }
                }
             
                
                
                
                isSuccess = true;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
