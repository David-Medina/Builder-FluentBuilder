using System;
using System.Collections.Generic;
using System.Text;
using BuilderHome.Models;

namespace BuilderHome.Builders
{
    public class Laptop :PCBuilder
    {
        public Laptop()
        {
            computadora = new Computadora();
        }
        public override void Tipo()
        {
            computadora.tipo = Models.Tipo.Laptop;
        }
        public override void Ram()
        {
            computadora.ram = Models.Ram.sesentacuatro;
        }
        public override void Almacenamiento()
        {
            computadora.almacenamiento = Models.Almacenamiento.quinientos;
        }
        public override void Velocidad_Procesador()
        {
            computadora.velocidad = Models.Velocidad_Procesador.dospuntocinco;
        }
        public override void Tarjeta_Video()
        {
            computadora.tarjeta = Models.Tarjeta_Video.doscincoseis;
        }
        //public override void Monitor()
        //{
        //    computadora.monitor = Models.Monitor.veintecuatro;
        //}
        //public override void Teclado()
        //{
        //    computadora.teclado = Models.Teclado.Ctrl;
        //}
        //public override void Mouse()
        //{
        //    computadora.mouse = Models.Mouse.Logitec;
        //}
    }
}
