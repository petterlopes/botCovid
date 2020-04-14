using BotCovid.Core.Entidades;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Repositorios
{
    public class RepositorioDeUsuario
    {
        private static ConcurrentDictionary<string, Usuario> Usuarios = new ConcurrentDictionary<string, Usuario>();
        public RepositorioDeUsuario()
        {
        }

        public void AdicionarUsuario(Usuario usu)
        {
            Usuarios.TryAdd(usu.Telefone, usu);
        }

        public IEnumerable<Usuario> BuscarUsuarios(Func<Usuario, bool> funcao)
        {
            return Usuarios.Values.Where(funcao);
        }

    }

}
