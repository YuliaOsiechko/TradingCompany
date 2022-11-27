using DAL;
using DTO;

namespace BLL
{
    public interface IManagerServices
    {
        IManagerRepository _managerRepository { get; set; }
        void Add(ManagerDTO manger);
        bool CheckPassword(string login, string password);
        ManagerDTO Get(string login);
        ManagerDTO Get(int id);
        void UpdateDispName(string login, string newDispName);
        void UpdatePassword(string login, string newPassword);
    }
}