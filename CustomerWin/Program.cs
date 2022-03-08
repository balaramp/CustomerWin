// See https://aka.ms/new-console-template for more information


CustomersInfo.CustomerInfo CustomerInfo = new CustomersInfo.CustomerInfo();
CustomerInfo.Init();
Console.WriteLine("Please enter Customer Id:");

var customerPackageInfo  = CustomerInfo.GetCustomerWinInfo(Convert.ToInt32(Console.ReadLine()));

if (customerPackageInfo != null)
{
    Console.Write("Customer {0} has ordered {1} package",
                            customerPackageInfo.Name.Trim(),
                            customerPackageInfo.Type);

    Console.Write(customerPackageInfo.Won ? " already Won" : " not yet won");
    Console.WriteLine(customerPackageInfo.EligableToWin ? " and is Eligible to Win" : " and is not Eligible to Win");
}
else
    Console.WriteLine("Customer not exists");

Console.ReadLine();