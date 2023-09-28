using Microsoft.AspNetCore.Components.Forms;
using MinistryOfWarerResources.Models;
using MinistryOfWarerResources.ViewModels;

namespace MinistryOfWarerResources.BackEnd.Interfaces
{
    public interface IDawa
    {
        public Task<bool> CheckIfDawaExistsInDB(string DawaNumber);
        public Task<string> AddNewDawaToTheSystem(DaawaModel NewDawa);
        public Task<List<DaawaModel>> GetAllDawas();
        public Task<string> DeleteDawa(int DawaId);
        public Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas);
        public Task<bool> EditEmp(DaawaModel EditedData, InputFileChangeEventArgs EditedPic);
        public Task<EmpViewModel> GetEmpViewModelByUserId(int Id);
        public Task<string> EditEmpViewModel(EmpViewModel EditedEmp);
    }
}
