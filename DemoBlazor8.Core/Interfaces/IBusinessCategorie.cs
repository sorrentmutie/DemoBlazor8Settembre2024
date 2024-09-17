using DemoBlazor8.Core.DTO;

namespace DemoBlazor8.Core.Interfaces;

public  interface IBusinessCategorie
{
    List<CategoriaDTO> FiltraCategorie(List<CategoriaDTO> categorie);
}
