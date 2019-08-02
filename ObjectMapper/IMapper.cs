namespace ObjectMapper
{
    //https://github.com/Dotnet-Boxed/Framework
    public interface IMapper<TSource, TDestination>
    {
        void Map(TSource source, TDestination destination);
    }
}
