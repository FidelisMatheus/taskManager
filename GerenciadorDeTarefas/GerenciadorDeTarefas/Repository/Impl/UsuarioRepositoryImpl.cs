﻿using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Repository.Impl
{
    public class UsuarioRepositoryImpl : IUsuarioRepository
    {
        //aqui precisamos do contexto para poder acessar o banco de dados

        private readonly GerenciadorDeTarefasContext _contexto;
        public UsuarioRepositoryImpl(GerenciadorDeTarefasContext contexto)
        {
            _contexto = contexto;
        }

        public void Salvar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();//commitando
        }
    }
}
