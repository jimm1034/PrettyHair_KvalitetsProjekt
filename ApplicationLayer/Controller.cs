using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class Controller
    {
        private DBController dbCon = new DBController();
        public void NewCustomer(string fName, string lName, string adress, int zip)
        {
            dbCon.NewCustomer(fName, lName, adress, zip);
        }

        public string FindCustomer(string customerId)
        {
            int.TryParse(customerId, out int Id);
            dbCon.GetCustomer(Id);

            return dbCon.GetCustomer(Id);
        }

        public string OrderByLine(string productTypeId, string quantity,
                                    string deliveryDate)
        {
            List<string> orderLines = new List<string>();
            orderLines.Add(productTypeId + quantity + deliveryDate);

            //Tænker at udskrive ordren linje for linje når totalordren gemmes.

            //Nedenstående skal omskrives når foreach er lavet
            return "id " + productTypeId +
                " Antal: " + quantity +
                " Afleveres den: " + deliveryDate.ToString();
        }
    }
}
