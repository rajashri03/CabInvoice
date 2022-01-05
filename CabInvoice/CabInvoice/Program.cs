// See https://aka.ms/new-console-template for more information
using CabInvoice;
bool run = true;
while(run)
{
    Console.WriteLine("*****************Cab Invoice*************************");
    Console.WriteLine("Select option:" +
        "1)Calculate fare" +
        "2)Multiple Rides");
    int op = Convert.ToInt16(Console.ReadLine());
    switch(op)
    {
        case 1:
            //Step 1-CalculateFare-NormalRide
            InvoiceGenerator invoice = new InvoiceGenerator();
            double fare = invoice.CalculateFare(2.0, 5);
            Console.WriteLine("Calculate Fare:", fare);
            break;
        case 2:
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Rides[] rides = { new Rides(2.0, 5), new Rides(1, 1) };
            double totalfare = invoiceGenerator.CalculateFare(rides);
            int numofride = 2;
            double expectedtotalfare = 36;
            double avg = expectedtotalfare / numofride;
            System.Console.WriteLine("Avg:" + avg);
            break;
    }
}
