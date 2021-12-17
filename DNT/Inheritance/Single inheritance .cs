public class Accountcreditinfo //base class    
{  
    public string Credit()  
    {  
        return "balance is credited";  
    }  
}  
public class debitinfo : Accountcreditinfo //derived class    
{  
    public string debit()  
    {  
        Credit();                       //derived class method    
        return "balance is debited";  
    }  
} 

