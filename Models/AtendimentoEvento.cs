using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuantoDemoraApi.Models.Enums;

namespace QuantoDemoraApi.Models
{
    public class AtendimentoEvento
    {
        public Atendimento Atendimento { get; set; }
        public int IdAtendimento { get; set; }
        public Evento Evento { get; set; }
        public int IdEvento { get; set; }
        public EventoEnum EventoEnum { get; set; }
        public char AcAtendimento { get; set; }
        public DateTime MtAtendimento { get; set; }
    }
}