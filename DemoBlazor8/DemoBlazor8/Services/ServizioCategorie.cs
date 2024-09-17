namespace DemoBlazor8.Services;

public class ServizioCategorie : IDatiCategorie
{
    private readonly NorthwindContext northwindContext;
    private readonly IBusinessCategorie businessCategorie;
    private int counter = 0;

    public ServizioCategorie(NorthwindContext northwindContext, IBusinessCategorie businessCategorie)
    {
        this.northwindContext = northwindContext;
        this.businessCategorie = businessCategorie;
    }


    public async Task<IEnumerable<CategoriaDTO>?> EstraiCategorieAsync()
    {
        var categorie =  await northwindContext.Categories
            .Select(c => new CategoriaDTO
            {
                Id = c.CategoryId,
                Nome = c.CategoryName,
                Descrizione = c.Description
            }).ToListAsync();
        return businessCategorie.FiltraCategorie(categorie);
    }

    public async Task<int> GetCounter()
    {
        await Task.Delay(10);
        return counter;
    }

    public async Task IncreaseCounter()
    {
        await Task.Delay(10);
        counter++;
    }
}
