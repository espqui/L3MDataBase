using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace LogicaNegocio
{
    public class LogicaNegocio
    {
        public static int InsertarProveedor(PROVEEDOR dato)
        {  
            return AccesoDatos.AccesoDatos.InsertarProveedor(dato);
        }

        public static bool ModificarProveedor(PROVEEDOR dato)
        {
            return AccesoDatos.AccesoDatos.ModificarProveedor(dato);
        }

        public static bool EliminarProveedor(PROVEEDOR dato)
        {
            return AccesoDatos.AccesoDatos.EliminarProveedor(dato);
        }

        public static List<PROVEEDOR> RetonarListadoProveedores()
        {
            return AccesoDatos.AccesoDatos.RetonarListadoProveedores();
        }

        public static PROVEEDOR RetornarProveedorPorCed(PROVEEDOR dato)
        { 
            return AccesoDatos.AccesoDatos.RetornarProveedorPorCed(dato);
        }



        public static int InsertarSucursal(SUCURSAL dato)
        {
            return AccesoDatos.AccesoDatos.InsertarSucursal(dato);
        }

        public static bool ModificarSucursal(SUCURSAL dato)
        {
            return AccesoDatos.AccesoDatos.ModificarSucursal(dato);
        }

        public static bool EliminarSucursal(SUCURSAL dato)
        {
            return AccesoDatos.AccesoDatos.EliminarSucursal(dato);
        }

        public static List<SUCURSAL> RetonarListadoSucursal()
        {
            return AccesoDatos.AccesoDatos.RetonarListadoSucursales();
        }

        public static SUCURSAL RetornarSucursalesPorId(SUCURSAL dato)
        {
            return AccesoDatos.AccesoDatos.RetornarSucursalesPorID(dato);
        }


        public static int InsertarProducto(PRODUCTO dato)
        {
            return AccesoDatos.AccesoDatos.InsertarProducto(dato);
        }

        public static bool ModificarProducto(PRODUCTO dato)
        {
            return AccesoDatos.AccesoDatos.ModificarProducto(dato);
        }

        public static bool EliminarProducto(PRODUCTO dato)
        {
            return AccesoDatos.AccesoDatos.EliminarProducto(dato);
        }

        public static List<PRODUCTO> RetonarListadoProductos()
        {
            return AccesoDatos.AccesoDatos.RetonarListadoProductos();
        }

        public static PRODUCTO RetornarProductosPorId(PRODUCTO dato)
        {
            return AccesoDatos.AccesoDatos.RetornarProductosPorID(dato);
        }

        public static List<CRONOGRAMA> InsertarCronograma(CRONOGRAMA dato)
        {
            return AccesoDatos.AccesoDatos.InsertarCronograma(dato);
        }

        public static bool ModificarCronograma(CRONOGRAMA dato)
        {
            return AccesoDatos.AccesoDatos.ModificarCronograma(dato);
        }
        public static bool EliminarCronograma(CRONOGRAMA dato)
        {
            return AccesoDatos.AccesoDatos.EliminarCronograma(dato);
        }

        public static List<CRONOGRAMA> RetonarListadoCronogramas()
        {
            return AccesoDatos.AccesoDatos.RetonarListadoCronogramas();
        }

        public static CRONOGRAMA RetornarCronogramaPorSuc_Id_CedTrab(CRONOGRAMA dato)
        {
            return AccesoDatos.AccesoDatos.RetornarCronogramaPorSuc_Id_CedTrab(dato);
        }


        public static List<ROL> InsertarRol(ROL dato)
        {
            return AccesoDatos.AccesoDatos.InsertarRol(dato);
        }

        public static bool ModificarRol(ROL dato)
        {
            return AccesoDatos.AccesoDatos.ModificarRol (dato);
        }

        public static bool EliminarRol(ROL dato)
        {
            return AccesoDatos.AccesoDatos.EliminarRol(dato);
        }

        public static List<ROL> RetonarListadoRoles()
        {
            return AccesoDatos.AccesoDatos.RetonarListadoRoles();
        }

        public static ROL RetornarRolesPorCedTrabajador(ROL dato)
        {
            return AccesoDatos.AccesoDatos.RetornarRolesPorCedTrab(dato);
        }



    }
}
