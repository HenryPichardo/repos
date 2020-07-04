using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SED.Models
{
    public class DocenteBLL
    {
        public int Id_Docente { get; set; }
        public string CodigoEmpleado { get; set; }
        public string CorreoUniversitario { get; set; }
        public List<DocenteBLL> GetListaDocentes()
        {
            using (var db = new SEDEntities())
            {
                List<DocenteBLL> ListaDocentes = (from Docente in db.Docente
                                                  select new DocenteBLL
                                                  {
                                                      Id_Docente = Docente.Id_Docente,
                                                           CodigoEmpleado = Docente.CodigoEmpleado,
                                                           CorreoUniversitario = Docente.CorreoUniversitario
                                                       }).ToList();
                return ListaDocentes;
            }
        }
    }
}