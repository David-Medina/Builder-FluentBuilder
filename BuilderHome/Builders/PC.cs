using System;
using System.Collections.Generic;
using System.Text;
using BuilderHome.Models;

namespace BuilderHome.Builders
{
    public class PC : PCBuilder
    {
        public PC()
        {
            computadora = new Computadora();
        }
        public override void Tipo()
        {
            computadora.tipo = Models.Tipo.Escritorio;
        }
        public override void Ram()
        {
            computadora.ram = Models.Ram.Dieciseis;
        }
        public override void Almacenamiento()
        {
            computadora.almacenamiento = Models.Almacenamiento.doscientos;
        }
        public override void Velocidad_Procesador()
        {
            computadora.velocidad = Models.Velocidad_Procesador.dospuntonueve;
        }
        public override void Tarjeta_Video()
        {
            computadora.tarjeta = Models.Tarjeta_Video.cincodoce;
        }
        public override void Monitor()
        {
            computadora.monitor = Models.Monitor.veintecinco;
        }
        public override void Teclado()
        {
            computadora.teclado = Models.Teclado.Ctrl;
        }
        public override void Mouse()
        {
            computadora.mouse = Models.Mouse.Logitec;
        }
    }
}
