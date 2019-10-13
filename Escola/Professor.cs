﻿using System;

namespace Projeto
{
    class Professor : Pessoa
    {
        public int Registro { get; private set; }

        //Metodo para criar um professor
        public Professor CadastrarProfessor()
        {
            //Cria um professor com numero de registro aleatorio
            Professor professor = new Professor();
            Random aleatorio = new Random();
            professor.Registro = aleatorio.Next(1000, 9999);
            Console.WriteLine($"Numero de registro: {professor.Registro}");
            //Pergunta o nome do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write("Digite o nome do professor: ");
                professor.Nome = Console.ReadLine();
            }
            while (professor.Nome == null);
            //Pergunta a idade do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write("Digite a idade do professor: ");
                professor.Idade = (Console.ReadLine());
            }
            while (professor.Idade == "");
            //Pergunta o sexo do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write("Qual o sexo do professor (M / F): ");
                professor.Sexo = (Console.ReadLine());
            }
            while (professor.Sexo == "");
            return professor;
        }
    }
}
