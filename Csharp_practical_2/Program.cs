class Customer_Account
{
    public string? bank_name;
    private long customer_accountNo;
    private string? customer_name;

    public Customer_Account(long customer_accountNo,string customer_name)
    {
        this.customer_accountNo = customer_accountNo;
        this.customer_name = customer_name;
    }

    /*
        PrintInfo() method have just simple work just print the Customer Bank Details such has bank name, customer account number
        customer name ... and it's return type is void because it just print the details not return so void PrintInfo() && it's access
        modifier is public bcoz it access anywhere within or outside of theire scope!
    */
    public void PrintInfo()
    {
        Console.WriteLine("\n =================== Customer Bank Details ===================");
        Console.WriteLine($"\n Bank Name : {bank_name} ");
        Console.WriteLine($" Customer Account Number : {customer_accountNo} ");
        Console.WriteLine($" Customer Name : {customer_name} ");
        Console.WriteLine("\n =============================================================");
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Customer_Account customer_Account1 = new(342312332123,"Jil Patel");
        customer_Account1.bank_name = "SBI";
        customer_Account1.PrintInfo();

        Customer_Account customer_Account2 = new(342654332123, "Abhi Patel");
        customer_Account2.bank_name = "HDFC";
        customer_Account2.PrintInfo();

        Customer_Account customer_Account3 = new(342385332123, "Bhavin Patel");
        customer_Account3.bank_name = "KOTAK";
        customer_Account3.PrintInfo();

        Console.ReadKey();
    }
}