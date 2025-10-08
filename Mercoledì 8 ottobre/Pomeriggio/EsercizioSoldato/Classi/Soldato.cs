﻿namespace EsercizioSoldato.Classi;

public class Soldato : Esercito
{
    private string nome;
    private string grado;
    private int anniServizio;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Grado
    {
        get { return grado; }
        set { grado = value; }
    }

    public int AnniServizio
    {
        get { return anniServizio; }
        set
        {
            if (value >= 0)
                anniServizio = value;
        }
    }

    public Soldato(string nazione, string nome, string grado, int anniServizio)
        : base(nazione)
    {
        Nome = nome;
        Grado = grado;
        AnniServizio = anniServizio;
    }

    public override string ToString()
    {
        return
            $"Nome soldato: {Nome}\n" +
            $"Grado: {Grado}\n" +
            $"Anni di servizio: {AnniServizio}\n";
    }
}
