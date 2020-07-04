using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SED.Models
{
    public class EvaluadorBLL
    {
        public int Id_Evaluador { get; set; }
        public string TipoEvaluador { get; set; }
        public string CorreoUniversitario { get; set; }

        public List<EvaluadorBLL> GetListaEvaluadores()
        {
            using (var db = new SEDEntities())
            {
                List<EvaluadorBLL> ListaEvaluadores = (from Evaluador in db.Evaluador
                                                       select new EvaluadorBLL
                                                       {
                                                           Id_Evaluador = Evaluador.Id_Evaluador,
                                                           TipoEvaluador = Evaluador.TipoEvaluador,
                                                           CorreoUniversitario = Evaluador.CorreoUniversitario
                                                       }).ToList();
                return ListaEvaluadores;
            }
        }
    }

     
}