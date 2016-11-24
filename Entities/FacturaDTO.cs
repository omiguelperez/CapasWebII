﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FacturaDTO
    {
        public FacturaDTO()
        {
            ItemFacturas = new List<ItemFacturaDTO>();
        }

        public int FacturasId { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroFactura { get; set; }

        //public int ProgramacionPagoId { get; set; }
        //public virtual ProgramacionPago ProgranacionPago { get; set; }

        public int ClienteId { get; set; }
        //public virtual ClienteDTO Cliente { get; set; }

        public List<ItemFacturaDTO> ItemFacturas { get; set; }
    }
}
