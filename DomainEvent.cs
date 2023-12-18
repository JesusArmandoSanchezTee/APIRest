using System;

public record DomainEvent
{
	public DomainEvent(Guid Id) : INotification
	{

	}
}
