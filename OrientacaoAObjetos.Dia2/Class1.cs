using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia2
{
    public class Segurado
    {
        public string id;

       
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public string CPF { get; set; }

        //Construtor Default
        public Segurado()
        {

        }
        //OConstrutor tem o mesmo nome da classe


        //Construtor com parâmetro
        public Segurado(int id) 
        {
            Id = id;

           
        }


        //Construtor com Sobrecarga
        public Segurado(string nome)
        {
            Nome = nome;
       
        }

        public Segurado(string nome, string cpf) 
        {
            Nome = nome;
            CPF = cpf;
        }

        public string Teste() 
        {
            return "Chegou aqui, Tá perdido é doidão?";
        }




    }
}
