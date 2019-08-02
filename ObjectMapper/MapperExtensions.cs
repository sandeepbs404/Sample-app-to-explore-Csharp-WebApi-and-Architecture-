using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMapper
{
    public static class MapperExtensions
    {
        public static TDestination Map<TSource, TDestination>(
            this IMapper<TSource, TDestination> translator,
            TSource source)
            where TDestination : new()
        {
            if (translator == null)
            {
                throw new ArgumentNullException(nameof(translator));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = Factory<TDestination>.CreateInstance();
            translator.Map(source, destination);
            return destination;
        }
    }
}
