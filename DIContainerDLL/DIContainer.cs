﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainerDLL
{    
    public class DIContainer
    {
        public DIContainer()
        {
            RegisterTypes = new Dictionary<Type, Type>();
        }
        public IDictionary<Type, Type> RegisterTypes { get; private set; }

        public void Register<T1, T2>()
        {
            RegisterTypes.Add(typeof(T1),typeof(T2));
        }
    }
}
