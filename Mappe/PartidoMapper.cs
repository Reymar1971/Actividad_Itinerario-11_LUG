using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Mapper
{
    public class PartidoMapper
    {

        public static Partido Map(SqlDataReader reader, Deporte deporte)
        {
            Partido partido = new Partido()
            {
                IdPartido = Convert.ToInt32(reader["ID_PARTIDO"].ToString()),
                EquipoLocal = reader["EQUIPO_LOCAL"].ToString(),
                EquipoVisitante = reader["EQUIPO_VISITANTE"].ToString(),
                Fecharegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"].ToString()),
                FechaPartido = Convert.ToDateTime(reader["FECHA_PARTIDO"].ToString()),
                MarcadorLocal = Convert.ToInt32(reader["MARCADOR_LOCAL"].ToString()),
                MarcadorVisitante = Convert.ToInt32(reader["MARCADOR_VISITANTE"].ToString()),
                Deporte = deporte

            };
            return partido;
        }

    }
}
