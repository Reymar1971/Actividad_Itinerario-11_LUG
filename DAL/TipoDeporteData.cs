using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Entity;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Mapper;

namespace DAL
{
    public class TipoDeporteData
    {
        public List<Deporte> getAll()
        {
            try
            {
                List<Deporte> tipoDeporte = new List<Deporte>();
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    string query = "Select ID_DEPORTE, DESCRIPCION FROM Deporte";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                              tipoDeporte.Add(DeporteMapper.Map(reader));
                            }
                        }
                    }
                }
                return tipoDeporte;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public Deporte getById(int IdTipoDeporte)
        {
            try
            {
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    string query = "Select ID_DEPORTE, DESCRIPCION FROM Deporte WHERE ID_DEPORTE=@ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", IdTipoDeporte);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return DeporteMapper.Map(reader);

                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
