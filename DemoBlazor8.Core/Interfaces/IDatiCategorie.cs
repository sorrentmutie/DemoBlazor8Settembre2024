using DemoBlazor8.Core.DTO;

namespace DemoBlazor8.Core.Interfaces;

public interface IDatiCategorie
{
    Task<IEnumerable<CategoriaDTO>?> EstraiCategorieAsync();
    Task IncreaseCounter();
    Task<int> GetCounter();
}
