using DataBusiness;
using DataAccess.Models;
namespace GoBlog.Web;

public class UsersService
{
    private readonly IUsersRepository _userRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _userRepository = usersRepository;
    }

    public ReturnUserResponseModels GetAll()
    {
        List<UserModel> users = _userRepository.GetAll().Select(
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
        ).ToList();

        ReturnUserResponseModels result = new ReturnUserResponseModels {
            GetAllUsers = users
        };

        return result;
    }

    public ReturnUserResponseModels GetById(ulong id)
    {
        var u = _userRepository.GetById(id);
        UserModel user = new UserModel {
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
        };

        ReturnUserResponseModels result = new ReturnUserResponseModels {
            GetUser = user
        };

        return result;
    }

    public ReturnUserResponseModels Create(UserModel u)
    {
        var user = new User {
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
        };
        var response = _userRepository.Create(user);
        ReturnUserResponseModels result = new ReturnUserResponseModels();
        if(response == null){
           result.CreateUser = "faild to created the user";
           result.GetUser = u;
        } else {
           result.CreateUser = "Create user has been successfully";
           result.GetUser = u;
        }

        return result;
    }

    public ReturnUserResponseModels Update(UserModel u)
    {
        var user = new User {
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
        };

        var response = _userRepository.Update(user);
        if(response > 0){
            return new ReturnUserResponseModels{
                UpdateMessage = "Updated User Data has been successfully !!!"
            };
        }
        return  new ReturnUserResponseModels{
                UpdateMessage = "Faild to updated data"
            };
    }

    public ReturnUserResponseModels Delete(ulong id)
    {
        var response = _userRepository.Delete(id);
        if(response > 0){
            return new ReturnUserResponseModels{
                DeleteMessage = "Deleted User Data has been successfully !!!"
            };
        }
        return new ReturnUserResponseModels{
                DeleteMessage = "Faild to Deleted data"
            };
    }
}
