using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using MinistryOfWarerResources.BackEnd.Interfaces;
using MinistryOfWarerResources.Data;
using MinistryOfWarerResources.Models;
using MinistryOfWarerResources.ViewModels;


namespace MinistryOfWarerResources.BackEnd.Repositories
{
    public class JazaeaRepo :IJazaea
    {
        private readonly ApplicationDbContext _db;
        public JazaeaRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<string> AddNewJzaeaToTheSystem(JazaeaModule NewJzaea)
        {
            await _db.JazaeaTable.AddAsync(NewJzaea);
            await _db.SaveChangesAsync();
            return "تمت اضافة الدعوى الى النظام";
        }
        public async Task<bool> CheckIfDawaExistsInDB(string DawaNumber)
        {
            var CheckIfDawaExistsInDB = await _db.JazaeaTable.FirstOrDefaultAsync(a => a.DawaNumber == DawaNumber.Trim());

            if (CheckIfDawaExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<string> DeleteJzaea(int DawaId)
        {
            try
            {
                var DeletedJzaea = await _db.JazaeaTable.FirstOrDefaultAsync(a => a.Id == DawaId);
                _db.JazaeaTable.Remove(DeletedJzaea);
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
                var ListOfDeletedDawa = new List<JazaeaModule>();

                foreach (var item in ListOfDeletedDawas)
                {
                    var jazae = await _db.JazaeaTable.FirstOrDefaultAsync(a => a.Id == item);
                    ListOfDeletedDawa.Add(jazae);
                }
                _db.JazaeaTable.RemoveRange(ListOfDeletedDawa);
                await _db.SaveChangesAsync();
                return "تم الحذف بنجاح ";

            }
            catch (Exception Error)
            {

                return Error.Message;
            }
        }

        public Task<List<JazaeaModule>> GetAllDawas()
        {
            var ListOfDawas = _db.JazaeaTable.ToListAsync();
            return ListOfDawas;
        }
        public async Task<bool> Editjazaea(JazaeaModule EditedData, InputFileChangeEventArgs EditedPic)
        {
            if (EditedPic is null)
            {
                _db.JazaeaTable.Update(EditedData);
                await _db.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<JazaeaViewModel> GetJazaeaViewModelByUserId(int Id)
        {
            var Model = await _db.JazaeaTable.FirstOrDefaultAsync(a => a.Id == Id);

            var JazaeaViewModel = new JazaeaViewModel();
            JazaeaViewModel.Id = Model.Id;
            JazaeaViewModel.DawaNumber = Model.DawaNumber;
            JazaeaViewModel.SelectDawa = Model.SelectDawa;
            JazaeaViewModel.Court = Model.Court;
            JazaeaViewModel.Decision1Num = Model.Decision1Num;
            JazaeaViewModel.Decision1ImagePath = Model.Decision1ImagePath;
            JazaeaViewModel.TashehNO = Model.TashehNO;
            JazaeaViewModel.LastUpdate = Model.LastUpdate;
            JazaeaViewModel.Name1 = Model.Name1;
            JazaeaViewModel.Name2 = Model.Name2;
            JazaeaViewModel.DawaSubject = Model.DawaSubject;
            JazaeaViewModel.Office = Model.Office;
            JazaeaViewModel.Notes = Model.Notes;
            JazaeaViewModel.AkherALajraaat = Model.AkherALajraaat;
            JazaeaViewModel.AstanafNO = Model.AstanafNO;
            JazaeaViewModel.qraraadaNO = Model.qraraadaNO;
            JazaeaViewModel.TameezNO = Model.TameezNO;
            return JazaeaViewModel;

        //    static JazaeaViewModel NewMethod()
        //    {
        //        return JazaeaViewModel;
        //    }
        }
        public async Task<string> EditJazaeaViewModel(JazaeaViewModel EditedEmp)
        {
            try
            {
                var JazaeaModule = await _db.JazaeaTable.FirstOrDefaultAsync(a => a.Id == EditedEmp.Id);
                JazaeaModule.DawaNumber = EditedEmp.DawaNumber;
                JazaeaModule.Court = EditedEmp.Court;
                JazaeaModule.SelectDawa = EditedEmp.SelectDawa;
                JazaeaModule.Decision1Num = EditedEmp.Decision1Num;
                JazaeaModule.TashehNO = EditedEmp.TashehNO;
                JazaeaModule.LastUpdate = EditedEmp.LastUpdate;
                JazaeaModule.Name1 = EditedEmp.Name1;
                JazaeaModule.Name2 = EditedEmp.Name2;
                JazaeaModule.DawaSubject = EditedEmp.DawaSubject;
                JazaeaModule.Office = EditedEmp.Office;
                JazaeaModule.Notes = EditedEmp.Notes;
                JazaeaModule.AkherALajraaat = EditedEmp.AkherALajraaat;
                JazaeaModule.AstanafNO = EditedEmp.AstanafNO;
                JazaeaModule.Decision1ImagePath = EditedEmp.Decision1ImagePath;
                JazaeaModule.AstanafNO = EditedEmp.AstanafNO;
                JazaeaModule.qraraadaNO = EditedEmp.qraraadaNO;
                JazaeaModule.TameezNO = EditedEmp.TameezNO;



                _db.JazaeaTable.Update(JazaeaModule);
                await _db.SaveChangesAsync();
                return "The Recored has been edited succesfully";

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }

        public async Task<string> DeleteDawa(int DawaId)
        {
            try
            {
                var DeletedDawa = await _db.JazaeaTable.FirstOrDefaultAsync(a => a.Id == DawaId);
                _db.JazaeaTable.Remove(DeletedDawa);
                await _db.SaveChangesAsync();
                return $"{DawaId} deleted Successfully";
            }
            catch (Exception Error)
            {

                return Error.Message;
            }

        }
    }
    }

