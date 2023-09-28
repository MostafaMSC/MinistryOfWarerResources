using MinistryOfWarerResources.Data;
using MinistryOfWarerResources.BackEnd.Interfaces;
using MinistryOfWarerResources.Models;
using Microsoft.EntityFrameworkCore;
using MinistryOfWarerResources.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using MinistryOfWarerResources.BackEnd.Interfaces;
using MinistryOfWarerResources.Data;
using MinistryOfWarerResources.Models;
using MinistryOfWarerResources.ViewModels;
using MudBlazor;



namespace MinistryOfWarerResources.BackEnd.Repositories
{
    public class DawaRepo : IDawa
    {
        private readonly ApplicationDbContext _db;
        private IWebHostEnvironment _env;

        public DawaRepo(ApplicationDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;

        }
        public async Task<string> AddNewDawaToTheSystem (DaawaModel NewDawa)
        {
            await _db.DawwaTable.AddAsync (NewDawa);
            await _db.SaveChangesAsync();
            return "تمت اضافة الدعوى الى النظام";
        }
        public async Task<bool> CheckIfDawaExistsInDB(string DawaNumber)
        {
            var CheckIfDawaExistsInDB = await _db.DawwaTable.FirstOrDefaultAsync(a => a.DawaNumber == DawaNumber.Trim());

            if (CheckIfDawaExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<string> DeleteDawa(int DawaId)
        {
            try
            {
                var DeletedDawa = await _db.DawwaTable.FirstOrDefaultAsync(a => a.Id == DawaId);
                _db.DawwaTable.Remove(DeletedDawa);
                await _db.SaveChangesAsync();
                return $"{DawaId} deleted Successfully";
            }
            catch (Exception Error)
            {

                return Error.Message;
            }

        }
        public async Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas)
        {
            try
            {
                var ListOfDeletedDawa = new List<DaawaModel>();

                foreach (var item in ListOfDeletedDawas)
                {
                    var Dawa = await _db.DawwaTable.FirstOrDefaultAsync(a => a.Id == item);
                    ListOfDeletedDawa.Add(Dawa);
                }
                _db.DawwaTable.RemoveRange(ListOfDeletedDawa);
                await _db.SaveChangesAsync();
                return "تم الحذف بنجاح ";

            }
            catch (Exception Error)
            {

                return Error.Message;
            }
        }
        public async Task<bool> EditEmp(DaawaModel EditedData, InputFileChangeEventArgs EditedPic)
        {
            if (EditedPic is null)
            {
                _db.DawwaTable.Update(EditedData);
                await _db.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<List<DaawaModel>> GetAllDawas()
        {
            var ListOfDawas = _db.DawwaTable.ToListAsync();
            return ListOfDawas;
        }


        private async Task<string> UploadUserImageToFileSystem(InputFileChangeEventArgs UploadedImage, string EmpName)
        {

            var FileName = EmpName + "_" + Guid.NewGuid().ToString() + $"{UploadedImage.File.Name}";
            // MohammedAbdull_109273918628736127835gbegt675e
            var FolderPath = $"{_env.WebRootPath}\\DawaImages";
            // var FullPath = //server/wwwroot/EmpImages/FileName
            var FullPath = Path.Combine(FolderPath, FileName);

            var MemoryStream = new MemoryStream();
            await UploadedImage.File.OpenReadStream(2000000).CopyToAsync(MemoryStream);


            // FileMode : to give permission to the filestream to create files
            await using (var fs = new FileStream(FullPath, FileMode.Create, FileAccess.Write))
            {
                MemoryStream.WriteTo(fs);
            }

            return FolderPath;
        }


        private void DeleteOldUserImage(string OldImagePath)
        {
            if (File.Exists(OldImagePath) == true)
            {
                File.Delete(OldImagePath);
            }
        }

        //public async Task<List<EmpModel>> GetListOfAllEmps()
        //{
        //    var ListOfEmps = await _db.EmpTable.AsNoTracking().Include(a=>a.DeptTable).ThenInclude(a=>a.OfficeTable).ToListAsync();
        //    return ListOfEmps;
        //}




        public async Task<EmpViewModel> GetEmpViewModelByUserId(int Id)
        {
            var Model = await _db.DawwaTable.FirstOrDefaultAsync(a => a.Id == Id);

            var EmpViewModel = new EmpViewModel();
            EmpViewModel.Id = Model.Id;
            EmpViewModel.DawaNumber = Model.DawaNumber;
            EmpViewModel.DawaType = Model.DawaType;
            EmpViewModel.Court = Model.Court;
            EmpViewModel.Decision1Num = Model.Decision1Num;
            EmpViewModel.LastUpdate = Model.LastUpdate;
            EmpViewModel.Name1 = Model.Name1;
            EmpViewModel.Name2 = Model.Name2;
            EmpViewModel.DawaSubject = Model.DawaSubject;
            EmpViewModel.SelectDawa = Model.SelectDawa;
            EmpViewModel.Office = Model.Office;
            //EmpViewModel.EmpDep = Model.EmpDep;
            EmpViewModel.AstanafNO = Model.AstanafNO;
            EmpViewModel.AkherALajraaat = Model.AkherALajraaat;
            EmpViewModel.qraraadaNO = Model.qraraadaNO;
            EmpViewModel.Notes = Model.Notes;
            EmpViewModel.TameezNO = Model.TameezNO;
            EmpViewModel.Decision1ImagePath = Model.Decision1ImagePath;
            EmpViewModel.TashehNO = Model.TashehNO;
            return EmpViewModel;
        }
        public async Task<string> EditEmpViewModel(EmpViewModel EditedEmp)
        {
            try
            {
                var Model = await _db.DawwaTable.FirstOrDefaultAsync(a => a.Id == EditedEmp.Id);

                Model.Name1 = EditedEmp.Name1;
                Model.Name2 = EditedEmp.Name2;
                Model.Court = EditedEmp.Court;
                Model.LastUpdate = EditedEmp.LastUpdate;
                Model.Decision1Num = EditedEmp.Decision1Num;
                Model.DawaType = EditedEmp.DawaType;
                Model.DawaNumber = EditedEmp.DawaNumber;
                Model.DawaSubject = EditedEmp.DawaSubject;
                Model.SelectDawa = EditedEmp.SelectDawa;
                Model.Office = EditedEmp.Office;
                Model.AstanafNO = EditedEmp.AstanafNO;
                Model.AkherALajraaat = EditedEmp.AkherALajraaat;
                Model.qraraadaNO = EditedEmp.qraraadaNO;
                Model.Notes = EditedEmp.Notes;
                Model.TameezNO = EditedEmp.TameezNO;
                Model.Decision1ImagePath = EditedEmp.Decision1ImagePath;
                Model.qraraadaNO = EditedEmp.qraraadaNO;
                Model.TashehNO = EditedEmp.TashehNO;



                _db.DawwaTable.Update(Model);
                await _db.SaveChangesAsync();
                return "The Recored has been edited succesfully";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}


