public class UserProcessor
{
    public int CountValidUsers(string[] users)
    {
        if (users == null || users.Length == 0){
            return -1; // error for empty or null
        }
        
        int validCount = 0; // Initialize a counter to keep track of how many valid users we find

        for (int i = 0; i < users.Length; i++) //look through each username
        {
            string name = users[i]; //get the username from the users string

            if (string.IsNullOrWhiteSpace(name)) // Skip if the username is completely empty or just blank spaces
            {
                continue; //move on
            }

            if (name.ToLower() == "admin")// if username is admin ADMIN aDmIn AdmiN all variations
            {
                continue; //move on
            }

            if (name.Length >= 3 && name.Length <= 15) // if the length of username is more than 3 and less than 15 
            {
                validCount++; //+1 to the number of valid users list
            }
        }

        return validCount; // not sure, return the validCount total?
    }
}