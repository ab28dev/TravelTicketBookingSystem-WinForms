using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingSystem
{
    class TicketClass
    {
        public static String user_id { get; set; }
        public static String password { get; set; }
        public static String source { get; set; }
        public static String destination { get; set; }
        public static String mode { get; set; }

        public static DateTime date { get; set; }

        public int bus_flag_source = 0;
        public int bus_flag_destination = 0;
        public int train_flag_source = 0;
        public int train_flag_destination = 0;
        public int air_flag_source = 0;
        public int air_flag_destination = 0;

        public static String mid { get; set; }
        public int serial_source;
        public int serial_destination;
        public static int air_first;
        

        public static int price = 0;
        public static int distance = 0;
        public static int ticketno = 0;

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
      

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
                String SerialSource;
                String SerialDestination;

                // Source
                // Create Sql Query 
                bus_source = "SELECT Bus FROM tbl_stations WHERE StationName = @source";
                train_source = "SELECT Train FROM tbl_stations WHERE StationName = @source";
                air_source = "SELECT Airplane FROM tbl_stations WHERE StationName = @source";
                distance_source = "SELECT DistanceFromFirstStation FROM tbl_stations WHERE StationName = @source";
                SerialSource = "SELECT StationNo FROM tbl_stations WHERE StationName = @source";

                SqlCommand bus_cmd_source = new SqlCommand(bus_source, conn);
                SqlCommand train_cmd_source = new SqlCommand(train_source, conn);
                SqlCommand air_cmd_source = new SqlCommand(air_source, conn);
                SqlCommand distance_cmd_source = new SqlCommand(distance_source, conn);
                SqlCommand serial_cmd_source = new SqlCommand(SerialSource, conn);

                bus_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                train_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                air_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                distance_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);
                serial_cmd_source.Parameters.AddWithValue("@source", TicketClass.source);

                SqlDataReader reader = null;

                conn.Open();
                reader = serial_cmd_source.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        serial_source = reader.GetInt32(0);
                    }
                }
                conn.Close();

                reader = null;
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

                reader = null;
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

                reader = null;
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
                
                reader = null;
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
                SerialDestination = "SELECT StationNo FROM tbl_stations WHERE StationName = @destination";


                SqlCommand bus_cmd_destination = new SqlCommand(bus_destination, conn);
                SqlCommand train_cmd_destination = new SqlCommand(train_destination, conn);
                SqlCommand air_cmd_destination = new SqlCommand(air_destination, conn);
                SqlCommand distance_cmd_destination = new SqlCommand(distance_destination, conn);
                SqlCommand serial_cmd_destination = new SqlCommand(SerialDestination, conn);

                bus_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                train_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                air_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                distance_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);
                serial_cmd_destination.Parameters.AddWithValue("@destination", TicketClass.destination);

                conn.Open();
                reader = serial_cmd_destination.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        serial_destination = reader.GetInt32(0);
                    }
                }
                conn.Close();

                reader = null;
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

                reader = null;
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
                
                reader = null;
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
                
                reader = null;
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

        // Emergency calculation
        public void Emergency_calculation()
        {
            String[] array = new String[100];
            int i = 0;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                if (air_flag_source == 1)
                {
                    air_first = 1;
                    String sql;
                    if (serial_destination > serial_source)
                    {
                        sql = "SELECT StationName FROM tbl_stations WHERE Airplane = 1 AND StationNo > @serial_source AND StationNo < @serial_destination ORDER BY StationNo;";
                    }
                    else if (serial_source > serial_destination)
                    {
                        sql = "SELECT StationName FROM tbl_stations WHERE Airplane = 1 AND StationNo > @serial_destination AND StationNo < @serial_source ORDER BY StationNo desc;";
                    }
                    else
                    {
                        sql = "";
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@serial_source", serial_source);
                    cmd.Parameters.AddWithValue("@serial_destination", serial_destination);

                    SqlDataReader reader = null;
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            array[i] = reader.GetString(0);
                        }
                        mid = array[0];
                    }
                    
                }
                else if (air_flag_destination == 1)
                {
                    air_first = 0;
                    String sql;
                    if (serial_destination > serial_source)
                    {
                        sql = "SELECT StationName FROM tbl_stations WHERE Airplane = 1 AND StationNo > @serial_source AND StationNo < @serial_destination ORDER BY StationNo desc;";
                    }
                    else if (serial_source > serial_destination)
                    {
                        sql = "SELECT StationName FROM tbl_stations WHERE Airplane = 1 AND StationNo > @serial_destination AND StationNo < @serial_source ORDER BY StationNo;";
                    }
                    else
                    {
                        sql = "";
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@serial_source", serial_source);
                    cmd.Parameters.AddWithValue("@serial_destination", serial_destination);

                    SqlDataReader reader = null;
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            array[i] = reader.GetString(0);
                        }
                        mid = array[0];
                    }
                    
                }

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

        // ticket number from database
        public bool ticket_no()
        {
            bool isSuccess = false;
            int i = 0;
            int[] t_no = new int[10];
            // Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql;

                SqlDataReader reader = null;

                sql = "SELECT MAX(TicketNo) AS TicketNo FROM ticket_history";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Open Connecction
                conn.Open();
                // Read the database for flag of bus, train & air
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // this is how record is read. Loop through the each record
                        t_no[i] = reader.GetInt32(0);
                        ++i;
                        ticketno = t_no[0] + 1;
                    }
                }
                isSuccess = true;
            }
            catch (Exception Ex)
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

                sql = "SELECT AIR, TRAIN, BUS FROM ticket_price WHERE DistanceTill >= @distance";
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

        public bool add_ticket(TicketClass c, String flag_for_mode)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            
            try
            {
                String sql;
                sql = "INSERT INTO ticket_history (Source, Destination, Date, Mode, Fare, Distance, UserID) VALUES (@Source, @Destination, @date, @Mode, @Fare, @Distance, @UserID)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Source", source);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Mode", mode);
                cmd.Parameters.AddWithValue("@Fare", price);
                cmd.Parameters.AddWithValue("@Distance", distance);
                cmd.Parameters.AddWithValue("@UserID", user_id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else it will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
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

        public DataTable Select()
        {
            //step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //step 2: writing sql query
                string sql = "SELECT TicketNo, Source, Destination, Date AS 'Date of Journey', Mode, Fare, Distance AS 'Distance(KM)' FROM ticket_history";
                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool login_check()
        {
            bool issuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "SELECT Password FROM id_pass WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", user_id);
                cmd.Parameters.AddWithValue("@Password", password);
                
                conn.Open();

                SqlDataReader reader = null;
                reader = cmd.ExecuteReader();
                
                if(reader.HasRows)
                {

                    issuccess = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return issuccess;
        }
        public bool login_check_admin()
        {
            bool issuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "SELECT Password FROM id_pass WHERE Username = @Username AND Password = @Password AND Admin = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", user_id);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();

                SqlDataReader reader = null;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    issuccess = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return issuccess;

        }
    }
}
