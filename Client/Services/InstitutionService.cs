using BaseLibrary.Entities;

namespace Client.Services
{
    public class InstitutionService : IInstitutionService
    {
        private readonly NewDbContext _dbContext;
        public InstitutionService(NewDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AddUpdate(Branch branch)
        {
            try
            {
                if (branch.Id == 0)
                    _dbContext.Branches.Add(branch);
                else
                    _dbContext.Branches.Update(branch);
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var branch = FindById(id);
                if (branch == null)
                    return false;
                _dbContext.Branches.Remove(branch);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Branch FindById(int id)
        {
            return _dbContext.Branches.Find(id);
        }

        public List<Branch> GetAll()
        {
            return _dbContext.Branches.ToList();

        }
    }
}
