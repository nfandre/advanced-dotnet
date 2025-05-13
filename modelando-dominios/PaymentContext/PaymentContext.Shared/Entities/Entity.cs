
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public abstract class Entity : Notifiable<Notification>
{
    protected Entity()
    {
        Id = new Guid();
    }

    public Guid Id { get; private set; }
}