﻿using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request
{
   public  class GetLeaveTypeRequest:IRequest<LeaveTypeDto>
    {
    }
}
