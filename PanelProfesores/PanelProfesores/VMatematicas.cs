﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class VMatematicas : VCalificacionFinal
    {
        public override void Aceptar(Visitor visitor)
        {
            visitor.CalcularMateCal(this);
        }
    }
}
