﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKConnect
{
    public class DadosMemoryDateTime : IDadosMemory
    {
        public DateTime DataAlteracao { get; set; }

        public DateTime datahora { get; set; }
    }
}