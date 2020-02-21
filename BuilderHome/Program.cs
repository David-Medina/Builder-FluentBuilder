using System;
using System.Collections.Generic;
using BuilderHome.Builders;
using BuilderHome.Director;
using BuilderHome.Models;

namespace BuilderHome
{
    class Program
    {
        static void Main(string[] args)
        {
            //var computadora = new Computadora(Tipo.Escritorio, Ram.Ocho, Almacenamiento.doscientos, Velocidad_Procesador.dospuntonueve, Tarjeta_Video.cincodoce, Monitor.veintecinco, Teclado.Ctrl, Mouse.Logitec);
            //Console.WriteLine(computadora.ToString());
            //Console.WriteLine(computadora.GetPrice(computadora));   

            //var builder = new PC();
            //builder.Tipo();
            //builder.Ram();
            //builder.Almacenamiento();
            //builder.Velocidad_Procesador();
            //builder.Tarjeta_Video();
            //builder.Monitor();
            //builder.Teclado();
            //builder.Mouse();
            //Console.WriteLine(builder.GetPC.ToString());
            //Console.WriteLine(builder.GetPC.GetPrice(builder));
            //var ensamble = new Ensamblador(new PC());
            //Console.WriteLine(ensamble.GetPC().ToString());

            //var ensamble = new Ensamblador(new PC());
            //Console.WriteLine(ensamble.GetPC().ToString());

            //var Fluent_ensamble = PCFluentBuilder.Crear().Almacenamiento_1000().Monitor_25().Mouse_Corsair().Ram_32GB().Tipo_Escritorio().Tarjeta_256().Teclado_Ctrl().Velocidad_2_8hz().Ensamblar();
            //Console.WriteLine($"Fluent \n {Fluent_ensamble.ToString()}");

        }
    }
}
