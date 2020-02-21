using System;
using System.Collections.Generic;
using System.Text;
using BuilderHome.Builders;
using BuilderHome.Models;

namespace BuilderHome.Director
{
    public class Ensamblador
    {
        private PCBuilder pCBuilder;
        public Ensamblador(PCBuilder pCBuilder)
        {
            this.pCBuilder = pCBuilder;
        }
        public Computadora GetPC()
        {
            pCBuilder.Tipo();
            pCBuilder.Ram();
            pCBuilder.Almacenamiento();
            pCBuilder.Velocidad_Procesador();
            pCBuilder.Tarjeta_Video();
            pCBuilder.Monitor();
            pCBuilder.Teclado();
            pCBuilder.Mouse();
            return pCBuilder.GetPC;
        }
    }
}
