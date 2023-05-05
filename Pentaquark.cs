// Define a class for the pentaquark particle
public class Pentaquark
{
    private int quarkCount;     // Number of quarks in the particle
    private int antiquarkCount; // Number of antiquarks in the particle
    
    // Constructor to create a pentaquark with four quarks and one antiquark
    public Pentaquark()
    {
        quarkCount = 4;
        antiquarkCount = 1;
    }
    
    // Method to get the baryon number of the pentaquark
    public double GetBaryonNumber()
    {
        double quarkBaryonNumber = 1.0/3.0;
        double antiquarkBaryonNumber = -1.0/3.0;
        double totalBaryonNumber = (quarkCount * quarkBaryonNumber) + (antiquarkCount * antiquarkBaryonNumber);
        return totalBaryonNumber;
    }
    
    // Method to check if the pentaquark is an exotic baryon
    public bool IsExoticBaryon()
    {
        return quarkCount == 5;
    }
}

// Main program to create and use a pentaquark object
public class Program
{
    public static void Main()
    {
        Pentaquark pentaquark = new Pentaquark();
        double baryonNumber = pentaquark.GetBaryonNumber();
        bool isExotic = pentaquark.IsExoticBaryon();
        
        Console.WriteLine("The pentaquark has a baryon number of " + baryonNumber);
        
        if (isExotic)
        {
            Console.WriteLine("The pentaquark is an exotic baryon.");
        }
        else
        {
            Console.WriteLine("The pentaquark is not an exotic baryon.");
        }
    }
}
