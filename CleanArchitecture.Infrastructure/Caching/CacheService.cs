namespace CleanArchitecture.Infrastructure.Caching
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache? memoryCache;

        public CacheService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        public bool Exists(Guid key)
        {
            return memoryCache!.TryGetValue(key, out var value);
        }

        public T? Get<T>(Guid key)
        {
            if (memoryCache != null && memoryCache.TryGetValue(key, out var value))
            {
                return (T?)value;
            }

            return default;
        }


        public void Remove(Guid key)
        {
            memoryCache!.Remove(key);
        }

        public void Set<T>(Guid key, T value, TimeSpan expiration)
        {
            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expiration
            };

            memoryCache!.Set(key, value, cacheOptions);
        }
    }
}
