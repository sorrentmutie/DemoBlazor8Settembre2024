using DemoBlazor8.Core.DTO;
using DemoBlazor8.Core.Interfaces;

namespace DemoBlazor8.Client.Services;

public class ServizioCategorieWASM : IDatiCategorie
{
    private int counter = 10;
    public ServizioCategorieWASM()
    {
        
    }

    public async Task<IEnumerable<CategoriaDTO>?> EstraiCategorieAsync()
    {
        return new List<CategoriaDTO> { new CategoriaDTO { Id= 1, Nome = "Cat1", Descrizione="Bla Bla" } };
    }

    public async Task<int> GetCounter()
    {
        await Task.Delay(10);
        return counter;
    }

    public async Task IncreaseCounter()
    {
        await Task.Delay(10);
        counter += 10;
    }
}
