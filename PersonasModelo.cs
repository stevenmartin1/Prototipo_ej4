namespace ClasePrototipos
{
    public class PersonasModelo
    {
        public List<Persona> Personas { get; set; }
        public PersonasModelo()
        {
            Personas = new List<Persona>();
            {
                new Persona { Documento = 43875390, Nombre = "Martin", Apellido = "Steven", Telefono = new Telefono { Tipo = TipoTelefono.CASA, CodPais = 11, CodArea = 10,  Numero = 1111 } };
                new Persona { Documento = 43875390, Nombre = "Martin", Apellido = "Steven", Telefono = new Telefono { Tipo = TipoTelefono.TRABAJO, CodPais = 11, CodArea = 10, Numero = 1111 } };
            }
        }
    }
}