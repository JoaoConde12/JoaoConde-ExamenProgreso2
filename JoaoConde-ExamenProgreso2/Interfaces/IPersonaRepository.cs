using JoaoConde_ExamenProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoConde_ExamenProgreso2.Interfaces
{
    public interface IPersonaRepository
    {
        Boolean CrearPersona(Persona persona);
        Persona ObtenerPersona(int Id);
    }
}
