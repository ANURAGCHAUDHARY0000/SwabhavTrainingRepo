﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal interface IWorkable
    {
        void StartWork();

        void StopWork();
    }
}