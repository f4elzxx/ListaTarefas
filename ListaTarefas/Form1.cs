using ListaTarefas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTarefas
{
    public partial class Form1 : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        public Form1()
        {
            InitializeComponent();
            Classes.Tarefas tarefas = new Classes.Tarefas();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            DgvTarefas.DataSource = tarefas.ListarTudo();
        }

        private void DgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            GrbEdit.Enabled = true;
            grbApagar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = DgvTarefas.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvTarefas.Rows[linhaSelecionada];

            // Preencher os campos:
            TxbTarefaEdit.Text = linha.Cells[1].Value.ToString();
            TxbLocalEdit.Text = linha.Cells[2].Value.ToString();
            TxbObsEdit.Text = linha.Cells[3].Value.ToString();
            TxbDataEdit.Text = linha.Cells[4].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {

            // Instanciar o usuário:
            Classes.Tarefas tarefas = new Classes.Tarefas();
            // Obter os valores dos campos:
            tarefas.nome_tarefa = TxbTarefa.Text;
            tarefas.local = TxbLocal.Text;
            tarefas.observacao = TxbObs.Text;
            tarefas.data_limite = DateTime.Parse(TxbData.Text);

            if (tarefas.Inserir() == true)
            {
                MessageBox.Show("Tarefa cadastrada com sucesso!");
                // Limpar os campos:
                TxbTarefa.Clear();
                TxbLocal.Clear();
                TxbObs.Clear();
                TxbData.Clear();
                // Atualizar o dgv:
                DgvTarefas.DataSource = tarefas.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar tarefa!");
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Classes.Tarefas tarefas = new Classes.Tarefas();
            tarefas.Id = idSelecionado;
            // Confirmar a exclusão:



            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (tarefas.Apagar() == true)
                {
                    MessageBox.Show("Tarefa removida!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    DgvTarefas.DataSource = tarefas.ListarTudo();
                    // Limpar os campos de edição:

                    TxbTarefaEdit.Clear();
                    TxbObsEdit.Clear();
                    TxbLocalEdit.Clear();
                    lblApagar.Text = "Selecione um tarefa para apagar.";

                    //Desabilitar os grbs

                    // Desabilitar os grbs:

                    grbApagar.Enabled = false;
                    GrbEdit.Enabled = false;
                }
                else
                {

                    MessageBox.Show("Falha ao remover tarefa", "Falha!",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Classes.Tarefas tarefas = new Classes.Tarefas();



            // Obter os valores dos txbs:

            tarefas.Id = idSelecionado;
            tarefas.nome_tarefa = TxbTarefaEdit.Text;
            tarefas.local = TxbLocalEdit.Text;
            tarefas.observacao = TxbObsEdit.Text;
            tarefas.data_limite = DateTime.Parse(TxbDataEdit.Text);


            //Editar 
            if (tarefas.Editar() == true)
            {
                MessageBox.Show("Tarefa  modificada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvTarefas.DataSource = tarefas.ListarTudo();
               

            }
            else
            {
                MessageBox.Show("Falha ao modificar Tarefa ", "falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            TxbTarefaEdit.Clear();
            TxbLocalEdit.Clear();
            TxbObsEdit.Clear();
            TxbDataEdit.Clear();

        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
