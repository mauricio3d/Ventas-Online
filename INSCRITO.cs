//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class INSCRITO
    {
        public INSCRITO()
        {
            this.DETALLECOMPRA = new HashSet<DETALLECOMPRA>();
        }
    
        public string CODIGOINSCRITO { get; set; }
        public string NOMBRESINSCRITO { get; set; }
        public string APELLIDOSINSCRITO { get; set; }
        public string CEDULAINSCRITO { get; set; }
        public string FECHANACIMIENTOINSCRITO { get; set; }
        public string DOMICILIOINSCRITO { get; set; }

        [XmlIgnore]
        public virtual ICollection<DETALLECOMPRA> DETALLECOMPRA { get; set; }
    }
}
