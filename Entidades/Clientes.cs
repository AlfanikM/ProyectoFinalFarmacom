﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        [key]
        public int ClientesId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Telefono{get; set;}
        public string Celular { get; set; }
        public string Direccion { get; set; }
        

        public Clientes()
        {
            ClientesId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
            
        }

    }
}
