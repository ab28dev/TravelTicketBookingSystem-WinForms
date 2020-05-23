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
        
        // Station checking for bus
        public bool search_stations(TicketClass c)
        {
            //c.source = comboBoxSource.Text;
            bool isSuccess = false;

            // Connect database
             SqlConnection conn = new SqlConnection(myconnstrng);
            
            try
            {

                String bus_source;
                String bus_destination;
                String train_source;
                String train_destination;
                String air_source;
                String air_destination;

                int bus_flag_source = 0;
                int bus_flag_destination = 0;
                int train_flag_source = 0;
                int train_flag_destination = 0;
                int air_flag_source = 0;
                int air_flag_destination = 0;

                // Source
                // Create Sql Query 
                bus_source = "SELECT Bus FROM tbl_stations WHERE StationName = @source";
                train_source = "SELECT Train FROM tbl_stations WHERE StationName = @source";
                air_source = "SELECT Airplane FROM tbl_stations WHERE StationName = @source";
                
                SqlCommand bus_cmd_source = new SqlCommand(bus_source, conn);
                SqlCommand train_cmd_source = new SqlCommand(train_source, conn);
                SqlCommand air_cmd_source = new SqlCommand(air_source, conn);

                bus_cmd_source.Parameters.AddWithValue("@source", c.source);
                train_cmd_source.Parameters.AddWithValue("@source", c.source);
                air_cmd_source.Parameters.AddWithValue("@source", c.source);

                SqlDataReader reader = null;
                
                // Open Connecction
                conn.Open();
                // Read the database for flag of bus, train & air
                reader = bus_cmd_source.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        bus_flag_source = reader.GetInt32(0);
                    }
                }
                conn.Close();
                conn.Open();
                reader = train_cmd_source.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        train_flag_source = reader.GetInt32(0);
                    }
                }
                conn.Close();
                conn.Open();
                reader = air_cmd_source.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        air_flag_source = reader.GetInt32(0);
                    }
                }


                // Destination
                // Create Sql Query 
                bus_destination = "SELECT Bus FROM tbl_stations WHERE StationName = @source";
                train_destination = "SELECT Train FROM tbl_stations WHERE StationName = @source";
                air_destination = "SELECT Airplane FROM tbl_stations WHERE StationName = @source";

                SqlCommand bus_cmd_destination = new SqlCommand(bus_destination, conn);
                SqlCommand train_cmd_destination = new SqlCommand(train_destination, conn);
                SqlCommand air_cmd_destination = new SqlCommand(air_destination, conn);

                bus_cmd_destination.Parameters.AddWithValue("@source", c.source);
                train_cmd_destination.Parameters.AddWithValue("@source", c.source);
                air_cmd_destination.Parameters.AddWithValue("@source", c.source);


                // Open Connecction
                conn.Open();
                // Read the database for flag of bus, train & air
                reader = bus_cmd_destination.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        bus_flag_destination = reader.GetInt32(0);
                    }
                }
                conn.Close();
                conn.Open();
                reader = train_cmd_destination.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        train_flag_destination = reader.GetInt32(0);
                    }
                }
                conn.Close();
                conn.Open();
                reader = air_cmd_destination.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        air_flag_destination = reader.GetInt32(0);
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
