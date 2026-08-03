
using StudentAPI.Models;
namespace StudentAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> GetStudentById(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(Student student);
    }
}
