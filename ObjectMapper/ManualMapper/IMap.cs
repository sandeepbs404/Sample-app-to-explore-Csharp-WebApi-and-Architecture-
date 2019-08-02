using System.Collections.Generic;

namespace ObjectMapper.ManualMapper
{
    public interface IMap<TSource, TDestination>
    {
        //void Map(TSource source, TDestination destination);
        TDestination ModelToDto(TSource destination);
        IEnumerable<TDestination> ModelsToDtos(IEnumerable<TSource> destinations);
        TSource DtoToModel(TDestination destination);
    }
}
