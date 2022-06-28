using POO;

class Program
{
    static void Main()
    {
        var alumno = new Alumno();
        alumno.Direcciones.Add("");
    }

    
    
    
    public static void ProcesarRepositorio(IRepositorioPersonas repositorio)
    {
        repositorio.ObtenerPersonas();
    }

    public static IRepositorioPersonas ObtenerRepositorio(TipoRepositorio tipoRepositorio)
    {
        switch (tipoRepositorio)
        {
            case TipoRepositorio.BD:
                return new RepositorioPersonasBD();
            case TipoRepositorio.Memoria:
                return new RepositorioPersonasMemoria();
            default:
                throw new NotImplementedException();
        }
    }

    public enum TipoRepositorio
    {
        BD = 1,
        Memoria = 2,
    }
}