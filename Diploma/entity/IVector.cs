﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma.entity
{
    public interface IVector
    {
        void print();
        int length { get; }
        decimal this[int index]
        {
            get;
            set;
        }

    }
}
