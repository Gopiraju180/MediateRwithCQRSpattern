using MediateRwithCQRSpattern.Commands;
using MediateRwithCQRSpattern.Interfaces;
using MediateRwithCQRSpattern.Models;
using MediatR;

namespace MediateRwithCQRSpattern.Handlers
{
    public class CreateStudentHandler:IRequestHandler<CreateStudentCommand,StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;
        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDetails>Handle(CreateStudentCommand command,CancellationToken cancellationToken)
        {
            var Studentdetails = new StudentDetails()
            {
                StudentName = command.StudentName,
                StudentAddress = command.StudentAddress,
                StudentEmail = command.StudentEmail,
                StudentAge = command.StudentAge,
            };
            return await _studentRepository.AddStudentAsync(Studentdetails);

        }
    }
}
