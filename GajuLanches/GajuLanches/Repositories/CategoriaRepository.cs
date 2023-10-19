using GajuLanches.Context;
using GajuLanches.Models;
using GajuLanches.Repositories.Interfaces;

namespace GajuLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;


        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
