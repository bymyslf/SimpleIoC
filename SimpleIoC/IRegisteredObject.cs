﻿using System;

namespace SimpleIoC
{
    public interface IRegisteredObject
    {
        Type TypeToResolve { get; }
        Type ConcreteType { get; }
        object Instance { get; }
        LifeCycle LifeCycle { get; }
        void CreateInstance(params object[] args);
    }
}
