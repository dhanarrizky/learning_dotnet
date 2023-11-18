namespace GoBlog.Web;

public class ReturnUserResponseModels
{
    public List<UserModel>? GetAllUsers { get; set; }

    public UserModel? GetUser { get; set; }

    public string? CreateUser { get; set; }

    public string? UpdateMessage { get; set; }

    public string? DeleteMessage { get; set; }
}