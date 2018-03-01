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
            string sql = @"IF EXISTS (select * from PARTICIPANTES with (updlock,serializable) where COD_PART = '" + participante.COD_PART + "') "
                            + "BEGIN "
                                + "UPDATE PARTICIPANTES set NOME = '" + participante.NOME + "', COD_PAIS = '" + participante.COD_PAIS + "', CNPJ = '" + participante.CNPJ + "', CPF = '" + participante.CPF
                                + "', IE='" + participante.IE + "', COD_MUN='" + participante.COD_MUN + "', SUFRAMA='" + participante.SUFRAMA + "', [END]='" + participante.END
                                + "', NUM='" + participante.NUM + "', COMPL='" + participante.COMPL + "', BAIRRO='" + participante.BAIRRO + "' "
                            + "END "
                        + "ELSE "
                            + "BEGIN "
                                + "INSERT INTO PARTICIPANTES (COD_PART, NOME, COD_PAIS, CNPJ, CPF, IE, COD_MUN, SUFRAMA, [END], NUM, COMPL, BAIRRO) "
                                + "VALUES ('"+participante.COD_PART+"', '"+participante.NOME+"', '"
                                + participante.COD_PAIS+"', '"+participante.CNPJ+"', '"+participante.CPF+"', '"
                                + participante.IE+"', '"+participante.COD_MUN+"', '"+participante.SUFRAMA+"', '"
                                + participante.END+"', '"+participante.NUM+"', '"+participante.COMPL+"', '"+participante.BAIRRO+ "') "
                            + "END";                        
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

        public void Exclude_fromDB(string codPart)
        {
            string sql = "DELETE FROM PARTICIPANTES WHERE COD_PART='" + codPart + "'";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
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

        private DataTable selectFrom(string sql)
        {
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

        //Carrega todos os registros da tabela PARTICIPANTES
        public DataTable Load_DataParticipantes()
        {
            string sql = @"SELECT * from PARTICIPANTES";;
            return selectFrom(sql);
        }

        //Carrega todos os regsitros da tabela PAIS
        public DataTable Load_DataPais()
        {
            string sql = @"SELECT * from PAIS";;
            return selectFrom(sql);
        }

        //Carrega todos os regsitros da tabela UF
        public DataTable Load_DataUF()
        {
            string sql = @"SELECT * from UF"; ;
            return selectFrom(sql);
        }

        public DataTable Load_MunByUF(string codUF) {
            string sql = @"SELECT * from MUNICIPIO where cUF = '"+ codUF +"'";
            return selectFrom(sql);
        }

    }
}