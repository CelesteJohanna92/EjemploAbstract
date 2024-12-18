namespace ExampleAPI1.EjemploDeInterfaz
{
    public interface IAnimal
    {
        public string Comer();
        public string Jugar();

        public string ObtenerHorasSueño()
        {   
        return "El animal durmió 6 horas";
        }
    } 
}


