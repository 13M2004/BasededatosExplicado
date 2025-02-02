﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfdb.Data.DataAccess
{
    internal class PersonajeDB
    {
       
        // Información de conexión a la base de datos
        private string connectionString = "Server = localhost; Database = db_universidad; Uid=root;Pwd=alex123";

        //constructor
        public PersonajeDB(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=db_universidad;Uid=" + usur + ";Pwd=" + pwd + "alex123";
        }

        //prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Método para leer todos los personajes
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

        // Método para crear un nuevo personaje
        public int CrearPersonaje(string nombre, string raza, int nivelPoder, DateTime fecha_creacion, string historia )
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, fecha_creacion, historia) VALUES (@nombre, @raza, @nivelPoder, @fecha_creacion, @historia)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);
                    command.Parameters.AddWithValue("@historia", historia);

                    return command.ExecuteNonQuery();
                }
            }
        }

        //Busca un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }

       



        // Método para actualizar un personaje
        public void ActualizarPersonaje(int id, string nombre, string raza, int nivelPoder, DateTime fecha_creacion, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, fecha_creacion, historia) VALUES (@nombre, @raza, @nivelPoder, @fecha_creacion, @historia)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);
                    command.Parameters.AddWithValue("@historia", historia);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un personaje
        public void EliminarPersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }



        //si da tiempo:
        // Función para ejecutar consultas SQL genéricas
        public DataTable EjecutarConsulta(string consultaSQL)
        {
            DataTable resultado = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(consultaSQL, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(resultado);
                    }
                }
            }

            return resultado;
        }

        //ordenar un personaje por fecha_creacion 
    public DataTable OrdenarPersonajeFecha(DateTime fecha_creacion)
{
    DataTable ordenar = new DataTable();

    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        connection.Open();
        string sql = "SELECT * FROM db_universidad.personajes_dragon_ball ORDER BY fecha_creacion ASC =@fecha_creacion ";
        using (MySqlCommand command = new MySqlCommand(sql, connection))
        {
            command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                adapter.Fill(ordenar);
            }
        }
    }

    return ordenar;
}
        //Ordenar Reciente 
        public DataTable ObtenerPersonajesRecientes(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable personajesRecientes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM db_universidad.personajes_dragon_ball WHERE fecha_creacion BETWEEN @fechaInicio AND @fechaFin ORDER BY fecha_creacion ASC";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajesRecientes);
                    }
                }
            }

            return personajesRecientes;
        }
    }

}
    

