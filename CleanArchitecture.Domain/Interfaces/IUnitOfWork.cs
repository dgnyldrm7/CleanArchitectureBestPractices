namespace CleanArchitecture.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Diğer repositoriyler için burada yazılması lazım!


        Task<int> SaveChangesAsync();
        void Rollback(); // Hata durumunda işlemleri geri al
    }
}