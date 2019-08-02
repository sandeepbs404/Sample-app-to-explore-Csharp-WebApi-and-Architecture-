using System;
using System.Linq.Expressions;

namespace ObjectMapper
{
    public class Factory<T> where T : new()
    {
        private static readonly Func<T> CreateInstanceFunc =
           Expression.Lambda<Func<T>>(Expression.New(typeof(T))).Compile();

        public static T CreateInstance() => CreateInstanceFunc();
    }
}
