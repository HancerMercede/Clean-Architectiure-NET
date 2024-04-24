using Kata_1.Dtos;
using Kata_1.Entities;

namespace Kata_1.Contracts;

public interface ICreate
{
    User Execute(UserInfoDto user);
}
