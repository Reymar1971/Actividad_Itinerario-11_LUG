using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using Microsoft.IdentityModel.Tokens;
using System.Transactions;

namespace BLL
{
    public class PartidoBusiness
    {
        private PartidoData partidoData = new PartidoData();

        private bool modificaPartido;

        public List<Partido> getPartidoList()
        {
            try
            {
                return partidoData.getAll();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void eliminarPartido(int idPartido)
        {
            try
            {
                partidoData.eliminarPartido(idPartido);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void guardarPartido(Partido partido)
        {
            using (var trx= new TransactionScope())
            try
            {   // Valido el nombre del equipo que sea mayor de 5 caracteres
                if (partido.EquipoLocal.Length < 5)
                {
                    throw new Exception("Nombre de Equipo incorrecto");
                }
                // Valido el nombre del equipo que sea mayor de 5 caracteres
                if (partido.EquipoVisitante.Length < 5)
                {
                    throw new Exception("Nombre de Equipo incorrecto");
                }
                // Valido que la fecha de Partido no sea menor que la fecha actual
                if (partido.FechaPartido < DateTime.Now)
                {
                    throw new Exception("La fecha del partido no puede ser menor a la fecha actual");

                }
                // Valido que el tipo de Deporte no este vacio
                if (partido.Deporte.IdTipoDeporte == 0)
                {
                    throw new Exception("El tipo de Deporte no puede estar vacio");
                }
                partido.Fecharegistro = DateTime.Now;
                partido.MarcadorLocal = 0;
                partido.MarcadorVisitante = 0;

                partidoData.guardarPartido(partido);
                trx.Complete();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void ConfirmarPartidos(List<Partido> partidos)
        {
            try
            {
                using (var trx= new TransactionScope())
                {
                    foreach (Partido partido in partidos)
                    {
                        guardarPartido(partido);
                    }
                    trx.Complete();
                }

            }
            catch (Exception x)
            {

                throw;
            }
        }

        public void modificaMarcador(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            try
            {
                // Verifico para poder o nodificar los marcadores del partido
                modificaPartido = partidoData.buscarPartido(idPartido);

                if (modificaPartido)
                {
                    partidoData.modificarMarcador(idPartido, marcadorLocal, marcadorVisitante);
                    
                }
                else
                {
                    throw new Exception("La fecha del partido no puede ser distinta que la actual; Verifique !!!");
                }
                                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        
    }
}
