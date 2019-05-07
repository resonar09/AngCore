using System.Threading.Tasks;
using AngCore.API.Data;

namespace AngCore.API.Services
{
    public interface ISeedDataService
    {
        Task Initialize(DataContext context);
    }
}
