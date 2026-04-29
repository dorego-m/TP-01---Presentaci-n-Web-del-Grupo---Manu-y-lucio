using System;
using System.Collections.Generic;

public class Integrante
{
    public int DNI;
    public string Nombre;
    public DateTime FechaNacimiento;
    public string Foto;
    public List<string> Familiares;
    public List<string> Intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto,List<string> familiares, List<string> intereses)
    {
        DNI = dni;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Foto = foto;
        Familiares = familiares;
        Intereses = intereses;
    }

     public string ObtenerNombre() 
    {
        return Nombre;
    }

    public string ObtenerFoto() 
    {
        return Foto;
    }
}