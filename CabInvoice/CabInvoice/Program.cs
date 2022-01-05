// See https://aka.ms/new-console-template for more information
using CabInvoice;
//Step 1-CalculateFare-NormalRide
InvoiceGenerator invoice = new InvoiceGenerator();
double fare = invoice.CalculateFare(2.0, 5);
Console.WriteLine(fare);