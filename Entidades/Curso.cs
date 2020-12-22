using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposEscuela Jornada { get; set; }

        public Curso() =>  UniqueId = Guid.NewGuid().ToString();
        // esto es un constructor para la clase curso que genera un id diferente para cada curso solo que con le tostring lo cambio a string si quisiera solo el numero quitaria el tostring
    }
}