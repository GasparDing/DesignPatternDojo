﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Behavioral.Strategy
{
    public class AttackWithFoot : IAttack
    {
        public int PerformAttack()
        {
            return 1;
        }
    }
}
