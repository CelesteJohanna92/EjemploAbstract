namespace ExampleAPI1.EjemploClaseAbstracta
{
    public abstract class AnimalA
    {
        public string nombre { get; set; }

        public AnimalA() 
        { 
            
        }
        public abstract string Dormir();
        public string ObtenerHorasSueño()
        {
        return "El animal durmió 6 horas";
        }
    }
}

