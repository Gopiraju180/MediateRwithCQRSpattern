using MediateRwithCQRSpattern.ContextConnection;
using MediateRwithCQRSpattern.Interfaces;
using MediateRwithCQRSpattern.Models;
using Microsoft.EntityFrameworkCore;

namespace MediateRwithCQRSpattern.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentMediatrCqrsContext _dbContext;
        public StudentRepository(StudentMediatrCqrsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
        {
            var result = _dbContext.students.Add(studentDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var filteredData = _dbContext.students.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.students.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<StudentDetails> GetStudentByIdAsync(int Id)
        {
            return await _dbContext.students.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<StudentDetails>> GetStudentListAsync()
        {
            return await _dbContext.students.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            _dbContext.students.Update(studentDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
