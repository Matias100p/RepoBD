using System;
using MySql.Data.MySqlClient;
namespace RepoBD
{
    class ConexionBD
    {
        MySqlConnection Conector;
        MySqlCommand Comando;
        public void Conectar()
        {
            Conector = new MySqlConnection(@"server=127.0.0.1; database=5to_Persona; Uid=5to_agbd; pwd=Trigg3rs|");
            Comando=Conector.CreateComand();
 
        }
        public void insertarBD()
        {
            Comando.CommandText = "Insert into Persona (DNI,Apellido,Nombre,FechaNAcimiento) values(78456921,´Mansilla´,´Facundo´,'2004-03-17')";
            Comando.CommandType= CommandType.Text;
            Conector.Open();
            Comando.ExecuteNonQuery();
        }
    }
}