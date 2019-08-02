using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TestConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = Factory<TestMe>.CreateInstance();
            var qqwe = Expression.Lambda(Expression.New(typeof(TestMe))).Compile();
            qqwe.DynamicInvoke();


            Console.ReadKey();
        }

    }

    public static class Factory<T>
       where T : new()
    {
        

        private static readonly Func<T> CreateInstanceFunc =
            Expression.Lambda<Func<T>>(Expression.New(typeof(T))).Compile();

        /// <summary>
        /// Creates an instance of type <typeparamref name="T"/> by calling it's parameterless constructor.
        /// </summary>
        /// <returns>An instance of type <typeparamref name="T"/>.</returns>
        public static T CreateInstance() => CreateInstanceFunc();

    }

    public class TestMe
    {
        public TestMe()
        {
            Console.WriteLine("Hey");
        }
    }
}
