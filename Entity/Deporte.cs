using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Deporte
    {
        private int idTipoDeporte;
        private string descripcion;

        public int IdTipoDeporte { get => idTipoDeporte; set => idTipoDeporte = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
