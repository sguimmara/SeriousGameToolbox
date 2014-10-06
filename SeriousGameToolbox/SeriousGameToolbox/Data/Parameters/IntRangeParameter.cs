﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriousGameToolbox.Data.Parameters
{
    public class IntRangeParameter : IntegerParameter
    {
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }

        public IntRangeParameter(string id, string caption, int min, int max, int value)
            : base(id, caption, value)
        {
            this.Minimum = min;
            this.Maximum = max;
        }

        public static implicit operator int(IntRangeParameter p)
        {
            return p.value;
        }

        public override Parameter Clone()
        {
            return new IntRangeParameter(this.Id, this.Caption, this.Minimum, this.Maximum, this.value);
        }
    }
}
