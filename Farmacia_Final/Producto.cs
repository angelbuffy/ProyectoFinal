using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    public class Producto
    {
        private string _ID;
        private string _Nombre;
        private string _Proveedor;
        private int _Stock;
        private string _Fecha;

        public Producto(string ID1, string Nom, string Prov, int
             stock,  string Fech)
        {
            ID = ID1;
            Nombre = Nom;
            Proveedor = Prov;
            Stock = stock;
            Fecha = Fech;

        }
        public string ID
        {
            get
            {
                return _ID;
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
                    _ID = value.Trim();
                }
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del nombre no puede quedar vacío.");
                }

                else
                {
                    _Nombre = value.Trim();
                }
            }
        }

        public string Proveedor
        {
            get
            {
                return _Proveedor;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido paterno no puede quedar vacío.");
                }

                else
                {
                    _Proveedor = value.Trim();
                }
            }
        }

        public int Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                _Stock = value;
            }
        }


        public string Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la profesion no puede quedar vacío.");
                }

                else
                {
                    _Fecha = value.Trim();
                }
            }
        }

        public void Registrar_Producto()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("InsertarProductos2", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Proveedor", Proveedor);
            comando.Parameters.AddWithValue("@Stock", Stock);
            comando.Parameters.AddWithValue("@Fechanacimiento", Fecha);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}
