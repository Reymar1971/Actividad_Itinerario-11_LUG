using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Mapper;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace DAL
{
    public class PartidoData
    {
        private TipoDeporteData deporteData = new TipoDeporteData();

        public List<Partido> getAll()
        {
            try
            {
                List<Partido> listaPartidos = new List<Partido>();
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT ID_PARTIDO, ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE FROM Partido";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Deporte deporte = deporteData.getById(Convert.ToInt32(reader["ID_DEPORTE"].ToString()));
                                Partido partido = PartidoMapper.Map(reader, deporte);
                                listaPartidos.Add(partido);

                            }
                        }
                    }
                }
                return listaPartidos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void guardarPartido(Partido partido)
        {
            SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());

            try
            {
                using (conn)
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Partido(ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE) VALUES(@IdDeporte, @EquipoLocal, @EquipoVisitante, @FechaRegistro, @FechaPartido, @MarcadorLocal, @MarcadorVisitante)";
                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@IdDeporte", partido.Deporte.IdTipoDeporte);
                        command.Parameters.AddWithValue("@EquipoLocal", partido.EquipoLocal);
                        command.Parameters.AddWithValue("@EquipoVisitante", partido.EquipoVisitante);
                        command.Parameters.AddWithValue("@FechaRegistro", partido.Fecharegistro);
                        command.Parameters.AddWithValue("@FechaPartido", partido.FechaPartido);
                        command.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                        command.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);
                        command.ExecuteNonQuery();
                    }
                }

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
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    string query = "DELETE FROM Partido WHERE ID_PARTIDO = @partido";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@partido", idPartido);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        

        public void modificarMarcador(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    string query = "UPDATE Partido SET MARCADOR_LOCAL = @marcadorLocal, MARCADOR_VISITANTE = @marcadorVisitante WHERE ID_PARTIDO = @partido"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@partido", idPartido);
                        cmd.Parameters.AddWithValue("@marcadorLocal", marcadorLocal);
                        cmd.Parameters.AddWithValue("@marcadorVisitante", marcadorVisitante);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool buscarPartido(int idPartido)
        {
            DateTime fechaActual = DateTime.Now.Date;
            bool existe = false;
            string query = "SELECT FECHA_PARTIDO FROM Partido WHERE ID_PARTIDO = @idPartido";

            try
            {
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@idPartido", idPartido);
                        
                        var resultado=command.ExecuteScalar();
                        if(resultado != null)
                        {
                            existe = Convert.ToDateTime(resultado) == fechaActual;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return existe;
        }
    }
}
