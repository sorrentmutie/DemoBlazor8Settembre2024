using DemoBlazor8.Core.DTO;
using DemoBlazor8.Core.Interfaces;

namespace DemoBlazor8.Business;

public class GestioneCategorie: IBusinessCategorie
{

    public List<CategoriaDTO> FiltraCategorie(List<CategoriaDTO> categorie) { 
         return categorie.Where(c => c.Nome?.Length > 10).ToList();
    }
}
