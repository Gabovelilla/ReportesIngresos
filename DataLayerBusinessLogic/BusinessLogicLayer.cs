using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public class BusinessLogicLayer
    {
        private DataAccesLayer _dataAccesLayer;
        private protected Estudiantes aseguradorEmpleadoD;
        private protected Profesores aseguradorEmpleadoa;

        public BusinessLogicLayer()
        {
            _dataAccesLayer = new DataAccesLayer();
          
           
        }
        public Estudiantes Saveestudiante(Estudiantes estudiantes)
        {
            if (estudiantes.Codigo == 0)
            {
                _dataAccesLayer.InsertEstudiante(estudiantes);
            }

            
            return estudiantes;
        }
        public Estudiantes Actualizarestudiante(Estudiantes estudiantes)
        {
         
                _dataAccesLayer.UpdateEstudiante(estudiantes);

            return estudiantes;
        }

        public static DataTable verlista(DateTime date)
        {

            return  new DataAccesLayer().Verlistaeatudiantes(date);

        }




        internal void SaveProfesor(Profesores profesores)
        {
            if (profesores.Codigo == 0)
            {
                _dataAccesLayer.InsertProfesores(profesores);
            }
        }

        internal void ActualizaProfesores(Profesores profesores)
        {
            _dataAccesLayer.UpdateProfesores(profesores);
           

           
        }

        internal static object verlistaProfe(DateTime date)
        {
            return new DataAccesLayer().VerlistaProfesores(date);
        }



        internal void SavePlanta(Planta planta)
        {
            if (planta.Codigo == 0)
            {
                _dataAccesLayer.InsertPlanta(planta);
            }
        }

        internal static object verlistaPlanta(DateTime date)
        {
            return new DataAccesLayer().VerlistaPlanta(date);
        }

        internal void ActualizarPlanta(Planta planta)
        {
            _dataAccesLayer.UpdatePlanta(planta);

           
        }
    }
}
