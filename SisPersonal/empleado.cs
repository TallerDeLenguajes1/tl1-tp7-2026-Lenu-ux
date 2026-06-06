namespace EspacioSistema;
enum Cargos
{
    auxiliar=1,
    administrativo=2,
    especialista=3,
    ingeniero=4,
    directivo=5

}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estCivil;
    private DateTime fIngreso;
    private double sueldoBasico;
    private Cargos cargos;
    
    //Propiedades
    public string Nombre {get => nombre; set=>nombre=value;}
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public DateTime FIngreso { get => fIngreso; set => fIngreso = value; }
}