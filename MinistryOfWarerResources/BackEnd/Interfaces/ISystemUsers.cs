using Microsoft.AspNetCore.Identity;
using MinistryOfWarerResources.ViewModels;

namespace MinistryOfWarerResources.BackEnd.Interfaces
{
    public interface ISystemUsers
    {
        public Task<List<IdentityUser>> GetAllUsers();
        public Task<bool> AddUSerToAdminRole(string UserID);
        public Task<bool> AddUSerToRegularRole(string UserID);
        public Task<bool> AddUSerToDawaViewRole(string UserID);
        public Task<bool> AddUSerToJazaeaViewRole(string UserID);
        public Task<bool> AddUSerToViewAllRole(string UserID);
        public Task<bool> AddUSerToSuperVisorRole(string UserID);
        public Task<bool> AddUSerToAdmin2Role(string UserID);

        public Task<bool> EditRoleFromAdminToRegulator(string UserId);
        public Task<List<AllUSersViewModel>> GetListAllUSersWithRoles();






        public Task<bool> EditAllRoleToAdmin(string UserId);
        public Task<bool> EditAllRoleToDawaView(string UserID);
        public Task<bool> EditAllRoleToJazeaView(string UserID);
        public Task<bool> EditAllRoleToRegulator(string UserID);
        public Task<bool> EditAllRoleToSuperAdmin(string UserID);
        public Task<bool> EditAllRoleToAdmin2(string UserID);







    }
}
