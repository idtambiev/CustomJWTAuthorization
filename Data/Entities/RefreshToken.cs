﻿using Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; }
    }
}
