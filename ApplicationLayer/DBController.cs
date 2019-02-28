using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class DBController
    {
        private static string connectionString =
            "Server=ealsql1.eal.local; Database= " +
            "A_DB09_2018; User Id= A_STUDENT09; Password=A_OPENDB09;";

        public void NewCustomer(string fName, string lName, string adress, int zip)
        {
            InsertCustomer(fName, lName, adress, zip);
        }
        private void InsertCustomer(string fName, string lName, string address, int zip)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("spRegisterNewCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerFirstName", fName));
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerLastName", lName));
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerStreetName", address));
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerZipCode", zip));
                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Et eller andet mærkværdigt, " +
                        "et eller andet sted i verden, gik galt." + e.Message);
                }
            }
        }
        public string GetCustomer(int customerId)
        {
            string fName = null;
            string lName = null;
            string adress = null;
            string zip = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spLookUpCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd1.Parameters.Add(new SqlParameter("@CustomerId", customerId));
                    cmd1.ExecuteNonQuery();

                    SqlDataReader reader = cmd1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            fName = reader["CustomerFirstName"].ToString();
                            lName = reader["CustomerLastName"].ToString();
                            adress = reader["StreetName"].ToString();
                            zip = reader["ZipCode"].ToString();

                        }
                    }
                    return "\nID: " + customerId +
                        "\nNavn: " + fName + " " + lName + 
                        "\nAdresse: " + adress + " " + zip;
                }
                catch (SqlException e)
                {
                    return ("Et eller andet mærkværdigt, " +
                        "et eller andet sted i verden, gik galt." + e.Message);
                }
            }
        }
    }
}
