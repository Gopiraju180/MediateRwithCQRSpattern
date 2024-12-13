using MediateRwithCQRSpattern.Models;
using MediatR;

namespace MediateRwithCQRSpattern.Queries
{
    public class GetStudentListQuery:IRequest<List<StudentDetails>>
    {
    }
}
