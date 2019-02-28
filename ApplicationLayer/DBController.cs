using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
    public class DBController
    {
        private static string connectionString =
            "Server=ealsql1.eal.local; Database= " +
            "A_DB09_2018; User Id= A_STUDENT09; Password=A_OPENDB09;";

        public void RegisterNewCustomer(Customer c)
        {
            InsertCustomer(c);
        }
        private void InsertCustomer(Customer c)
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
                        (new SqlParameter("@CustomerFirstName", c.FirstName));
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerLastName", c.LastName));
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerStreetName", c.Address));
                    cmd1.Parameters.Add
                        (new SqlParameter("@CustomerZipCode", c.ZipCode));
                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Et eller andet mærkværdigt, " +
                        "et eller andet sted i verden, gik galt." + e.Message);
                }
            }
        }
        public string CheckCustomer(string fullName, string address)
        {
			string customerId = null;
			string fName = null;
			string lName = null;
			string adress = null;
			string zip = null;


			string[] name = fullName.Split(' ');

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("LookUpCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd1.Parameters.Add(new SqlParameter("@CustomerFirstname", name[0]));
					cmd1.Parameters.Add(new SqlParameter("@CustomerLastName", name[1]));
					cmd1.Parameters.Add(new SqlParameter("@Address", address));
					cmd1.ExecuteNonQuery();

					SqlDataReader reader = cmd1.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							customerId = reader["CustomerId"].ToString();
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
