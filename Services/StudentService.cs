using StudentAPI.Models;
using StudentAPI.Repositories;

namespace StudentAPI.Services
{ 
        public class StudentService : IStudentService
        {
            private readonly IStudentRepository _studentRepository;

            public StudentService(IStudentRepository repository)
            {
                this._studentRepository = repository;
            }

            public async Task<List<Student>> GetAll()
            {
                return await _studentRepository.GetAll();
            }

            public async Task<Student>GetStudentById(int id)
           {
            return await
                _studentRepository.GetStudentById(id);
           }

            public async Task Add(Student student)
            {
                student.CreatedDate = DateTime.Now;
                await _studentRepository.Add(student);
            }

            public async Task Update(Student student)
            {
                await _studentRepository.Update(student);
            }

            public async Task Delete(int id)
            {
                var student = await _studentRepository.GetStudentById(id);

                if (student == null)
                    throw new Exception("Student not found");

                await _studentRepository.Delete(student);
            }
        }
    }

