using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Productos : Recetas
    {
        #region Propiedades
        public string NombreProducto { get; set; } = null!;
        public string Descripcion { get; set;} = null!;
        public string CategoriaProducto { get; set; } = null!;
        public int Cantidad { get; set; }
        #endregion

        #region Metodos 
        public void AgregarAlCarrito(Productos productos)
        {

        }

        public List<Ingredientes> VerRecetas(Ingredientes ingredientes)
        {
            return listaIngredientes;
        }
        #endregion
    }
}
