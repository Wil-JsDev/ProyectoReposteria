using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Recetas
    {
        #region Propiedades
        public List<Ingredientes> listaIngredientes = new List<Ingredientes>();
        public string Nombre { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        #endregion

        #region Metodos
        public void AgregarIngredientes(Ingredientes ingredientes)
        {
            listaIngredientes.Add(ingredientes);
        }
        public List<Ingredientes> getIngredientes()
        {
            return listaIngredientes;
        }

        public void BorrarIngredientes (Ingredientes ingredientes)
        {
            listaIngredientes.Remove(ingredientes);
        }
        #endregion
    }
}
