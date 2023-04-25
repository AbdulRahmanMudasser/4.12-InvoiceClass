using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Class
{
    internal class InvoiceTest
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("342801", "Gaming Mouse", 3, 450.12m);

            Console.WriteLine("Invoice \n\nPart Number: {0} \nPart Description: {1} \nQuantity: {2} \nPrice Per Item: {3:C2} \nTotal: {4:C2}", invoice.PartNumber, invoice.PartDescription, invoice.Quantity, invoice.Price, invoice.GetInvoiceAmount());
        }
    }
}
