namespace CleanArchitecture.Domain.Interfaces.Common
{
    public interface ICacheService
    {
        T? Get<T>(Guid key);
        void Set<T>(Guid key, T value, TimeSpan expiration);
        void Remove(Guid key);
        bool Exists(Guid key);
    }
}