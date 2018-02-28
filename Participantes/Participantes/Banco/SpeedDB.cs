using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Participantes.Banco
{
    class SpeedDB
    {
        string connectionString = @"Server=DESKTOP-RODRI;Database=DBSPED;Trusted_Connection=True;";
      
        public SpeedDB()
        {
       
        }

        //Insere registro na tabela PARTICIPANTE
        public void Insert_intoDB(PARTICIPANTES participante) {

            string sql = @"INSERT INTO PARTICIPANTES (COD_PART, NOME, COD_PAIS, CNPJ, CPF, IE,
                            COD_MUN, SUFRAMA, [END], NUM, COMPL, BAIRRO)"
                        + "VALUES ('"+participante.COD_PART+"', '"+participante.NOME+"', '"
                        + participante.COD_PAIS+"', '"+participante.CNPJ+"', '"+participante.CPF+"', '"
                        + participante.IE+"', '"+participante.COD_MUN+"', '"+participante.SUFRAMA+"', '"
                        + participante.END+"', '"+participante.NUM+"', '"+participante.COMPL+"', '"+participante.BAIRRO+"')"; 

                        
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        //Carrega todos os registros da tabela PARTICIPANTES
        public DataTable Load_DataParticipantes()
        {
            string sql = @"SELECT * from PARTICIPANTES"
;
            SqlConnection con = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            con.Open();
            try
            {

                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);               
                adapt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        //Carrega todos os regsitros da tabela PAIS
        public DataTable Load_DataPais()
        {
            string sql = @"SELECT * from PAIS"
;
            SqlConnection con = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
                adapt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}