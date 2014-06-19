using System;

class ProductOf3NumsSign
    {
        static void Main()
            {        
            Console.WriteLine("Enter three real numbers:");        
            int firstNumber = int.Parse(Console.ReadLine());        
            int secondNumber = int.Parse(Console.ReadLine());        
            int thirdNumber = int.Parse(Console.ReadLine());
        
            if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)        
            {            
                Console.WriteLine("The product will be +");        
            }        
            else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)        
            {            
                Console.WriteLine("The product will be -");        
            }        
            else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)        
            {            
                Console.WriteLine("The product will be -");        
            }        
            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)        
            {            
                Console.WriteLine("The product will be -");        
            }        
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)        
            {            
                Console.WriteLine("The product will be +");        
            }        
            else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)        
            {            
                Console.WriteLine("The product will be +");        
            }        
            else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)        
            {            
                Console.WriteLine("The product will be +");        
            }       
            else        
            {            
                Console.WriteLine("The product will be -");        
            }    
        }
}


      