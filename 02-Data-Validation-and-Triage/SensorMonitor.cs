public class SensorMonitor
{
    public int CheckTemperatures(int[] temps)
    {
        if (temps == null || temps.Length == 0)
        {
            return -1; // error code for empty or null arguments
        }
        //step 2: loop to look at each card
        for(int i = 0; i < temps.Length; i++)
        {
            int currentTemp = temps[i]; // get the current item
        

            if(currentTemp >= 100 ){ //check if it's more than 100 overheat
                return -2; // overheat

            }
            if(currentTemp <= -10 ){ // check if less than -10
                return -3; // freezing

            }

            if (i + 1 < temps.Length){ // next array item/ next day
            
            int spikeTemp = Math.Abs(temps[i+1] - temps[i]); // get difference of the 2 temps and ensure it's valid

            if (spikeTemp > 30 ){ // more than 30, problem
                
                return -4; // problem
            } 
            }


            }
            return 1; // otherwise fine
        }
        
    }
