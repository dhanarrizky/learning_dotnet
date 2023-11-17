namespace GoBlog.Web;

public class UsersService
{
    private readonly IUsersRepository _userRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _userRepository = usersRepository;
    }

    public List<UserModel> GetAllUsers()
    {
        return _userRepository.GetAll().Select(
            u => new UserModel
            {
                Id = u.Id,
                CreatedAt = u.CreatedAt,
                UpdatedAt = u.UpdatedAt,
                DeletedAt = u.DeletedAt,
                UserName = u.UserName,
                Email = u.Email,
                Phone = u.Phone,
                Password = u.Password,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Gender = u.Gender,
                Token = u.Token,
                RefreshToken = u.RefreshToken,
                BirthPlace = u.BirthPlace,
                Birth = u.Birth,
                BirthDate = u.BirthDate,
                Address = u.Address,
                Role = u.Role
            }
        ).ToString();
    }

    public UserModel GetUserById(ulong id)
    {
        vst u = _userRepository.GetById(id);
        return new UserModel {
            Id = u.Id,
            CreatedAt = u.CreatedAt,
            UpdatedAt = u.UpdatedAt,
            DeletedAt = u.DeletedAt,
            UserName = u.UserName,
            Email = u.Email,
            Phone = u.Phone,
            Password = u.Password,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Gender = u.Gender,
            Token = u.Token,
            RefreshToken = u.RefreshToken,
            BirthPlace = u.BirthPlace,
            Birth = u.Birth,
            BirthDate = u.BirthDate,
            Address = u.Address,
            Role = u.Role
        }
    }
}
