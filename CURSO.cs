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
    
    public partial class CURSO
    {
        public CURSO()
        {
            this.DETALLECOMPRA = new List<DETALLECOMPRA>();
        }
    
        public string CODIGOCURSO { get; set; }
        public string CODIGODOCENTE { get; set; }
        public string NOMBRECURSO { get; set; }
        public string DESCRIPCIONCURSO { get; set; }
        public string TIPOCURSO { get; set; }
        public double COSTOCURSO { get; set; }
        public string DURACIONCURSO { get; set; }
        public string FECHAINICIOCURSO { get; set; }
        public string FECHAFINCURSO { get; set; }

        [XmlIgnore]
        public virtual DOCENTE DOCENTE { get; set; }
        [XmlIgnore]
        public virtual List<DETALLECOMPRA> DETALLECOMPRA { get; set; }
    }
}
