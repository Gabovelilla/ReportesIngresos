using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public  class DataAccesLayer
    {
        private SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=IngresoUniversidad;Data Source=DESKTOP-NBK140I\\SQLEXPRESS");
        SqlDataAdapter dataAdapter;
        DataTable datatable;

        internal void InsertProfesores(Profesores profesores)
        {
            try
            {
                connection.Open();
                string query = @"
                        Insert into RegEntradaProfesores( Documento, Nombre, Apellido, Carrera, Municipio, Fecha)
                        VALUES ( @Documento, @Nombre, @Apellido, @Carrera, @Municipio, @Fecha)";



                SqlParameter documento = new SqlParameter();
                documento.ParameterName = "@Documento";
                documento.Value = profesores.Documento;
                documento.DbType = System.Data.DbType.String;


                SqlParameter nombre = new SqlParameter("@Nombre", profesores.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", profesores.Apellido);
                SqlParameter carrera = new SqlParameter("@Carrera", profesores.Carrera);
                SqlParameter municipio = new SqlParameter("@Municipio", profesores.Municipio);
                SqlParameter fecha = new SqlParameter("@Fecha", profesores.Fecha);


                SqlCommand Command = new SqlCommand(query, connection);

                Command.Parameters.Add(documento);
                Command.Parameters.Add(nombre);
                Command.Parameters.Add(apellido);
                Command.Parameters.Add(carrera);
                Command.Parameters.Add(municipio);
                Command.Parameters.Add(fecha);

                Command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        internal void UpdatePlanta(Planta planta)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_PlantaUPDATE", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            connection.Open();
            SqlCmd.Parameters.AddWithValue("@Codigo", planta.Codigo);
            SqlCmd.Parameters.AddWithValue("@Documento", planta.Documento);
            SqlCmd.Parameters.AddWithValue("@Nombre", planta.Nombre);
            SqlCmd.Parameters.AddWithValue("@Apellido", planta.Apellido);
            SqlCmd.Parameters.AddWithValue("@Cargo", planta.Cargo);
            SqlCmd.Parameters.AddWithValue("@Municipio", planta.Municipio);


            SqlCmd.ExecuteNonQuery();

            connection.Close();
        }

        internal void UpdateProfesores(Profesores profesores)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_ProfesoresUPDATEE", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            connection.Open();
            SqlCmd.Parameters.AddWithValue("@Codigo", profesores.Codigo);
            SqlCmd.Parameters.AddWithValue("@Documento", profesores.Documento);
            SqlCmd.Parameters.AddWithValue("@Nombre", profesores.Nombre);
            SqlCmd.Parameters.AddWithValue("@Apellido", profesores.Apellido);
            SqlCmd.Parameters.AddWithValue("@Carrera", profesores.Carrera);
            SqlCmd.Parameters.AddWithValue("@Municipio", profesores.Municipio);


            SqlCmd.ExecuteNonQuery();

            connection.Close();
        }
        internal object VerlistaProfesores(DateTime date)
        {
            connection.Open();


            SqlParameter fecha = new SqlParameter("@Fechaini", date);


            SqlParameter fecha2 = new SqlParameter("@Fechafini", date);



            {
                DataTable DtResultado = new DataTable();
                SqlCommand sqlcmd = new SqlCommand("sp_ProfesoresSELECT", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlcmd.Parameters.AddWithValue("@Fechaini", date.Date.AddHours(0).AddMinutes(0).AddSeconds(0));
                sqlcmd.Parameters.AddWithValue("@Fechafini", date.Date.AddHours(22).AddMinutes(50).AddSeconds(50));

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado);

                connection.Close();
                return DtResultado;

            }

        }

        internal void InsertPlanta(Planta planta)
        {
            try
            {
                connection.Open();
                string query = @"
                        Insert into RegEntradaPlanta( Documento, Nombre, Apellido, Cargo, Municipio, Fecha)
                        VALUES ( @Documento, @Nombre, @Apellido, @Cargo, @Municipio, @Fecha)";



                SqlParameter documento = new SqlParameter();
                documento.ParameterName = "@Documento";
                documento.Value = planta.Documento;
                documento.DbType = System.Data.DbType.String;


                SqlParameter nombre = new SqlParameter("@Nombre", planta.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", planta.Apellido);
                SqlParameter cargo = new SqlParameter("@Cargo", planta.Cargo);
                SqlParameter municipio = new SqlParameter("@Municipio", planta.Municipio);
                SqlParameter fecha = new SqlParameter("@Fecha", planta.Fecha);


                SqlCommand Command = new SqlCommand(query, connection);

                Command.Parameters.Add(documento);
                Command.Parameters.Add(nombre);
                Command.Parameters.Add(apellido);
                Command.Parameters.Add(cargo);
                Command.Parameters.Add(municipio);
                Command.Parameters.Add(fecha);

                Command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        internal object VerlistaPlanta(DateTime date)
        {
            connection.Open();


            SqlParameter fecha = new SqlParameter("@Fechaini", date);


            SqlParameter fecha2 = new SqlParameter("@Fechafini", date);



            {
                DataTable DtResultado = new DataTable();
                SqlCommand sqlcmd = new SqlCommand("sp_PlantaSelect", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlcmd.Parameters.AddWithValue("@Fechaini", date.Date.AddHours(0).AddMinutes(0).AddSeconds(0));
                sqlcmd.Parameters.AddWithValue("@Fechafini", date.Date.AddHours(22).AddMinutes(50).AddSeconds(50));

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado);

                connection.Close();
                return DtResultado;

            }

        }





        public void InsertEstudiante(Estudiantes estudiantes)
        {
            try
            {
                connection.Open();
                string query = @"
                        Insert into RegEntradaEstudiantes( Documento, Nombre, Apellido, Carrera, Municipio, Fecha)
                        VALUES ( @Documento, @Nombre, @Apellido, @Carrera, @Municipio, @Fecha)";

            

                SqlParameter documento = new SqlParameter();
                documento.ParameterName = "@Documento";
                documento.Value = estudiantes.Documento;
                documento.DbType = System.Data.DbType.String;

            
                SqlParameter nombre = new SqlParameter("@Nombre", estudiantes.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", estudiantes.Apellido);
                SqlParameter carrera = new SqlParameter("@Carrera", estudiantes.Carrera);
                SqlParameter municipio = new SqlParameter("@Municipio", estudiantes.Municipio);
                SqlParameter fecha = new SqlParameter("@Fecha", estudiantes.Fecha);


                SqlCommand  Command = new SqlCommand(query, connection);
                
                Command.Parameters.Add(documento);
                Command.Parameters.Add(nombre);
                Command.Parameters.Add(apellido);
                Command.Parameters.Add(carrera);
                Command.Parameters.Add(municipio);
                Command.Parameters.Add(fecha);

                Command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

       

        public void UpdateEstudiante(Estudiantes estudiantes)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_EstudiantesUPDATE", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            connection.Open();
            SqlCmd.Parameters.AddWithValue("@Codigo", estudiantes.Codigo);
            SqlCmd.Parameters.AddWithValue("@Documento", estudiantes.Documento);
            SqlCmd.Parameters.AddWithValue("@Nombre", estudiantes.Nombre);
            SqlCmd.Parameters.AddWithValue("@Apellido", estudiantes.Apellido);
            SqlCmd.Parameters.AddWithValue("@Carrera", estudiantes.Carrera);
            SqlCmd.Parameters.AddWithValue("@Municipio", estudiantes.Municipio);
       

            SqlCmd.ExecuteNonQuery();

            connection.Close();
        }
    

        public DataTable Verlistaeatudiantes(DateTime date)
        {  
            connection.Open();


            SqlParameter fecha = new SqlParameter("@Fechaini", date);

          
            SqlParameter fecha2 = new SqlParameter("@Fechafini", date);



            {
                DataTable DtResultado = new DataTable();
                SqlCommand sqlcmd = new SqlCommand("sp_EstudiantesSELECT", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlcmd.Parameters.AddWithValue("@Fechaini", date.Date.AddHours(0).AddMinutes(0).AddSeconds(0));
                sqlcmd.Parameters.AddWithValue("@Fechafini", date.Date.AddHours(22).AddMinutes(50).AddSeconds(50));

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado);

                connection.Close();
                return DtResultado;
               
             }


           

        }
    }
}
