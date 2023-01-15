﻿using bytebank_ADM.SistemaInternoBytebank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        protected FuncionarioAutenticavel()
        {
        }

        public FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public bool Autenticar(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login);
        }
    }
}
