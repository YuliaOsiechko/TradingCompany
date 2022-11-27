using DTO;

namespace DAL
{
    public interface IManagerRepository
    {
        void Create(ManagerDTO newUser);
        void UpdateDispName(string login, string newDispName);
        void UpdatePassword(string login, string newPassword);
        ManagerDTO Get(string login);
        ManagerDTO Get(int id);
    }
}