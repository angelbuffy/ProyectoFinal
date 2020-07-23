using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    public  class Servicios_Realizado
    {
        private string _DNI;
        private string _Nombres;
        private string _Apellidos;
        private string _NombreServicio;

        public Servicios_Realizado(string DNI1, string Nom, string Ape, string
             NomSer)
        {
            DNI = DNI1;
            Nombres = Nom;
            Apellidos = Ape;
            NombreServicios = NomSer;

        }
        public string DNI
        {
            get
            {
                return _DNI;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El número de DNI no puede quedar vacío.");
                }
                else if (value.Trim().Length > 8)
                {
                    throw new ArgumentOutOfRangeException("El número de DNI tiene un formato inválido.");
                }
                else
                {
                    _DNI = value.Trim();
                }
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del nombre no puede quedar vacío.");
                }

                else
                {
                    _Nombres = value.Trim();
                }
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido paterno no puede quedar vacío.");
                }

                else
                {
                    _Apellidos= value.Trim();
                }
            }
        }



        public string NombreServicios
        {
            get
            {
                return _NombreServicio;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la profesion no puede quedar vacío.");
                }

                else
                {
                    _NombreServicio = value.Trim();
                }
            }
        }

        public void RegistrarServicioRealizado()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("InsertarServicioRealizado", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", DNI);
            comando.Parameters.AddWithValue("@Nombres", Nombres);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            comando.Parameters.AddWithValue("@NomServicios", NombreServicios);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}
