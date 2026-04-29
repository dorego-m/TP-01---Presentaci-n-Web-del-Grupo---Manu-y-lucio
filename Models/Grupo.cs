
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
            50155748,
            "Manu",
            new DateTime(2010, 2, 26),
            "Manu.png",
            new List<string> { "Papá: Carlos", "Mamá: Ana" },
            new List<string> { "Videojuegos", "Series" }
        );

        Integrante i2 = new Integrante(
            49701561,
            "Lucio",
            new DateTime(2009, 7, 28),
            "Lucio.png",
            new List<string> { "Papá: Luis", "Mamá: Marta" },
            new List<string> { "Deportes", "Peliculas" }
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