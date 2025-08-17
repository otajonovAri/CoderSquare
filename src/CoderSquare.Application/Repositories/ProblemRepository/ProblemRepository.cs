using CoderSquare.Application.Repositories.Repository;
using CoderSquare.DataAccess.Data;
using CoderSquare.Domain.Entities;

namespace CoderSquare.Application.Repositories.ProblemRepository;

public class ProblemRepository(AppDbContext context) 
: Repository<Problem>(context) , IProblemRepository
{
}