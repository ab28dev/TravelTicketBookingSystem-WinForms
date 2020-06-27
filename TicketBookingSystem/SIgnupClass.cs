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
    class SignupClass
    {
        public static String userid { get; set; }
        public static String password { get; set; }
        public static String name { get; set; }
        public static String email { get; set; }
        public static int age { get; set; }
        public static String state {get; set;}
        public static String country { get; set; }
        public static String mobile { get; set; }

        
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool signup()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String search;
                search = "SELECT Username FROM id_pass WHERE Username = @userid;";
                SqlCommand search_cmd = new SqlCommand(search, conn);
                search_cmd.Parameters.AddWithValue("@userid", userid);
                conn.Open();
                int row = search_cmd.ExecuteNonQuery();
                conn.Close();
                if(row > 0 )
                {
                    MessageBox.Show("The user id already exist. Try againg with another user id.");
                    success = false;
                }
                else
                {
                    
                    // Inserting the id pass in table id_pass in DB
                    String add_user;
                    add_user = "INSERT INTO id_pass (Username, Password, Admin) VALUES (@Username, @Password, 0);";
                    SqlCommand add_user_cmd = new SqlCommand(add_user, conn);
                    add_user_cmd.Parameters.AddWithValue("@Username", userid);
                    add_user_cmd.Parameters.AddWithValue("@Password", password);
                    conn.Open();
                    int rows = add_user_cmd.ExecuteNonQuery();
                    conn.Close();

                    if(rows > 0)
                    {
                        // Storing signup details in table user_details in DB
                        String add_signup_details;
                        add_signup_details = "INSERT INTO user_details (UserID, Password, Name, Email, Age, State, Country, Mobile) VALUES (@UserID, @Password, @Name, @Email, @Age, @State, @Country, @Mobile);";
                        SqlCommand sqlCommand = new SqlCommand(add_signup_details, conn);
                        sqlCommand.Parameters.AddWithValue("@USerID", userid);
                        sqlCommand.Parameters.AddWithValue("@Password", password);
                        sqlCommand.Parameters.AddWithValue("@Name", name);
                        sqlCommand.Parameters.AddWithValue("@Email", email);
                        sqlCommand.Parameters.AddWithValue("@Age", age);
                        sqlCommand.Parameters.AddWithValue("@State", state);
                        sqlCommand.Parameters.AddWithValue("@Country", country);
                        sqlCommand.Parameters.AddWithValue("@Mobile", mobile);
                        conn.Open();
                        int rowz = sqlCommand.ExecuteNonQuery();
                        if(rowz > 0)
                        {
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
                        conn.Close();
                    }
                    else
                    {
                        success = false;
                    }
                }            
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                MessageBox.Show("User Signup Successfull");
            }
            return success;
        }

    }
}
