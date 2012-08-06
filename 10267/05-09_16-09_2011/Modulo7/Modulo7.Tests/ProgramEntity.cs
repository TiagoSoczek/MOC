namespace Modulo7.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramEntity
    {
        public static void Main(string[] args)
        {
            MOC10267Entities db = new MOC10267Entities();

            List<Usuario> usuarios = 
                db.Usuarios.Where(u => u.Email.Contains("@")).ToList();

            foreach (var u in usuarios)
            {
                Console.WriteLine(u.Email);
            }

            return;

            Usuario usuario = new Usuario();

            usuario.Email = "tiagosoczek@gmail.com";
            usuario.Senha = "trólóló2";

            db.AddToUsuarios(usuario);

            db.SaveChanges();

            Console.WriteLine(usuario.Id);
        } 
    }
}