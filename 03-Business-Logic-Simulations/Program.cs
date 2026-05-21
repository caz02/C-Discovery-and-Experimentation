// 1. This is the blueprint for a single Valve object
public class Valve
{
    public string Name { get; set; }
    public double FlowRate { get; set; }
    public bool IsOpen { get; set; }
}

// 2. This is the processor you need to finish
public class ValveSafetyMonitor
{
    public int CountDangerousOpenValves(Valve[] valves)
    {
        // Guard Clause: What if the array is null or empty?
        if (valves == null || valves.Length == 0)
        {
            return 0;
        }

        int dangerCount = 0;

        // Loop through all the Valve objects
        for (int i = 0; i < valves.Length; i++)
        {
            // C# Tip: Instead of getting a raw number, we get the whole Valve object!
            Valve currentValve = valves[i];

            // --- WRITE YOUR CODE BELOW THIS LINE ---

            // HINT: You can access the valve's information using a dot, 
            // like this: currentValve.IsOpen or currentValve.FlowRate

            // Check if the currentValve is OPEN AND its FlowRate is strictly greater than 50.0
            
                // If both are true, increment your dangerCount scoreboard
            

            // --- WRITE YOUR CODE ABOVE THIS LINE ---
        }

        // Return the final scoreboard total
        return dangerCount;
    }
}
//Tips for your C# brain:
//In JavaScript, you’d do currentValve.isOpen. In C#, properties usually start with a Capital letter: currentValve.IsOpen.

//Remember that && means AND.

//For the boolean check, you can write if (currentValve.IsOpen == true) or just simply if (currentValve.IsOpen). Both work!