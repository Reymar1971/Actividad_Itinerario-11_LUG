using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class TipoDeporteBusiness
    {
        private TipoDeporteData tipoDeporteData = new TipoDeporteData();

        public List<Deporte> getAll()
        {
            try
            {
                return tipoDeporteData.getAll();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
