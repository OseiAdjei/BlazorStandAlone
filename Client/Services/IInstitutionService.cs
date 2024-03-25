using BaseLibrary.Entities;

namespace Client.Services
{
    public interface IInstitutionService
    {
        bool AddUpdate(Branch branch);
        bool Delete (int id);
        Branch  FindById(int id);   
        List<Branch> GetAll();
    }
}
