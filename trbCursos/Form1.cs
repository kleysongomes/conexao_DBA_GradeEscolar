using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace trbCursos
{
    public partial class Form1 : Form
    {
        OleDbConnection conexao = new OleDbConnection();
        OleDbConnection conexaoInsert = new OleDbConnection();

        OleDbCommand comandoSelect = new OleDbCommand();
        OleDbCommand comandoInsert = new OleDbCommand();

        OleDbDataReader dr;

        string strNomeCurso;
        string strNomeDisciplina;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbCursoDataSet1.tbGrade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbGradeTableAdapter.Fill(this.dbCursoDataSet1.tbGrade);
            
            //Conexao com Banco Access 2002-2003
            conexao.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\Public\dbCurso.mdb; User Id=admin; Password=";
            comandoSelect.Connection = conexao;
            conexaoInsert.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\Public\dbCurso.mdb; User Id=admin; Password=";
            comandoInsert.Connection = conexaoInsert;

            conexao.Open();
            conexaoInsert.Open();
            CarregarCursos();
            CarregarDisciplinas();

            conexao.Close();
        }
       
        private void InserirCodigo()
        {
            try
            {
                string strNoQuery = 
                "INSERT INTO tbGrade (txtCodCurso,txtCodDisciplina) " +
                "SELECT  txtCodigoC, txtCodigoD FROM  tbCursos, tbDisciplinas " +
                "WHERE txtNomeC = '"+ strNomeCurso + "' AND txtNomeD = '" + strNomeDisciplina + "';";

                comandoInsert.CommandText = strNoQuery;
                comandoInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            
        }
        private void CarregarCursos()
        {
            clbCurso.Items.Clear();
            try
            {
                string strQuery = "select txtNomeC from tbCursos";
                comandoSelect.CommandText = strQuery;
                dr = comandoSelect.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       clbCurso.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void CarregarDisciplinas()
        {
            clbDisciplinas.Items.Clear();
            try
            {
                string strQuery = "select txtNomeD from tbDisciplinas";
                comandoSelect.CommandText = strQuery;
                dr = comandoSelect.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clbDisciplinas.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void ClbCurso_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            strNomeCurso = clbCurso.Text.ToString();
            
        }

        private void ClbDisciplinas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
           strNomeDisciplina = clbDisciplinas.Text.ToString();
           
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            clbCurso.ClearSelected();
            clbDisciplinas.ClearSelected();
            InserirCodigo();
            //dgvGrade

        }
    }
}
