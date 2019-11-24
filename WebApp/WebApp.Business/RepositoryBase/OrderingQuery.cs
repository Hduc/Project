using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebApp.Business.RepositoryBase
{
    public class OrderingQuery<T>
    {
        public OrderingQuery(IDictionary<Expression<Func<T, object>>, OrderDirection> columns)
        {
            Columns = columns ?? throw new ArgumentNullException(nameof(columns));
        }

        public IDictionary<Expression<Func<T, object>>, OrderDirection> Columns { get; }
    }
}