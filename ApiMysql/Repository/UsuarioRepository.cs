﻿using ApiMySql.Model;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMySql.Repository
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;   // Injetando a string de conexão no construtor da classe
        }

        public IEnumerable<Usuario> GetAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                /*
                Usando o extension Method Query<> do dapper para a obtenção dos registros de Usuario.
                O extension method depende do namespace delcarado como using no arquivo de classe: using Dapper;
                Basicamente é feita uma query, obtendo todos os registros na tabela Usuario e mapeando para o objeto Usuario,
                especificado em Query<Usuario>. Caso os nomes das colunas da tabela sejam diferentes das propriedades do
                objeto de retorno, deve-se usar o recurso de rename de colunas no select, por exemplo:
                SELECT Codigo as Id, Nome as Usuario FROM Usuario. Neste select estamos mapeando a coluna Codigo para a 
                propriedade Id do objeto de retorno, se for o caso.
                 */
                return connection.Query<Usuario>("SELECT * FROM Usuario ORDER BY 1 ASC");
            }
        }

        public int Add(Usuario item)
        {
            string sql = @"INSERT INTO Usuario(Email, Senha, NomeCompleto, DataNascimento, UsuarioContribuidor) VALUES(@Email, @Senha, @NomeCompleto, @DataNascimento, @UsuarioContribuidor);  select LAST_INSERT_ID(); ";

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                item.Id = connection.ExecuteScalar<int>(sql, new
                {
                    email = item.Email,
                    senha = item.Senha,
                    usuarioContribuidor = item.UsuarioContribuidor,
                    nomeCompleto = item.NomeCompleto,
                    dataNascimento = item.DataNascimento                   
                   
                });
                return item.Id;
            }
        }


        public bool ExistsID(int id)
        {
            bool existe = false;

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                existe = connection.ExecuteScalar<bool>("SELECT * FROM Usuario WHERE id = @Id", new { Id = id });
                return existe;
            }
        }
        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


       
        public Usuario FindByID(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<Usuario>("SELECT * FROM Usuario WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }



        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



        public void Remove(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM Usuario WHERE Id=@Id", new { Id = id });
            }
        }

        
        public override string ToString()
        {
            return base.ToString();
        }



        public void Update(Usuario item)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                connection.Query("UPDATE Usuario SET email = @Email, senha = @Senha, nomeCompleto = @NomeCompleto, dataNascimento = @DataNascimento, usuarioContribuidor = @UsuarioContribuidor  WHERE id = @Id", item);
            }
        }
    }
}
