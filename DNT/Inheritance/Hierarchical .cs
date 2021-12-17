class A  //base class    
{  
    public string msg()  
    {  
        return "this is A class Method";  
    }  
}  
class B : A  
{  
    public string info()  
    {  
        msg();  
        return "this is B class Method";  
    }  
    class C : A  
    {  
        public string getinfo()  
        {  
            msg();  
            return "this is B class Method";  
        }  
    }  
}    