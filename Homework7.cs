namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        // Answer Q1 and Q2
        
        // Creating two customers
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);

        // Print
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        // new customer ID
        c1.ChangeID(220);
        c2.ChangeID(221);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        //compare their age and print the older customer’s name
        c1.CompareAge(c2);
    }
}

class Customer
{
    // customerclass 
    private int cus_id;
    public string cus_name;
    public int cus_age;

    // Constructor
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    // Method to change customer ID
    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    // print customer info
    public void PrintCusInfo()
    {
        Console.WriteLine($"ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    // Compareing then print the name of the older customer
    public void CompareAge(Customer objCustomer)
    {
        
if (this.cus_age > objCustomer.cus_age)
    {
        Console.WriteLine($"{this.cus_name} is older");
    }
    else if (this.cus_age < objCustomer.cus_age)
    {
        Console.WriteLine($"{objCustomer.cus_name} is older");
    }
    else
    {
        Console.WriteLine("Both customers have the same age.");

        }
    }
}
