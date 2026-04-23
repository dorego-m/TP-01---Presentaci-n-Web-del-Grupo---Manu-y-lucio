
using System;
using System.Collections.Generic;

public class Grupo
{
    public Dictionary<int, Integrante> Integrantes;

    public Grupo()
    {
        Integrantes = new Dictionary<int, Integrante>();
        CargarDatos();
    }

    public void CargarDatos()
    {
        Integrante i1 = new Integrante(
            111,
            "Juan",
            new DateTime(2000, 1, 1),
            "juan.jpg",
            new List<string> { "Papá: Carlos", "Mamá: Ana" },
            new List<string> { "Fútbol", "Series" }
        );

        Integrante i2 = new Integrante(
            222,
            "Camila",
            new DateTime(2001, 2, 2),
            "camila.jpg",
            new List<string> { "Papá: Luis", "Mamá: Marta" },
            new List<string> { "Leer", "Peliculas" }
        );

        Integrantes.Add(i1.DNI, i1);
        Integrantes.Add(i2.DNI, i2);
    }

    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return Integrantes;
    }

    public Integrante GetIntegrante(int dni)
    {
        if (Integrantes.ContainsKey(dni))
        {
            return Integrantes[dni];
        }
        else
        {
            return null;
        }
    }
}