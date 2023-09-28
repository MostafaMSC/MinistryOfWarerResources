using Microsoft.AspNetCore.Components.Forms;
using MinistryOfWarerResources.Models;
using MinistryOfWarerResources.ViewModels;

namespace MinistryOfWarerResources.BackEnd.Interfaces
{
    public interface IJazaea
    {
        public Task<bool> CheckIfDawaExistsInDB(string DawaNumber);
        public Task<string> AddNewJzaeaToTheSystem(JazaeaModule NewDawa);
        public Task<List<JazaeaModule>> GetAllDawas();
        public Task<string> DeleteDawa(int DawaId);
        public Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas);
        public Task<bool> Editjazaea(JazaeaModule EditedData, InputFileChangeEventArgs EditedPic);
        public Task<JazaeaViewModel> GetJazaeaViewModelByUserId(int Id);
        public Task<string> EditJazaeaViewModel(JazaeaViewModel EditedEmp);
    }
}
