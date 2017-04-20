using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using LogicaNegocio;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace Servicios
{
   /// [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class ServicioWCF : System.Web.Services.WebService

    {
        [WebMethod]
        public void GetAllEmployees()
        {
            List<PROVEEDOR> listEmployees = new List<PROVEEDOR>();
            string cs = ConfigurationManager.ConnectionStrings["L3MEntities"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from PROVEEDOR", con);
                
        con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PROVEEDOR employee = new PROVEEDOR();
                    employee.Prov_Cedula = Convert.ToInt32(rdr["Prov_Cedula"]);
                    employee.Nombre = rdr["Nombre"].ToString();
                    employee.Apellido1 = rdr["Apellido1"].ToString();
                    listEmployees.Add(employee);
                }
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
           Context.Response.Write(js.Serialize(listEmployees));
        }


        public int InsertarProveedor(PROVEEDOR dato)
        {
            return LogicaNegocio.LogicaNegocio.InsertarProveedor(dato);
        }

        public bool ModificarProveedor(PROVEEDOR dato)
        {
            return LogicaNegocio.LogicaNegocio.ModificarProveedor(dato);
        }

        public bool EliminarProveedor(PROVEEDOR dato)
        {
            return LogicaNegocio.LogicaNegocio.EliminarProveedor(dato);
        }

        public List<PROVEEDOR> RetonarListadoProveedores()
        {
            return LogicaNegocio.LogicaNegocio.RetonarListadoProveedores();
        }

        public PROVEEDOR RetornarProveedorPorCed(PROVEEDOR dato)
        {
            return LogicaNegocio.LogicaNegocio.RetornarProveedorPorCed(dato);
        }
    }


    /*
  // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioWCF" en el código, en svc y en el archivo de configuración a la vez.
  // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioWCF.svc o ServicioWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
  public class ServicioWCF : IServicioWCF
  {
      public int InsertarProveedor(PROVEEDOR dato)
      {
          return LogicaNegocio.LogicaNegocio.InsertarProveedor(dato);
      }

      public bool ModificarProveedor(PROVEEDOR dato)
      {
          return LogicaNegocio.LogicaNegocio.ModificarProveedor(dato);
      }

      public bool EliminarProveedor(PROVEEDOR dato)
      {
          return LogicaNegocio.LogicaNegocio.EliminarProveedor(dato);
      }

      public List<PROVEEDOR> RetonarListadoProveedores()
      {
          return LogicaNegocio.LogicaNegocio.RetonarListadoProveedores();
      }

      public PROVEEDOR RetornarProveedorPorCed(PROVEEDOR dato)
      {
          return LogicaNegocio.LogicaNegocio.RetornarProveedorPorCed(dato);
      }
  }
}


*/

}




<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Microsoft.CodeDom.Providers.DotNetCompilerPlatform" version="1.0.3" targetFramework="net452" />
  <package id="Microsoft.Net.Compilers" version="1.3.2" targetFramework="net452" developmentDependency="true" />
</packages>