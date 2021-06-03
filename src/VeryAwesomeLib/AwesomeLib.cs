namespace AwesomeLib 
{
   public class AwesomeLibClass
   {
       public int AweomseReturn { get; }
       public AwesomeLibClass(int x)
       {
	  AweomseReturn = x;	
       }

       public int Double() => AweomseReturn * 2;
   }
}
