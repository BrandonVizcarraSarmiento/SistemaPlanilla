﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set;}
        public string Clave { get; set;}
        public Rol oRol { get; set;}
        public bool Estado { get; set;}
    }
}
