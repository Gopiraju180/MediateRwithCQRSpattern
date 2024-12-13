using MediateRwithCQRSpattern.Interfaces;
using MediateRwithCQRSpattern.Models;
using MediateRwithCQRSpattern.Queries;
using MediatR;

namespace MediateRwithCQRSpattern.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
