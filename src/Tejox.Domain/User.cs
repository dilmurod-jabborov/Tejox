using System.Security.Cryptography.X509Certificates;

namespace Tejox.Domain;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

public class Currenc
