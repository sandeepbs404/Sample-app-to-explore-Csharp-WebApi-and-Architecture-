using System;
using System.Collections.Generic;

namespace ObjectMapper.ManualMapper
{
    public abstract class BaseMapper<TSource, TDestination> : IMap<TSource, TDestination>
    {
        public abstract TSource Create(TDestination dto);
        public abstract TDestination Create(TSource model);
        
        #region interface implementation

        public virtual TDestination ModelToDto(TSource source)
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            return Create(source);
        }
        public virtual TSource DtoToModel(TDestination destination) 
        {
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }
            return Create(destination);
        }

        public IEnumerable<TDestination> ModelsToDtos(IEnumerable<TSource> destinations)
        {
            if(destinations == null)
            {
                throw new ArgumentNullException();
            }
            var list = new List<TDestination>();
            foreach (var item in destinations)
            {
                var result = Create(item);
                list.Add(result);
            }
            return list;
        }

        #endregion
    }
}
