﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSolutionOfDifferentialEquations.OpenAndSaveFile
{
    internal interface IDialogService
    {
        string? FilePath { get; set; } 
        bool OpenFileDialog(); 
        bool SaveFileDialog();
    }
}
