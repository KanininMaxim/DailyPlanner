

namespace DailyPlanner.Domain.Interfaces
{
    public interface IEntityId
    {
        public interface IEntityId<T> where T : struct
        {
            public T Id { get; set; }
        }
    }
}
