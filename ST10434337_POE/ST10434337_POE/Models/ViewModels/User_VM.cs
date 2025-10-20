namespace ST10434337_POE.Models.ViewModels
{
    // Used in Selecting A user/ ChanegeUserSession
    public class User_VM
    {
        //Who 
        public int UserId { get; set; }

        // What privilage does a user have, ie what does thier UI look like
        public UserType Type { get; set; }

        // Concat Name with Surname
        public string FullName { get; set; }
    }
}
