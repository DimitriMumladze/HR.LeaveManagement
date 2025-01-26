using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesTypes;


public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
