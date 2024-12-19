using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Interfaces
{
    // Declaracion o matricula de nuestras interfaces a nivel de repositorio

    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        void SaveChanges();

        Task SaveChangesAsync();





    }
}
