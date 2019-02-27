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

        public void NewCustomer(string fName, string lName, string adress, int zip )
        {
            InsertCustomer(fName, lName, adress, zip);
        }
        public void InsertCustomer(string fName, string lName, string address, int zip)
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
            string customerName = null;
            string customerAdress = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spGetCustomer", con)
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
                            customerName = reader["CustomerName"].ToString();
                            customerAdress = reader["CustomerAdress"].ToString();
                        }
                    }
                    return "\nID: " + customerId +
                        "\nNavn: " + customerName +
                        "\nAdresse: " + customerAdress;
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
