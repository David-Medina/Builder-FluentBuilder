using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderHome.Models
{
    public class Computadora
    {
        public Tipo tipo { set; get; }
        public Ram ram { set; get; }
        public Almacenamiento almacenamiento { set; get; }
        public Velocidad_Procesador velocidad { set; get; }
        public Tarjeta_Video tarjeta { set; get; }
        public Monitor monitor { set; get; }
        public Teclado teclado { set; get; }
        public Mouse mouse { set; get; }

        public Computadora()
        {
            
        }
        public Computadora(Tipo tipo,Ram ram,Almacenamiento almacenamiento,Velocidad_Procesador velocidad,Tarjeta_Video tarjeta,Monitor monitor,Teclado teclado,Mouse mouse)
        {
            this.tipo = tipo;
            this.ram = ram;
            this.almacenamiento = almacenamiento;
            this.velocidad = velocidad;
            this.tarjeta = tarjeta;
            this.monitor = monitor;
            this.teclado = teclado;
            this.mouse = mouse;
        }
        public string GetPrice(Computadora computadora)
        {
            var _ram = computadora.ram.GetHashCode();
            var _al = computadora.almacenamiento.GetHashCode();
            var _vel = computadora.velocidad.GetHashCode();
            var _Ta = computadora.tarjeta.GetHashCode();
            var _Mon = computadora.monitor.GetHashCode();
            var _tec = computadora.teclado.GetHashCode();
            var _Mou = computadora.teclado.GetHashCode();
            int Total = _ram + _al + _vel + _Ta + _Mon + _tec + _Mou;
            return $"El Precio Total es: ${Total}";
        }

        public override string ToString()
        {
            return $"Tipo: {this.tipo}, Ram: {this.ram}, Almacenamiento: {this.almacenamiento}, Velocidad: {this.velocidad}, Tarjeta: {this.tarjeta}, Monitor: {this.monitor}, Teclado: {this.teclado}, Mouse: {this.mouse}";
        }
      
    }
}
