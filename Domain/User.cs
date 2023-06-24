namespace Domain;

public class User : Entity
{
    public string Username { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private User(string username, string firstName, string lastName)
    {
        Username = username;
        FirstName = firstName;
        LastName = lastName;
    }

    public static User Create(string username, string firstname, string lastname)
    {
        return new User(username, firstname, lastname);
    }
}

