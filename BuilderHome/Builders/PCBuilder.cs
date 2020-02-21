using System;
using System.Collections.Generic;
using System.Text;
using BuilderHome.Models;

namespace BuilderHome.Builders
{
    public abstract class PCBuilder
    {
        public Computadora computadora;
    
        public Computadora GetPC
        {
            get { return this.computadora; }
        }
        public virtual void Tipo()
        {

        }
        public virtual void Ram()
        {

        }
        public virtual void Almacenamiento()
        {

        }
        public virtual void Velocidad_Procesador()
        {

        }
        public virtual void Tarjeta_Video()
        {

        }
        public virtual void Monitor()
        {

        }
        public virtual void Teclado()
        {

        }
        public virtual void Mouse()
        {

        }
    }
}
