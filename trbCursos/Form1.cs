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
        OleDbDataReader dr2;

        int intCodCurso;
        string strNomeCurso;
        //string strCodDisciplina;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        
        private void InserirCodigoC()
        {
            clbCurso.Items.Clear();
            try
            {
                string strNoQuery = "insert into tbGrade (txtCodigoC) values ("+ intCodCurso +")";
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
            intCodCurso = Convert.ToInt32(clbCurso.SelectedIndex.ToString());
            strNomeCurso = clbCurso.Text;
            


        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            //Quando click é consultado o codigo do curso usando como where o curso marcado 
            string strQuery = "select txtCodigoC from tbCursos where txtNomeC = '" + strNomeCurso +"'";
            comandoSelect.CommandText = strQuery;
            conexao.Open();
            dr2 = comandoSelect.ExecuteReader();

            if (dr2.HasRows)
            {
               while (dr2.Read())
               {
                 string textoteste = dr2[0].ToString();
                 MessageBox.Show(textoteste);
               }
            }
            dr2.Close();
            conexao.Close(); //fecha conexao para poder ser selecionada outro curso 
            //Limpar o curso que está marcado perguntar ao mestre 
            //#

            conexaoInsert.Close();
        }
    }
}
