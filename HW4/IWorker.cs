﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal interface IWorker
    {
        IWorker SetNextWorker(IWorker worker);

        string DoWork(string request);
    }
}
