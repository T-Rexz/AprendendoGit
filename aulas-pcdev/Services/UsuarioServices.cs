using AulasPCDev.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Services
{
    public class UsuarioServices
    {
        private static List<Usuario> _listaUsuarios = new List<Usuario>();

        public void ListarUsuarios()
        {
            Console.WriteLine("NOME     - IDADE    - SALDO      - ÚLTIMO FILME ALUGADO");
            foreach (Usuario usuario in _listaUsuarios)
            {
                Console.WriteLine(usuario.Nome + " - " + usuario.Idade + " - " + usuario.Conta.Saldo);
            }
        }

        public void CadastrarUsuario()
        {
            Console.WriteLine("Digite o nome do usuário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do usuário:");
            int idade = int.Parse(Console.ReadLine());

            Usuario usuario = new Usuario(idade);
            usuario.Nome = nome;
            Console.WriteLine("Idade: " + usuario.Idade);
            Console.WriteLine("Bem vindo a locadora " + usuario.Nome + ", por ser novo aqui você recebeu um crédito de " + usuario.Conta.ToString() + ".");

            _listaUsuarios.Add(usuario);
        }

        public void CadastrarFilmeSerie()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1- Filme \n2- Série");

            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine("Digite o nome completo do filme");
                string filmeNome = Console.ReadLine();
                Console.WriteLine("Digite o ano do filme " + filmeNome);
                int filmeAno = int.Parse(Console.ReadLine());
                Console.WriteLine(filmeNome + " - " + filmeAno);
                Console.WriteLine("Cadastro do filme concluído.");
            }
            if (resposta == 2)
            {
                Console.WriteLine("Digite o nome completo da série");
                string serieNome = Console.ReadLine();
                Console.WriteLine("Digite o ano da série " + serieNome);
                int serieAno = int.Parse(Console.ReadLine());
                Console.WriteLine(serieNome + " - " + serieAno);
                Console.WriteLine("Cadastro da série concluído.");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        public void Locacao()
        {

        }
    }
}
