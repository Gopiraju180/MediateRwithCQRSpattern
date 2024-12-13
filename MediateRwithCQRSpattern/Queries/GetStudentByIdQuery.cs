using MediateRwithCQRSpattern.Models;
using MediatR;

namespace MediateRwithCQRSpattern.Queries
{
    public class GetStudentByIdQuery:IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
