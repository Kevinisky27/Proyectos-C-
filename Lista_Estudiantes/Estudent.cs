using System;

namespace Lista_Estudiantes
{
  public class Estudent 
  {
    public string nombre;

    public int edad;

    public string carnet;

    public bool solvente;

    public int nota1;

    public int nota2;

    public int nota3;

    public Estudent (string nombre, int edad, string carnet, bool solvente, int nota1, int nota2, int nota3)
    {
      this.nombre = nombre;
      this.edad = edad;
      this.carnet = carnet;
      this.solvente = solvente;
      this.nota1 = nota1;
      this.nota2 = nota2;
      this.nota3 = nota3;
    } 
  }
}