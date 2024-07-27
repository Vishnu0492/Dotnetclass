
namespace ProblemStatement
{
   static void main(string[] args)
    {
        int unitcharge, totalbill = 0;
        Console.WriteLine("Enter the total number of unit consumed");
        int unitconsumed = int.Parse(Console.ReadLine());
        if(unitconsumed<= 50)


        { unitcharge = 0.50;
            totalbill = unitconsumed * unitcharge;

        }
        else if(unitconsumed>50 && unitconsumed<150 )
        {
            unitcharge = 0.75;
            totalbill = 50*0.50+ (unitconsumed-50)  * unitcharge;

        }
        else if(unitconsumed>150 && unitconsumed<=250  )
        { }
    }


}