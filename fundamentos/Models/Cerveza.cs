﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    internal class Cerveza:Bebida
    {
        //el ctor es un metodo
        public Cerveza(int Cantidad, string Nombre="Cervezas"):base(Nombre, Cantidad)
        {

        }

    }
}
