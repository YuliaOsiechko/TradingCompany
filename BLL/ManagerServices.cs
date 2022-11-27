using DAL;
using DTO;

namespace BLL
{
    public class ManagerServices : IManagerServices
    {
        public IManagerRepository _managerRepository { get; set; }
        public ManagerServices(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }
        public void Add(ManagerDTO newManager) => _managerRepository.Create(newManager);
        public bool CheckPassword(string login, string password) => _managerRepository.Get(login)?.Password == password;
        public ManagerDTO Get(string login) => _managerRepository.Get(login);
        public ManagerDTO Get(int id) => _managerRepository.Get(id);
        public void UpdateDispName(string login, string newDispName) => _managerRepository.UpdateDispName(login, newDispName);
        public void UpdatePassword(string login, string newPassword) => _managerRepository.UpdatePassword(login, newPassword);
    }
}