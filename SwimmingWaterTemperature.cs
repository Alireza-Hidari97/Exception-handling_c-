using System;
using static System.Console;
class SwimmingWaterTemperature
{
   static void Main()
   {
      const int QUIT = 999;
      int waterTemp;
      bool isComfortable;
      Write("Enter temperature or {0} to quit >> ", QUIT);
      int.TryParse(ReadLine(), out waterTemp);
      while(waterTemp != QUIT)
      {
         try
         {
            isComfortable = CheckComfort(waterTemp);
            if(isComfortable)
               WriteLine("{0} degrees is comortable for swimming.", waterTemp);
            else
               WriteLine("{0} degrees is not comfortable for swimming.", waterTemp);
         }
         catch(ArgumentException ae)
         {
            WriteLine(ae.Message);
         }
         Write("Enter another temperature or {0} to quit >> ", QUIT);
         int.TryParse(ReadLine(), out waterTemp);
      }
   }
   private static bool CheckComfort(int temp)
   {
      bool isComfortable = true;
      const int LOW = 32;
      const int HIGH = 212;
      const int LOWCOMFORT = 70;
      const int HIGHCOMFORT = 85;
      if(temp < LOW || temp > HIGH)
         throw(new ArgumentException());
      if(temp < LOWCOMFORT || temp > HIGHCOMFORT)
         isComfortable = false;
      return isComfortable;
   }
}  

