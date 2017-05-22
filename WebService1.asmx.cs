using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;

using Logica;



namespace Servicios
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        LogicaVentas logica = new LogicaVentas();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        [WebMethod]
        public DOCENTE BuscarDocente(String codigoNombre)
        {
            try
            {

                return logica.BuscarDocente(codigoNombre);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [WebMethod]
        public List<DOCENTE> seleccionarDocente()
        {
            try
            {
                return logica.seleccionarDocente();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [WebMethod]
        public List<DOCENTE> ListaDocenteXCodigo(string codigo)
        {
            try
            {
                return logica.ListaDocenteXCodigo(codigo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [WebMethod]
        public string ingresarDocente(DOCENTE nuevoDocente)
        {
            try
            {
                return logica.ingresarDocente(nuevoDocente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        [WebMethod]
        public bool eliminarDocente(String codigoDocente)
        {
            try
            {
                return logica.eliminarDocente(codigoDocente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [WebMethod]
        public bool actualizarDocente(DOCENTE docenteActualizar)
        {
            try
            {
                return logica.actualizarDocente(docenteActualizar);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
