using JoaoConde_ExamenProgreso2.Interfaces;
using JoaoConde_ExamenProgreso2.Models;
using JoaoConde_ExamenProgreso2.Repositories;

namespace JoaoConde_ExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        public Persona persona;
        IPersonaRepository _personaRepository;

        public MainPage()
        {
            InitializeComponent();
            _personaRepository = new PersonaFilesRepository();
            persona = _personaRepository.ObtenerPersona(1);

            BindingContext = persona;
        }

        private void BotonHacerRecarga_Clicked(object sender, EventArgs e)
        {
            var nombre = jconde_entry1.Text;
            var telefono = jconde_entry2.Text;
            var id = 1;

            Persona persona = new Persona() {
                ID = id,
                Nombre = nombre,
                Telefono = telefono
            };

            bool crear_persona = _personaRepository.CrearPersona(persona);
        }
    }
}
