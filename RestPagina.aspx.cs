using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace JsonRest
{
    public partial class RestPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string url = String.Format("http://localhost:61224/api/CURSO");
            WebClient wcCurso = new WebClient();
            string respuesta = wcCurso.DownloadString(new Uri(url));
            List<ClaseCurso> datosCurso = JsonConvert.DeserializeObject<List<ClaseCurso>>(respuesta);
            GridView1.DataSource = datosCurso;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string url = String.Format("http://localhost:61224/api/CURSO/{0}", TextBox1.Text);
            WebClient wcCurso = new WebClient();
            string respuesta = wcCurso.DownloadString(new Uri(url));
            ClaseCurso datosCurso = JsonConvert.DeserializeObject<ClaseCurso>(respuesta);
            List<ClaseCurso> cargaCurso = new List<ClaseCurso>();
            cargaCurso.Add(datosCurso);
            GridView1.DataSource = cargaCurso;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string url = String.Format("http://localhost:61224/api/CURSO/{0}", TextBox1.Text);
            string verbo = "DELETE";
            WebClient wcCurso = new WebClient();
            wcCurso.Headers.Add("Content-Type", "aplication/json");
            string respuesta = wcCurso.UploadString(url, verbo, "");
        }
    }
}