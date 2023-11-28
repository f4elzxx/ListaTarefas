using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ListaTarefas.Classes
{
    internal class Tarefas
    {
        public int Id { get; set; }
        public string nome_tarefa { get; set; }
        public string local { get; set; }
        public string observacao { get; set; }
        public DateTime data_limite { get; set; }


        // Métodos:

        // Logar:
        public bool Inserir()
        {
            string comando = "INSERT INTO tarefas (nome_tarefa, local, observacao, data_limite) " +
                "VALUES (@nome_tarefa, @local, @observacao, @data_limite)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome_tarefa", nome_tarefa);
            cmd.Parameters.AddWithValue("@local", local);
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@data_limite", data_limite);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Apagar()
        {


            string comando = "DELETE FROM tarefas Where id = @id";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Editar()
        {
            string comando = "UPDATE tarefas SET nome_tarefa = @nome_tarefa, local = @local, observacao = @observacao, data_limite = @data_limite WHERE id = @id"; 

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome_tarefa", nome_tarefa);
            cmd.Parameters.AddWithValue("@local", local);
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@data_limite", data_limite);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_tarefa, local, observacao, data_limite FROM tarefas";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

    }

}
