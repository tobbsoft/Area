namespace AreaUygulama.Models
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }


    public class AdminInit
    {
        public static List<Admin> Init()
        {
            return new List<Admin>() {
                new Admin { Username = "ali", Password = "123456"},
                new Admin { Username = "osman", Password = "123456"},
                new Admin { Username = "Haydar", Password = "123456"}
            };
        }
    }

}
