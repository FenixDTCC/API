using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuantoDemoraApi.Models.Enums;

namespace QuantoDemoraApi.Models
{
    public class UnidadeEspecialidade
    {
        public Hospital Hospital { get; set; }
        public int IdHospital { get; set; }
        public Unidade Unidade { get; set; }
        public int IdUnidade { get; set; }
        public Especialidade Especialidade { get; set; }
        public int IdEspecialidade { get; set; }
        public EspecialidadeEnum EspecialidadeEnum { get; set; }
    }
}