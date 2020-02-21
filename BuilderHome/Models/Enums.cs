using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderHome.Models
{
    public enum Tipo
    {
        Escritorio,
        Laptop
    }
    public enum Ram
    {
        Ocho = 100,
        Doce = 200,
        Dieciseis = 400,
        treintaydos = 800,
        sesentacuatro = 1000
    }
    public enum Almacenamiento
    {
        doscientos = 200,
        quinientos = 500,
        mil = 600,
        dosmil = 800    
    }
    public enum Velocidad_Procesador
    {
        dos = 400,
        dospuntocinco = 415,
        dospuntoocho = 450,
        dospuntonueve = 500
    }
    public enum Tarjeta_Video
    {
        sesentacuatro = 600,
        cientoveinteocho = 700,
        doscincoseis = 1000,
        cincodoce = 1200,
    }
    public enum Monitor
    {
        veintecuatro = 300,
        veintecinco = 370,
        vientesiete = 400,
        treintados = 450
    }
    public enum Teclado
    {
        logitec = 120,
        corsair = 100,
        Rog = 150,
        Ctrl = 90,
        Razer = 200
    }
    public enum Mouse
    {
        Razer = 150,
        Logitec = 120,
        Corsair = 135,
        Rog = 140,
        Msi = 100,
        HP = 60
    }
}
