using Lab5.Application.Models;

namespace Lab5.Application.Abstractions.Repository;

public interface IUserRepository
{
    public User? FindUser(string username, int id);
}