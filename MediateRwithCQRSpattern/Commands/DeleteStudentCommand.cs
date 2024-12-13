using MediatR;

namespace MediateRwithCQRSpattern.Commands
{
    public class DeleteStudentCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
