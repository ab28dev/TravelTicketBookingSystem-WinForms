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

        public static String source { get; set; }
        public static String destination { get; set; }

        public int bus_flag_source = 0;
        public int bus_flag_destination = 0;
        public int train_flag_source = 0;
        public int train_flag_destination = 0;
        public int air_flag_source = 0;
        public int air_flag_destination = 0;

        public static int price = 0;
        public static int distance = 0;

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        /*
        public bool fetch_price(TicketClass c)
        {
            bool isSuccess = false;
            
            // Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            
            try
            {
                String sql;
                sql = "SELECT DistanceFromFirstStation FROM tbl_stations WHERE StationName = ";
                SqlCommand command = new SqlCommand(sql, conn);

                conn.Open();


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
        }
        */

        // Station checking for bus, train & setting flags for availability
        public bool search_stations(TicketClass c)
        {
            
            bool isSuccess = false;
            int source_distance = 0;
            int destination_distance = 0;

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
                String distance_source;
                String distance_destination;

                // Source
                // Create Sql Query 
                bus_source = "SELECT Bus FROM tbl_stations WHERE StationName = @source";
                train_source = "SELECT Train FROM tbl_stations WHERE StationName = @source";
                air_source = "SELECT Airplane FROM tbl_stations WHERE StationName = @source";
                distance_source = "SELECT DistanceFromFirstStation FROM tbl_stations WHERE StationName = @source";
                
                SqlCommand bus_cmd_source = new SqlCommand(bus_source, conn);
                SqlCommand train_cmd_source = new SqlCommand(train_source, conn);
                SqlCommand air_cmd_source = new SqlCommand(air_source, conn);
                SqlCommand distance_cmd_source = new SqlCommand(distance_source, conn);

                bus_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                train_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                air_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                distance_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);

                SqlDataReader reader = null;

                // Open Connecction
                conn.Open();
                // Read the database for flag of bus, train & air
                reader = distance_cmd_source.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        source_distance = reader.GetInt32(0);
                    }
                }
                conn.Close();

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
                conn.Close();


                // Destination
                // Create Sql Query 
                bus_destination = "SELECT Bus FROM tbl_stations WHERE StationName = @destination";
                train_destination = "SELECT Train FROM tbl_stations WHERE StationName = @destination";
                air_destination = "SELECT Airplane FROM tbl_stations WHERE StationName = @destination";
                distance_destination = "SELECT DistanceFromFirstStation FROM tbl_stations WHERE StationName = @destination";


                SqlCommand bus_cmd_destination = new SqlCommand(bus_destination, conn);
                SqlCommand train_cmd_destination = new SqlCommand(train_destination, conn);
                SqlCommand air_cmd_destination = new SqlCommand(air_destination, conn);
                SqlCommand distance_cmd_destination = new SqlCommand(distance_source, conn);

                bus_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                train_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                air_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                distance_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);


                // Open Connecction
                conn.Open();
                // Read the database for flag of bus, train & air
                reader = distance_cmd_destination.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        destination_distance = reader.GetInt32(0);
                    }
                }
                conn.Close();

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

                // calculating distance
                distance = Math.Abs(destination_distance - source_distance);

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


        // Determines ticket Cost
        
        public bool fetch_price(TicketClass c, String flag_for_mode)
        {
            bool isSuccess = false;
            int i = 0;

            int[] air_price = new int[100];
            int[] bus_price = new int[100];
            int[] train_price = new int[100];

            // Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            
            try
            {
                String sql;

                SqlDataReader reader = null;

                sql = "SELECT AIR TRAIN BUS FROM ticket_price WHERE Distance >= @distance";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@distance", TicketClass.distance);


                // Open Connecction
                conn.Open();
                // Read the database for flag of bus, train & air
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        air_price[i] = reader.GetInt32(0);
                        train_price[i] = reader.GetInt32(1);
                        bus_price[i] = reader.GetInt32(2);
                        ++i;
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

            if(flag_for_mode == "AIR")
            {
                price = air_price[0];
            }
            else if(flag_for_mode == "BUS")
            {
                price = bus_price[0];
            }
            else if(flag_for_mode == "TRAIN")
            {
                price = train_price[0];
            }

            return isSuccess;
        }
        
    }
}
