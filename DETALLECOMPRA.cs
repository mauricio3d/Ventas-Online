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

    public partial class DETALLECOMPRA
    {
        public string CODIGOINSCRITO { get; set; }
        public string CODIGOCURSO { get; set; }
        public string FORMAPAGO { get; set; }
        public double TOTALPAGO { get; set; }
        public string CODIGODETALLECOMPRA { get; set; }

        [XmlIgnore]
        public virtual CURSO CURSO { get; set; }
        [XmlIgnore]
        public virtual INSCRITO INSCRITO { get; set; }
    }
}
