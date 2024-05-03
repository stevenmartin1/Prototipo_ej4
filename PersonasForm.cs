namespace ClasePrototipos
{
    public partial class PersonasForm : Form
    {
        PersonasModelo modelo = new();
        public PersonasForm()
        {
            InitializeComponent();
        }
        public void PersonasForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(  "");
            
            foreach(var persona in modelo.Personas)
            {
                var fila = new ListViewItem();
                fila.Text = persona.Documento.ToString();
                fila.SubItems.Add(persona.Nombre);
                fila.SubItems.Add(persona.Apellido);
                fila.SubItems.Add(persona.Telefono.Descripcion());
                lstwPersonas.Items.Add(fila);
               
            }
            MessageBox.Show("");
        }
    }
}
