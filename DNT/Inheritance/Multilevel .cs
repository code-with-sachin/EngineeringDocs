public class Person  
{  
    public string persondet()  
    {  
        return "this is the person class";  
    }  
}  
public class Bird : Person  
{  
    public string birddet()  
    {  
        persondet();  
        return "this is the birddet Class";  
    }  
}  
public class Animal : Bird  
{  
    public string animaldet()  
    {  
        persondet();  
        birddet();  
        return "this is the Animal Class";  
    }  
} 