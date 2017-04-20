using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioWCF
    {
        [OperationContract]
        int InsertarProveedor(PROVEEDOR dato);

        [OperationContract]
        bool ModificarProveedor(PROVEEDOR dato);

        [OperationContract]
        bool EliminarProveedor(PROVEEDOR dato);

        [OperationContract]
        List<PROVEEDOR> RetonarListadoProveedores(); 

        [OperationContract]
        PROVEEDOR RetornarProveedorPorCed(PROVEEDOR dato);
        
    }
}
