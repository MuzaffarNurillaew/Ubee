using AutoMapper;
using Ubee.Data.IRepositories;
using Ubee.Data.Repositories;
using Ubee.Domain.Entities;
using Ubee.Service.DTOs;
using Ubee.Service.Helpers;
using Ubee.Service.Interfaces;

namespace Ubee.Service.Services;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository = new UserRepository();
    private readonly IMapper mapper;
    public UserService(IMapper mapper)
    {
        this.mapper = mapper;
    }

    public async ValueTask<Response<UserDto>> AddUserAsync(UserForCreationDto userForCreationDto)
    {
        var user = await this.userRepository.SelectUserAsync(user =>
            user.Username.Equals(userForCreationDto.Username) ||
            user.Phone.Equals(userForCreationDto.Phone));
        if (user is not null)
            return new Response<UserDto>
            {
                Code = 404,
                Message = "User is already existed",
                Value = (UserDto)user
            };

        var mappedUser = this.mapper.Map<User>(userForCreationDto);
        var addedUser = await this.userRepository.InsertUserAsync(mappedUser);
        var resultDto = this.mapper.Map<UserDto>(addedUser);
        return new Response<UserDto>
        {
            Code = 200,
            Message = "Success",
            Value = resultDto
        };
    }

    public ValueTask<Response<bool>> DeleteUserAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Response<List<UserDto>>> GetAllUserAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<Response<UserDto>> GetUserByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Response<UserDto>> ModifyUserAsync(long id, UserForCreationDto userForCreationDto)
    {
        throw new NotImplementedException();
    }
}
