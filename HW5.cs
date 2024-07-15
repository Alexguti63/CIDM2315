namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer();
        c1.cus_id = 110;
        c1.cus_name = "Alice";
        c1.cus_age = 28;
        c1.PrintCusInfo();
        Customer c2 = new Customer();
        c2.cus_id= 111;
        c2.cus_name = "Bob";
        c2.cus_age = 30;
        c2.PrintCusInfo();
        c1.ChangeId(220);
        c1.PrintCusInfo();
        c2.ChangeId(221);
        c2.PrintCusInfo();
        Customer alice = new Customer(cus_age: 28, cus_name: "Alice");
        Customer bob = new Customer(cus_age: 30, cus_name: "Bob");
        alice.CompareAge(bob);
    }
}
class Customer {
    private int _cus_id;
    public int cus_id {
        get {return _cus_id;}
        set {_cus_id = value;}
    }
    public string cus_name;
    public int cus_age;
    public Customer(){
        cus_id = 0;
        cus_name = "";
        cus_age = 0;
    }
    public void ChangeId(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine("Customer: " + cus_id + ", name: "+ cus_name + ", age: "+ cus_age);
    }
    public Customer(int cus_age, string cus_name){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age > objCustomer.cus_age){
            Console.WriteLine(this.cus_name + " is older");
        }
        else {
            Console.WriteLine(objCustomer.cus_name + " is older");
        }
    }
}
