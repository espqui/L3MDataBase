using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
namespace Sitio
{
    public partial class WebFormPM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReferenciaServicios.ServicioWCFClient servicio = new ReferenciaServicios.ServicioWCFClient();
                servicio = new ReferenciaServicios.ServicioWCFClient();
                try
                {
                    GridView1.DataSource = servicio.RetonarListadoProveedores();
                    GridView1.DataBind(); 
                }catch (Exception ex) { throw ex; }
                finally
                {
                    var checkClosedState = System.ServiceModel.CommunicationState.Closed | System.ServiceModel.CommunicationState.Closing;
                    if (servicio.State == System.ServiceModel.CommunicationState.Faulted)
                        servicio.Abort();
                    else if (servicio.State == checkClosedState)
                        servicio.Close();
                    else
                        servicio.Close();
                }  //Cierra el finally     
            }//Cierra el if

        }//Cierra el Page_Load

        protected void Grid_View1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GridView1.SelectedIndex;
            string ProvCedula = GridView1.DataKeys[index].Value.ToString();
            Session["Proveedor_Cedula"] = ProvCedula;
            ReferenciaServicios.ServicioWCFClient servicio = new ReferenciaServicios.ServicioWCFClient();
            servicio = new ReferenciaServicios.ServicioWCFClient();
            try
            {
                PROVEEDOR dato = new PROVEEDOR();
                dato.Prov_Cedula = Convert.ToInt32(ProvCedula);
                dato = servicio.RetornarProveedorPorCed(dato);
                txNombre.Text = dato.Nombre;
                txApellido1.Text = dato.Apellido1;
                txApellido2.Text = dato.Apellido2;
                txcedula.Text = Convert.ToString(dato.Prov_Cedula);
                txTelefono.Text = Convert.ToString(dato.Telefono);
                
            } catch (Exception ex) { throw ex; }
            finally
            {
                var checkClosedState = System.ServiceModel.CommunicationState.Closed | System.ServiceModel.CommunicationState.Closing;
                if (servicio.State == System.ServiceModel.CommunicationState.Faulted)
                    servicio.Abort();
                else if (servicio.State == checkClosedState)
                    servicio.Close();
                else
                    servicio.Close();
            }//Cierra el finally
        }//Cierra el Grid_View1_SelectedIndexChanged

        protected void Button1_Click(object sender, EventArgs e)
        {
            string accion = DropDownList1.SelectedValue.ToString();
            ReferenciaServicios.ServicioWCFClient servicio = new ReferenciaServicios.ServicioWCFClient();
            servicio = new ReferenciaServicios.ServicioWCFClient();
            PROVEEDOR dato = new PROVEEDOR();
            try
            {
                if (accion == "Modificar")
                {
                    if (txcedula.Text != null)
                    {
                        dato.Prov_Cedula = Convert.ToInt32(txcedula.Text);
                        dato.Nombre = txNombre.Text;
                        dato.Apellido1 = txApellido1.Text;
                        dato.Apellido2 = txApellido2.Text;
                        dato.Telefono = Convert.ToInt32(txTelefono.Text);
                        servicio.ModificarProveedor(dato);
                        lbExito.Visible = true;
                        lbError.Visible = false;
                        lbExito.Text = "El registro se modificó";
                    }
                    else
                    {
                        lbExito.Visible = false;
                        lbError.Visible = true;
                        lbError.Text = "No se modificó";
                    }

                }//Cierra if de modificar 
                if (accion == "Eliminar")
                {
                    if (txcedula.Text != null)
                    {
                        dato.Prov_Cedula = Convert.ToInt32(txcedula.Text);
                        servicio.EliminarProveedor(dato);
                        lbExito.Visible = true;
                        lbError.Visible = false;
                        lbExito.Text = "El Registro se elimino correctamente";
                    }
                    else
                    {
                        lbExito.Visible = false;
                        lbError.Visible = true;
                        lbError.Text = "No se ha podido eliminar el registro";
                    }
                }//Cierrra if de Eliminar 
                if (accion == "Insertar")
                {
                    dato.Prov_Cedula = Convert.ToInt32(txcedula.Text);
                    dato.Nombre = txNombre.Text;
                    dato.Apellido1 = txApellido1.Text;
                    dato.Apellido2 = txApellido2.Text;
                    dato.Telefono = Convert.ToInt32(txTelefono.Text);
                    servicio.InsertarProveedor(dato);
                    lbExito.Visible = true;
                    lbError.Visible = false;
                    lbExito.Text = "El registro de inserto correctamente";
                }//Cierra if insertar 
                if (accion == "Seleccione")
                {
                    lbExito.Visible = false;
                    lbError.Visible = true;
                    lbError.Text = "Debe seleccionar una accion para continuar";
                    
                }
                GridView1.DataSource = servicio.RetonarListadoProveedores();
                GridView1.DataBind();
                Session["Proveedor_Cedula"] = null;
                txNombre.Text = "";
                txApellido1.Text = "";
                txApellido2.Text = "";
                DropDownList1.SelectedValue = "Seleccione";

            }
            catch (Exception ex) { throw ex; }
            finally
            {
                var checkClosedState = System.ServiceModel.CommunicationState.Closed | System.ServiceModel.CommunicationState.Closing;
                if (servicio.State == System.ServiceModel.CommunicationState.Faulted)
                    servicio.Abort();
                else if (servicio.State == checkClosedState)
                    servicio.Close();
                else
                    servicio.Close();
            }//Cierra el finally 
        }//Cierra el Button1_Click
    }//Cierra la clase
}//Cierra el namespace 


