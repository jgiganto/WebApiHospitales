using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiHospitales.Models
{
    public class ModeloHospital
    {
        ContextoHospital contexto;
        public ModeloHospital()
        {
            contexto = new ContextoHospital();
        }

        public List<HOSPITAL> GetHospital()
        {
            var consulta = from datos in contexto.HOSPITAL
                           select datos;
            return consulta.ToList();
        }

    }
}