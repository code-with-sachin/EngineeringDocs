public interface IA //ineterface  1    
{  
    string setImgs(string a);  
}  
public interface IB  //Interface 2    
{  
    int getAmount(int Amt);  
}  
public class ICar : IA, IB //implementation    
{  
    public int getAmount(int Amt)  
    {  
        return 100;  
    }  
    public string setImgs(string a)  
    {  
        return "this is the car";  
    }  
} 