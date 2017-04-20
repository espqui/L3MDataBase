using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{

    public class AccesoDatos
    {
        public static int InsertarProveedor(PROVEEDOR dato)
        {
            L3MEntities contexto = new L3MEntities(); //Permite operar en la tabla proveedor
            try
            {
                contexto.PROVEEDORs.Add(dato); //se agrega el dato
                contexto.SaveChanges(); // se guardan los cambios
                return dato.Prov_Cedula; // se retorna el numero de cedula del proveedor 

            }
            catch (Exception ex) { return 0; }//se captura el error (en caso de que se genere uno)
            finally { contexto.Dispose(); }//se finaliza la insercion
        }//Fin de Insertar proveedor

        public static bool ModificarProveedor(PROVEEDOR dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var query = from ident in contexto.PROVEEDORs where ident.Prov_Cedula == dato.Prov_Cedula select ident;
                foreach (PROVEEDOR Prov in query)
                { //Se actualizan uno a uno los valores de la tabla proveedor
                    Prov.Prov_Cedula = dato.Prov_Cedula;
                    Prov.Nombre = dato.Nombre;
                    Prov.Apellido1 = dato.Apellido1;
                    Prov.Apellido1 = dato.Apellido2;
                    Prov.Telefono = dato.Telefono;
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de ModificarCliente

        public static bool EliminarProveedor(PROVEEDOR dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var deleteProv = from ident in contexto.PROVEEDORs where ident.Prov_Cedula == dato.Prov_Cedula select ident;
                foreach (var fila in deleteProv)
                {
                    contexto.PROVEEDORs.Remove(fila);
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de eliminar proveedor

        public static List<PROVEEDOR> RetonarListadoProveedores()
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var ListadoProv = from ident in contexto.PROVEEDORs select ident;
                List<PROVEEDOR> listadoProveedores = new List<PROVEEDOR>();
                foreach (var fila in ListadoProv)
                {
                    PROVEEDOR dato = new PROVEEDOR();
                    dato.Prov_Cedula = fila.Prov_Cedula;
                    dato.Nombre = fila.Nombre;
                    dato.Apellido1 = fila.Apellido1;
                    dato.Apellido2 = fila.Apellido2;
                    // dato.Telefono = fila.Telefono(); dice que no se peude invocar, será porque puede ser null ?
                }
                return listadoProveedores;
            }
            catch (Exception ex) { return null; }
        }//Fin de Listado Proveedores 

        public static PROVEEDOR RetornarProveedorPorCed(PROVEEDOR dato)
        {
            L3MEntities contexto = new L3MEntities();
            PROVEEDOR Prov = new PROVEEDOR();
            try
            {
                var proveedor = from provee in contexto.PROVEEDORs where provee.Prov_Cedula == dato.Prov_Cedula select provee;
                foreach (var fila in proveedor)
                {
                    Prov.Prov_Cedula = fila.Prov_Cedula;
                    Prov.Nombre = fila.Nombre;
                    Prov.Apellido1 = fila.Apellido1;
                    Prov.Apellido2 = fila.Apellido2;
                    Prov.Telefono = fila.Telefono;
                }
                return Prov;
            }
            catch (Exception ex) { return null; }
        }//Fin de Retornar Proveedor por Ced


        public static int InsertarSucursal(SUCURSAL dato)
        {
            L3MEntities contexto = new L3MEntities(); //Permite operar en la tabla Sucursal
            try
            {
                contexto.SUCURSALs.Add(dato); //se agrega el dato
                contexto.SaveChanges(); // se guardan los cambios
                return dato.Suc_ID; // se retorna el numero de Id de la sucursal
            }
            catch (Exception ex) { return 0; }//se captura el error (en caso de que se genere uno)
            finally { contexto.Dispose(); }//se finaliza la insercion
        }//Fin de Insertar Sucursal

        public static bool ModificarSucursal(SUCURSAL dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var query = from ident in contexto.SUCURSALs where ident.Suc_ID == dato.Suc_ID select ident;
                foreach (SUCURSAL Prov in query)
                { //Se actualizan uno a uno los valores de la tabla sucursal
                    Prov.Telefono = dato.Telefono;
                    Prov.Direccion = dato.Direccion;
                    Prov.Admin_Cedula = dato.Admin_Cedula;
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de ModificarSucursal

        public static bool EliminarSucursal(SUCURSAL dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var deleteSuc = from ident in contexto.SUCURSALs where ident.Suc_ID == dato.Suc_ID select ident;
                foreach (var fila in deleteSuc)
                {
                    contexto.SUCURSALs.Remove(fila);
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de eliminar Sucursal

        public static List<SUCURSAL> RetonarListadoSucursales()
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var ListadoSuc = from ident in contexto.SUCURSALs select ident;
                List<SUCURSAL> listadoProveedores = new List<SUCURSAL>();
                foreach (var fila in ListadoSuc)
                {
                    SUCURSAL dato = new SUCURSAL();
                    dato.Suc_ID = fila.Suc_ID;
                    dato.Telefono = fila.Telefono;
                    dato.Direccion = fila.Direccion;
                    // dato.Telefono = fila.Telefono(); dice que no se peude invocar, será porque puede ser null ?
                }
                return listadoProveedores;
            }
            catch (Exception ex) { return null; }
        }//Fin de Listado sucursales

        public static SUCURSAL RetornarSucursalesPorID(SUCURSAL dato)
        {
            L3MEntities contexto = new L3MEntities();
            SUCURSAL Prov = new SUCURSAL();
            try
            {
                var sucursal = from suc in contexto.SUCURSALs where suc.Suc_ID == dato.Suc_ID select suc;
                foreach (var fila in sucursal)
                {
                    Prov.Suc_ID = fila.Suc_ID;
                    Prov.Telefono = fila.Telefono;
                    Prov.Direccion = fila.Direccion;
                }
                return Prov;
            }
            catch (Exception ex) { return null; }
        }//Fin de Retornar Sucursal Por ID


        public static int InsertarProducto(PRODUCTO dato)
        {
            L3MEntities contexto = new L3MEntities(); //Permite operar en la tabla Producto
            try
            {
                contexto.PRODUCTOes.Add(dato); //se agrega el dato
                contexto.SaveChanges(); // se guardan los cambios
                return dato.Prod_Codigo; // se retorna el codigo del producto
            }
            catch (Exception ex) { return 0; }//se captura el error (en caso de que se genere uno)
            finally { contexto.Dispose(); }//se finaliza la insercion
        }//Fin de Insertar Producto

        public static bool ModificarProducto(PRODUCTO dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var query = from ident in contexto.PRODUCTOes where ident.Prod_Codigo == dato.Prod_Codigo select ident;
                foreach (PRODUCTO Prov in query)
                { //Se actualizan uno a uno los valores de la tabla Producto
                    Prov.Prod_Codigo= dato.Prod_Codigo;
                    Prov.Precio_Compra = dato.Precio_Compra;
                    Prov.Precio_Venta = dato.Precio_Venta;
                    Prov.Descripcion = dato.Descripcion;
                    Prov.Nombre = dato.Nombre;
                    Prov.Unid_Compradas = dato.Unid_Compradas;
                    Prov.Impuesto = dato.Impuesto;
                    Prov.Descuento = dato.Descuento;
                    Prov.Ganancia = dato.Ganancia;
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de ModificarProducto

        public static bool EliminarProducto(PRODUCTO dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var deleteProd = from ident in contexto.PRODUCTOes where ident.Prod_Codigo == dato.Prod_Codigo select ident;
                foreach (var fila in deleteProd)
                {
                    contexto.PRODUCTOes.Remove(fila);
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de eliminar Producto

        public static List<PRODUCTO> RetonarListadoProductos()
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var ListadoProd = from ident in contexto.PRODUCTOes select ident;
                List<PRODUCTO> listadoProductos = new List<PRODUCTO>();
                foreach (var fila in ListadoProd)
                {
                    PRODUCTO dato = new PRODUCTO();

                    dato.Prod_Codigo=fila.Prod_Codigo;
                    dato.Precio_Compra=fila.Precio_Compra;
                    dato.Precio_Venta=fila.Precio_Venta;
                    dato.Descripcion=fila.Descripcion;
                    dato.Nombre=fila.Nombre;
                    dato.Unid_Compradas=fila.Unid_Compradas;
                    dato.Impuesto=fila.Impuesto;
                    dato.Descuento=fila.Descuento;
                    dato.Ganancia=fila.Ganancia;
                   
                }
                return listadoProductos;
            }
            catch (Exception ex) { return null; }
        }//Fin de Listado Productos

        public static PRODUCTO RetornarProductosPorID(PRODUCTO dato)
        {
            L3MEntities contexto = new L3MEntities();
            PRODUCTO Prov = new PRODUCTO();
            try
            {
                var producto = from prod in contexto.PRODUCTOes where prod.Prod_Codigo == dato.Prod_Codigo select prod;
                foreach (var fila in producto)
                {
                    Prov.Prod_Codigo = fila.Prod_Codigo;
                    Prov.Precio_Compra = fila.Precio_Compra;
                    Prov.Precio_Venta = fila.Precio_Venta;
                    Prov.Descripcion = fila.Descripcion;
                    Prov.Nombre = fila.Nombre;
                    Prov.Unid_Compradas = fila.Unid_Compradas;
                    Prov.Impuesto = fila.Impuesto;
                    Prov.Descuento = fila.Descuento;
                    Prov.Ganancia = fila.Ganancia;
                }
                return Prov;
            }
            catch (Exception ex) { return null; }
        }//Fin de Retornar Producto Por ID


        public static List<CRONOGRAMA> InsertarCronograma(CRONOGRAMA dato)
        {
            L3MEntities contexto = new L3MEntities(); //Permite operar en la tabla Cronograma
            try
            {

                contexto.CRONOGRAMAs.Add(dato); //se agrega el dato
                contexto.SaveChanges(); // se guardan los cambios
                List<CRONOGRAMA> listadoCronograma = new List<CRONOGRAMA>();
                return listadoCronograma; // se retorna el codigo de la tabla cronograma
            }
            catch (Exception ex) { return null; }//se captura el error (en caso de que se genere uno)
            finally { contexto.Dispose(); }//se finaliza la insercion
        }//Fin de Insertar Cronograma

        public static bool ModificarCronograma(CRONOGRAMA dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var query = from ident in contexto.CRONOGRAMAs where ident.Suc_ID == dato.Suc_ID select ident;
                foreach (CRONOGRAMA Prov in query)
                { //Se actualizan uno a uno los valores de la tabla Cronograma
                    Prov.Suc_ID = dato.Suc_ID;
                    Prov.Trab_Cedula = dato.Trab_Cedula;
                    Prov.Fecha_inicio = dato.Fecha_inicio;
                    Prov.Fecha_Final = dato.Fecha_Final;
                    Prov.Horas_Laboradas = dato.Horas_Laboradas;
                    Prov.Horas_Extra = dato.Horas_Extra;
                    
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de ModificarCronograma

        public static bool EliminarCronograma(CRONOGRAMA dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var deleteCron = from ident in contexto. CRONOGRAMAs where (ident.Suc_ID == dato.Suc_ID && ident.Trab_Cedula==dato.Trab_Cedula ) select ident;
                foreach (var fila in deleteCron)
                {
                    contexto.CRONOGRAMAs.Remove(fila);
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de eliminar Cronograma

        public static List<CRONOGRAMA> RetonarListadoCronogramas()
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var ListadoCrono = from ident in contexto.CRONOGRAMAs select ident;
                List<CRONOGRAMA> listadoCronograma = new List<CRONOGRAMA>();
                foreach (var fila in listadoCronograma)
                {
                    CRONOGRAMA dato = new CRONOGRAMA();
                    dato.Trab_Cedula = fila.Trab_Cedula;
                    dato.Suc_ID= fila.Suc_ID;
                    dato.Fecha_inicio = fila.Fecha_inicio;
                    dato.Fecha_Final = fila.Fecha_Final;
                    dato.Horas_Laboradas = fila.Horas_Laboradas;
                    dato.Horas_Extra = fila.Horas_Extra;
                    
                }
                return listadoCronograma;
            }
            catch (Exception ex) { return null; }
        }//Fin de Listado Cronograma

        public static CRONOGRAMA RetornarCronogramaPorSuc_Id_CedTrab(CRONOGRAMA dato)
        {
            L3MEntities contexto = new L3MEntities();
            CRONOGRAMA Prov = new CRONOGRAMA();
            try
            {
                var crono = from cronograma in contexto.CRONOGRAMAs where (cronograma.Trab_Cedula == dato.Trab_Cedula && cronograma.Suc_ID == dato.Suc_ID) select cronograma;
                foreach (var fila in crono)
                {
                    Prov.Trab_Cedula = fila.Trab_Cedula;
                    Prov.Suc_ID = fila.Suc_ID;
                    Prov.Fecha_inicio = fila.Fecha_inicio;
                    Prov.Fecha_Final = fila.Fecha_Final;
                    Prov.Horas_Laboradas = fila.Horas_Laboradas;
                    Prov.Horas_Extra = fila.Horas_Extra;
                }
                return Prov;
            }
            catch (Exception ex) { return null; }
        }//Fin de Retornar Cronograma Por cedula del trabajador y ID de la sucursal




        public static List<ROL> InsertarRol(ROL dato)
        {
            L3MEntities contexto = new L3MEntities(); //Permite operar en la tabla ROL
            try
            {
                contexto.ROLs.Add(dato); //se agrega el dato
                contexto.SaveChanges(); // se guardan los cambios
                List<ROL> listadoRol = new List<ROL>();
                return listadoRol; // se retorna la llave primaria, que es la cedula del trabajador
            }
            catch (Exception ex) { return null; }//se captura el error (en caso de que se genere uno)
            finally { contexto.Dispose(); }//se finaliza la insercion
        }//Fin de Insertar Rol

        public static bool ModificarRol(ROL dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var query = from ident in contexto.ROLs where (ident.Trab_Cedula == dato.Trab_Cedula && ident.Rol1==dato.Rol1) select ident;
                foreach (ROL Prov in query)
                { //Se actualizan uno a uno los valores de la tabla Rol
                    Prov.Trab_Cedula = dato.Trab_Cedula;
                    Prov.Rol1 = dato.Rol1;
                    Prov.Descripcion = dato.Descripcion;
                    Prov.TRABAJADOR = dato.TRABAJADOR;
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de Modificar ROL

        public static bool EliminarRol(ROL dato)
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var deleteRol = from ident in contexto.ROLs where (ident.Trab_Cedula == dato.Trab_Cedula && ident.Rol1 == dato.Rol1) select ident;
                foreach (var fila in deleteRol)
                {
                    contexto.ROLs.Remove(fila);
                }
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }//Fin de eliminar Rol

        public static List<ROL> RetonarListadoRoles()
        {
            L3MEntities contexto = new L3MEntities();
            try
            {
                var ListadoRol = from ident in contexto.ROLs select ident;
                List<ROL> listadoRoles = new List<ROL>();
                foreach (var fila in ListadoRol)
                {
                    ROL dato = new ROL();
                    dato.Trab_Cedula = fila.Trab_Cedula;
                    dato.TRABAJADOR = fila.TRABAJADOR;
                    dato.Descripcion = fila.Descripcion;
                    dato.Rol1 = fila.Rol1;
                }
                return listadoRoles;
            }
            catch (Exception ex) { return null; }
        }//Fin de Listado Roles

        public static ROL RetornarRolesPorCedTrab(ROL dato)
        {
            L3MEntities contexto = new L3MEntities();
            ROL Prov = new ROL();
            try
            {
                var Rol = from rol in contexto.ROLs where (rol.Trab_Cedula == dato.Trab_Cedula && rol.Rol1== dato.Rol1) select rol;
                foreach (var fila in Rol)
                {
                    Prov.Trab_Cedula = fila.Trab_Cedula;
                    Prov.TRABAJADOR = fila.TRABAJADOR;
                    Prov.Descripcion = fila.Descripcion;
                    Prov.Rol1 = fila.Rol1;
                }
                return Prov;
            }
            catch (Exception ex) { return null; }
        }//Fin de Retornar Rol Por cedula del trabajador


    }




}

