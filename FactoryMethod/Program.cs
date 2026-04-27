using FactoryMethodN;

class Program   //programa principal 
{
    static void Main(string[] args)
    {
        EnvioCreator envioCorreo = new EnvioCorreoCreator();
        envioCorreo.ProcesarEnvio();

        EnvioCreator envioMoto = new EnvioMotoCreator();
        envioMoto.ProcesarEnvio();

        EnvioCreator envioCamion = new EnvioCamionCreator();
        envioCamion.ProcesarEnvio();

        EnvioCreator envioAvion = new EnvioAvionCreator();
        envioAvion.ProcesarEnvio();

        EnvioCreator envioDigital = new EnvioComputadorCreator();
        envioDigital.ProcesarEnvio();

    }
}
