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
    class SIgnupClass
    {
        public static String userid { get; set; }
        public static String password { get; set; }
        public static String name { get; set; }
        public static String email { get; set; }
        public static int age { get; set; }
        public static String state {get; set;}
        public static String country { get; set; }
        public static int mobile { get; set; }

        
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool signup()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String create;

                create = "CREATE TABLE IF NOT EXISTS @userid( pnr int;)";
                SqlCommand create_cmd = new SqlCommand(create, conn);
                create_cmd.Parameters.AddWithValue("@userid", userid);
                conn.Open();
                int rows = create_cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
                
                
            
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                
            }
            return success;
        }

    }
}
