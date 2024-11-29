using JoaoConde_ExamenProgreso2.Interfaces;
using JoaoConde_ExamenProgreso2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoConde_ExamenProgreso2.Repositories
{
    public class PersonaFilesRepository : IPersonaRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "JoaoConde.txt");

        public bool CrearPersona(Persona persona)
        {
            try
            {
                string persona_json = JsonConvert.SerializeObject(persona);
                File.WriteAllText(_fileName, persona_json);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Persona ObtenerPersona(int Id)
        {
            Persona persona = new Persona();

            if (File.Exists(_fileName))
            {
                string data = File.ReadAllText(_fileName);
                persona = JsonConvert.DeserializeObject<Persona>(data);
            }

            return persona;
        }
    }
}
