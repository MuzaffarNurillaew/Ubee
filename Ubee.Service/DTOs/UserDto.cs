using Ubee.Domain.Entities;

namespace Ubee.Service.DTOs;

public class UserDto
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Username { get; set; }
    public string Phone { get; set; }
    public string Currency { get; set; }
    public string CountOfUsers { get; set; }

    public static explicit operator UserDto(User user)
    {
        return new UserDto
        {
            Currency = user.Currency,
            Firstname = user.Firstname,
            Lastname = user.Lastname,
            Phone = user.Phone,
            Username = user.Username,
        };
    }
}
