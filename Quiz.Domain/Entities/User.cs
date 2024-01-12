using Quiz.Domain.Primitives;
using Quiz.Domain.ValueObjects;

namespace Quiz.Domain.Entities;

public class User : Entity<Guid>
{

    public Username Username { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public ICollection<User> Friends { get; private set; }

    private User(Guid id, Username username, Email email, Password password, ICollection<User> friends) : base(id)
    {
        Username = username;
        Email = email;
        Password = password;
        Friends = friends;
    }

    public static User Create(Guid id, Username username, Email email, Password password, ICollection<User> friends)
    {
        //check for unique email 

        return new User(id, username, email, password, friends);
    }
}