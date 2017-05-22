using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace JsonRest
{
    public class ClaseCurso
    {
        public string CODIGOCURSO { get; set; }
        public string CODIGODOCENTE { get; set; }
        public string NOMBRECURSO { get; set; }
        public string DESCRIPCIONCURSO { get; set; }
        public string TIPOCURSO { get; set; }
        public double COSTOCURSO { get; set; }
        public string DURACIONCURSO { get; set; }
        public string FECHAINICIOCURSO { get; set; }
        public string FECHAFINCURSO { get; set; }

        public ClaseCurso()
        { }

        public ClaseCurso(string json)
        {
            JObject joCurso = JObject.Parse(json);

            CODIGOCURSO = (string)joCurso["CODIGOCURSO"];
            CODIGODOCENTE = (string)joCurso["CODIGODOCENTE"];
            NOMBRECURSO = (string)joCurso["NOMBRECURSO"];
            DESCRIPCIONCURSO = (string)joCurso["DESCRIPCIONCURSO"];
            TIPOCURSO = (string)joCurso["TIPOCURSO"];
            COSTOCURSO = (double)joCurso["COSTOCURSO"];
            DURACIONCURSO = (string)joCurso["DURACIONCURSO"];
            FECHAINICIOCURSO = (string)joCurso["FECHAINICIOCURSO"];
            FECHAFINCURSO = (string)joCurso["FECHAFINCURSO"];



        }

    }
}