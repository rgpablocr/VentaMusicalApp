﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace VentaMusical.Model
{
    public class CancionAgregar
    {
        [Display(Name = "Código Género")]
        public int CodigoGenero { get; set; }

        [Display(Name = "Nombre Canción")]
        public string NombreCancion { get; set; }

        [Display(Name = "Precio Canción")]
        public decimal Precio { get; set; }
        public string Portada { get; set; }

        [Display(Name = "Portada")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase Archivo { get; set; }

    }
}
