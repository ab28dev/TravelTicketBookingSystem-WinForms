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
        public bool search_source_for_bus(TicketClass c)
        {
            //c.source = comboBoxSource.Text;
            bool isSuccess = false;

            // Connect database
             SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                SqlCommand command;
                SqlDataReader dataReader;
                String sql;
                int isBus;
                // Create Sql Query
                sql = "SELECT Bus FROM tbl_stations WHERE StationName = @source";
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                conn.Open();
                isBus = dataReader.GetInt32(0);
                MessageBox.Show(isBus.ToString());

                MessageBox.Show("heloo");




            }
            catch(Exception Ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return true;
        }

    }
}
