using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Conexion.Models
{
    public class RegistroLibro
    {
        private SqlConnection con;
        private void Conectar()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            con = new SqlConnection(connStr);
        }
        public int GrabarLibro(Libro lib)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Insert Into Libro (Titulo, Autor, ISBN, Editora, URL)" +
                                                "Values (@Titulo, @Autor, @ISBN, @Editora, @URL)", con);
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters.Add("@Autor", SqlDbType.VarChar);
            comando.Parameters.Add("@ISBN", SqlDbType.VarChar);
            comando.Parameters.Add("@Editora", SqlDbType.VarChar);
            comando.Parameters.Add("@URL", SqlDbType.VarChar);

            comando.Parameters["@Titulo"].Value = lib.Titulo;
            comando.Parameters["@Autor"].Value = lib.Autor;
            comando.Parameters["@ISBN"].Value = lib.ISBN;
            comando.Parameters["@Editora"].Value = lib.Editora;
            comando.Parameters["@URL"].Value = lib.URL;

            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public List<Libro> RecuperarTodos()
        {
            Conectar();
            List<Libro> libros = new List<Libro>();

            SqlCommand com = new SqlCommand("Select IdLibro, Titulo, Autor, ISBN, Editora, URL From Libro", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();

            while (registros.Read())
            {
                Libro lib = new Libro
                {
                    IdLibro = int.Parse(registros["IdLibro"].ToString()),
                    Titulo = registros["Titulo"].ToString(),
                    Autor = registros["Autor"].ToString(),
                    ISBN = registros["ISBN"].ToString(),
                    Editora = registros["Editora"].ToString(),
                    URL = registros["URL"].ToString()

                };
                libros.Add(lib);
            }
            con.Close();
            return libros;

        }
        public Libro Recuperar(int idLibro)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Select IdLibro, Titulo, Autor, ISBN, Editora, URL " +
                                                "From Libro where IdLibro=@IdLibro", con);
            comando.Parameters.Add("@IdLibro", SqlDbType.Int);
            comando.Parameters["@IdLibro"].Value = idLibro;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Libro libro = new Libro();
            if (registros.Read())
            {
                libro.Titulo = registros["Titulo"].ToString();
                libro.Autor = registros["Director"].ToString();
                libro.ISBN = registros["ActorPrincipal"].ToString();
                libro.Editora = registros["No_Actores"].ToString();
                libro.URL = registros["Duracion"].ToString();

            }
            con.Close();
            return libro;
        }
        public int Modificar(Libro lib)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Update Libro set Titulo=@Titulo, Autor=@Autor, ISBN=@ISBN, Editora=@Editora," +
                "URL@URL where IdLibro=@IdLibro", con);

            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters["@Titulo"].Value = lib.Titulo;
            comando.Parameters.Add("@Autor", SqlDbType.VarChar);
            comando.Parameters["@Autor"].Value = lib.Autor;
            comando.Parameters.Add("@ISBN", SqlDbType.VarChar);
            comando.Parameters["@ISBN"].Value = lib.ISBN;
            comando.Parameters.Add("@Editora", SqlDbType.VarChar);
            comando.Parameters["@Editora"].Value = lib.Editora;
            comando.Parameters.Add("@URL", SqlDbType.VarChar);
            comando.Parameters["@URL"].Value = lib.Titulo;


            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int Borrar(int idLibro)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("delete from Libro where IdLibro=@IdLibro", con);
            comando.Parameters.Add("@IdLibro", SqlDbType.Int);
            comando.Parameters["@IdLibro"].Value = idLibro;
            con.Open();
            int i = comando.ExecuteNonQuery();
            return i;
        }

    
    }
}