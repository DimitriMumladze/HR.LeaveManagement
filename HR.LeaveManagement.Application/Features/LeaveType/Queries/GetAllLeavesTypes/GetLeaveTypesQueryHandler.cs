using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeavesTypes;

public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        // Query
        var leaveTypes = await _leaveTypeRepository.GetAsync();

        // Convert data objs to DTO objs
        var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        // return list of DTO objs
        return data; 
    }
}
