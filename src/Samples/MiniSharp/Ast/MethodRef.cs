﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBF.Compilers.Scanners;

namespace VBF.MiniSharp.Ast
{
    public class MethodRef
    {
        public Lexeme MethodName { get; set; }
        public Method MethodInfo { get; set; }

        public MethodRef(Lexeme name)
        {
            MethodName = name;
        }
    }
}
