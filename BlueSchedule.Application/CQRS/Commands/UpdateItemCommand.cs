﻿using MediatR;

namespace BlueSchedule.Application.CQRS.Commands
{
    public class UpdateItemCommand : IRequest<int>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
    }
}