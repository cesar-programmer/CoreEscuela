namespace CoreEscuela.Entidades
// el espacio de nombres nos sirve para agrupar objetos y encontrarlos mas rapido
{
    class Escuela
    {
        string nombre;

        public string Nombre
        // esto es una encapsulacion para proteger el atributo(propiedad) y no afecte en el futuro si quiero cambiar el nombre del atributo  o agregar logica sin cambiar nada mas es una propfull
        {
            get{ return "topo:" + nombre; }
            set{ nombre = value.ToUpper(); }
        }
       
        public int AñoDeCreacion {get; set; }
        
        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        // esto es una forma mucho mas rapida de encapsular 



        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        } 
        // esto es un constructor y le pongo una propiedad nombre para que me de un nombre de ahuevo y la variable que tenga el this es la que pertenece a la clase y no al constructor y es una lista de parametros y parametros opcionales son los que tienen el igual
        
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        // esto es otra manera mucho mas corta que la de arriba de hacer un constructor. es una igualacion por tuplas esd para poner multiples valores
        


        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo:{TipoEscuela} {System.Environment.NewLine} Pais:{Pais}, Ciudad:{Ciudad}";
        }
         // rescribimos el metodo ToString para que me de esos datos en vez del nnombre de los archivos ToString es un metodo que ya viene por defecto con unas instruccines que son mostrar el nombre de los archivos del objeto 
        // el signo de pesos me permite utilizar variables que tengo espicificadas en algun lugar
        // si necesito colocar caracteres especiales dentro del texto puedo usar el slash comilla para que el programa lo identifique como una comilla sin qeu cierre las comillas
    }   // {System.Enviroment.NewLine} este comando sustitulle al slash n por se puede utilisar si la aplicacion exije mucho de la consola y si estamos trabajando con sistemas operativos linux que usan la consola esto nos puede ayudar 
}       // n\ es para un salto entre lineas de windows pero para usar git y no me formatee uso el system.enviroment para que me reconosca el salto de linea en tpdas las plataformas 