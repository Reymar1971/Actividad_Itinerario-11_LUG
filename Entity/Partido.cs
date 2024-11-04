﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Partido
    {

        private int idPartido;
        private string equipoLocal;
        private string equipoVisitante;
        private DateTime fecharegistro;
        private DateTime fechaPartido;
        private int marcadorLocal;
        private int marcadorVisitante;
        private Deporte deporte;

        public int IdPartido { get => idPartido; set => idPartido = value; }
        public string EquipoLocal { get => equipoLocal; set => equipoLocal = value; }
        public string EquipoVisitante { get => equipoVisitante; set => equipoVisitante = value; }
        public DateTime Fecharegistro { get => fecharegistro; set => fecharegistro = value; }
        public DateTime FechaPartido { get => fechaPartido; set => fechaPartido = value; }
        public int MarcadorLocal { get => marcadorLocal; set => marcadorLocal = value; }
        public int MarcadorVisitante { get => marcadorVisitante; set => marcadorVisitante = value; }
        public Deporte Deporte { get => deporte; set => deporte = value; }
    }
}
