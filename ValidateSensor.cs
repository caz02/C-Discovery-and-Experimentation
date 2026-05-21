public class SensorDataProcessor
{
    public double CalculateAverageTemperature(double[] readings)
    {
        // 1. Guard clause: what if the array is null or empty?
        if (readings == null || readings.Length == 0)
        {
            return 0.0; 
        }

        double totalSum = 0.0;
        int validReadingsCount = 0;

        // 2. Loop through the data
        for (int i = 0; i < readings.Length; i++)
        {
            double currentTemp = readings[i];

            // --- WRITE YOUR CODE BELOW THIS LINE ---

            if(currentTemp < -999.0)
            {
                continue;
            
            }

            if(currentTemp > 100.0)
            {
                return 999.9;

            }

            totalSum = currentTemp + totalSum;
            validReadingsCount++;
            
        }

        // 3. Final Calculation
        if (validReadingsCount == 0)
        {
            return 0.0; // Avoid dividing by zero if no valid readings were found!
        }

        // Calculate the average (Total divided by the Count)
        return totalSum / validReadingsCount;
    }
}

