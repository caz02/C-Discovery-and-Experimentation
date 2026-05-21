class ValidateArguments 
{
    public int Validate(string[] args) 
    {
        //step 1: check if box is empty or doesn't exist
        if (args == null || args.Length == 0)
        {
            return -1; // error code for empty or null arguments
        }
        bool helpRequested = false;

        //step 2: loop to look at each card
        for(int i = 0; i < args.Length; i++)
        { 
            string currentCard = args[i].ToLower();//default to lower case
        
        if(currentCard == "--help") 

            {
            helpRequested = true; //Flip the sticky note
            continue; // go to next card

            }

        if(currentCard == "--name")
        {
        if (i + 1 >= args.Length) {

        return -1; // Error bc there is no card after --name

        }
        string nameValue = args[i + 1]; // the actual name is after the name card so +1

        if(nameValue.Length < 3 || nameValue.Length > 10) // if less than 3 or more than 10
        {
            return -1; //error
            
        }

        i++; //keep going
            
        }
        if(currentCard == "--count") 
        {
        if (i + 1 >= args.Length) { // no card after count
            return -1; // error
        }
        string countValue = args[i + 1]; // get the value

        int parsedCount; // convert to integer

        if (!int.TryParse(countValue, out parsedCount)){ // if it can't be converted e.g potatoes
            
            return -1; // error
            
            }
        
        if (parsedCount >= 10 && parsedCount <= 100){ // if so check it's more than or equal to 10 and less than or eq to 100

        i++; // keep going
        continue; //keep going
        
        }

        return -1; // for anything else that goes wrong

        }
             return - 1; // if any array items are weird, like banana
}
if (helpRequested) // to look through the rest of the array to make sure all is ok
{
    return 0; // Everything was valid, but they asked for help.
}else
{
return 1; // Everything was valid, and they DIDN'T ask for help. Proceed!
}
    }
}
