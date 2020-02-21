using System;
using System.Collections.Generic;
using System.Text;
using BuilderHome.Models;

namespace BuilderHome.Builders
{
    class PCFluentBuilder
    {
        private Computadora Computadora;

        private PCFluentBuilder()
        {
            Computadora = new Computadora();           
        }
        public static PCFluentBuilder Crear()
        {
            return new PCFluentBuilder();
        }
        public PCFluentBuilder Tipo_Escritorio()
        {
            Computadora.tipo = Tipo.Escritorio;
            return this;
        }
        public PCFluentBuilder Tipo_Laptop()
        {
            Computadora.tipo = Tipo.Laptop;
            return this;
        }
        public PCFluentBuilder Ram_8GB()
        {
            Computadora.ram = Ram.Ocho;
            return this;
        }
        public PCFluentBuilder Ram_12GB()
        {
            Computadora.ram = Ram.Doce;
            return this;
        }
        public PCFluentBuilder Ram_16GB()
        {
            Computadora.ram = Ram.Dieciseis;
            return this;
        }
        public PCFluentBuilder Ram_32GB()
        {
            Computadora.ram = Ram.treintaydos;
            return this;
        }
        public PCFluentBuilder Ram_64GB()
        {
            Computadora.ram = Ram.sesentacuatro;
            return this;
        }
        public PCFluentBuilder Almacenamiento_200()
        {
            Computadora.almacenamiento = Almacenamiento.doscientos;
            return this;
        }
        public PCFluentBuilder Almacenamiento_500()
        {
            Computadora.almacenamiento = Almacenamiento.quinientos;
            return this;
        }
        public PCFluentBuilder Almacenamiento_1000()
        {
            Computadora.almacenamiento = Almacenamiento.mil;
            return this;
        }
        public PCFluentBuilder Almacenamiento_2000()
        {
            Computadora.almacenamiento = Almacenamiento.dosmil;
            return this;
        }
        public PCFluentBuilder Velocidad_2hz()
        {
            Computadora.velocidad = Velocidad_Procesador.dos;
            return this;
        }
        public PCFluentBuilder Velocidad_2_5hz()
        {
            Computadora.velocidad = Velocidad_Procesador.dospuntocinco;
            return this;
        }
        public PCFluentBuilder Velocidad_2_8hz()
        {
            Computadora.velocidad = Velocidad_Procesador.dospuntoocho;
            return this;
        }
        public PCFluentBuilder Velocidad_2_9hz()
        {
            Computadora.velocidad = Velocidad_Procesador.dospuntonueve;
            return this;
        }
        public PCFluentBuilder Tarjeta_64()
        {
            Computadora.tarjeta = Tarjeta_Video.sesentacuatro;
            return this;
        }
        public PCFluentBuilder Tarjeta_128()
        {
            Computadora.tarjeta = Tarjeta_Video.cientoveinteocho;
            return this;
        }
        public PCFluentBuilder Tarjeta_256()
        {
            Computadora.tarjeta = Tarjeta_Video.doscincoseis;
            return this;
        }
        public PCFluentBuilder Tarjeta_512()
        {
            Computadora.tarjeta = Tarjeta_Video.cincodoce;
            return this;
        }
        public PCFluentBuilder Monitor_24()
        {
            Computadora.monitor = Monitor.veintecuatro;
            return this;
        }
        public PCFluentBuilder Monitor_25()
        {
            Computadora.monitor = Monitor.veintecinco;
            return this;
        }
        public PCFluentBuilder Monitor_27()
        {
            Computadora.monitor = Monitor.vientesiete;
            return this;
        }
        public PCFluentBuilder Monitor_32()
        {
            Computadora.monitor = Monitor.treintados;
            return this;
        }
        public PCFluentBuilder Teclado_Logitec()
        {
            Computadora.teclado = Teclado.logitec;
            return this;
        }
        public PCFluentBuilder Teclado_Corsair()
        {
            Computadora.teclado = Teclado.corsair;
            return this;
        }
        public PCFluentBuilder Teclado_ROG()
        {
            Computadora.teclado = Teclado.Rog;
            return this;
        }
        public PCFluentBuilder Teclado_Ctrl()
        {
            Computadora.teclado = Teclado.Ctrl;
            return this;
        }
        public PCFluentBuilder Teclado_Razer()
        {
            Computadora.teclado = Teclado.Razer;
            return this;
        }
        public PCFluentBuilder Mouse_Razer()
        {
            Computadora.mouse = Mouse.Razer;
            return this;
        }
        public PCFluentBuilder Mouse_Logitec()
        {
            Computadora.mouse = Mouse.Logitec;
            return this;
        }
        public PCFluentBuilder Mouse_Corsair()
        {
            Computadora.mouse = Mouse.Corsair;
            return this;
        }
        public PCFluentBuilder Mouse_ROG()
        {
            Computadora.mouse = Mouse.Rog;
            return this;
        }
        public PCFluentBuilder Mouse_MSI()
        {
            Computadora.mouse = Mouse.Msi;
            return this;
        }
        public PCFluentBuilder Mouse_HP()
        {
            Computadora.mouse = Mouse.HP;
            return this;
        }
        public Computadora Ensamblar()
        {
            return this.Computadora;
        }

    }
}
