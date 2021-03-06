﻿using Meta.ORM.Expressions;

namespace Meta.ORM.Query
{
    public class CalculatedProperty : ICalculatedProperty
    {
        public string Name { get; set; }

        public MetaExpression Expression { get; set; }
    }

    public class CalculatedProperty<T> : ICalculatedProperty<T>
    {
        public string Name { get; set; }

        public T Value  => default(T);

        public MetaExpression<T> Expression { get; set; }
    }
}