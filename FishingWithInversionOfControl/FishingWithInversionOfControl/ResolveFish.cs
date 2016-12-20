using System;
using System.Collections.Generic;
using System.Linq;

namespace FishingWithInversionOfControl
{
    public class ResolveFish
    {
        private readonly Dictionary<Type,Type> _dependencyMap = new Dictionary<Type, Type>();
        
        public T ResolveFishCaught<T>()
        {
            return (T) Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            Type resolvedType;
            try
            {
                resolvedType = _dependencyMap[typeToResolve];
            }
            catch
            {
                throw new Exception($"Type {typeToResolve.FullName} not found");
            }

            var firstConstructor = resolvedType.GetConstructors().First();
            var constructorParamaters = firstConstructor.GetParameters();
            if (constructorParamaters.Length == 0)
                return Activator.CreateInstance(resolvedType);
            IList<object> parameters = new List<object>();
            foreach (var parameterToResolve in constructorParamaters)
            {
                parameters.Add(Resolve(parameterToResolve.ParameterType));
            }

            return firstConstructor.Invoke(parameters.ToArray());
        }

        public void Register<TFrom, TTo>()
        {
            _dependencyMap.Add(typeof(TFrom), typeof(TTo));
        }
    }
}