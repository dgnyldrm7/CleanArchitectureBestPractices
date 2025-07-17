namespace CleanArchitecture.Infrastructure.Caching
{
    public class CacheService : ICachService
    {
        private readonly IMemoryCache memoryCache;

        public bool Exists(Guid key)
        {
            return memoryCache.TryGetValue(key, out var value);
        }

        public T Get<T>(Guid key)
        {
            return memoryCache.TryGetValue(key, out var value) ? (T)value : default;
        }

        public void Remove(Guid key)
        {
            memoryCache.Remove(key);
        }

        public void Set<T>(Guid key, T value, TimeSpan expiration)
        {
            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expiration
            };

            memoryCache.Set(key, value, cacheOptions);
        }
    }
}
