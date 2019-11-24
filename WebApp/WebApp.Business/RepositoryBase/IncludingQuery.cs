using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebApp.Business.RepositoryBase
{
    public class IncludingQuery<T>
    {
        public IncludingQuery(IEnumerable<Expression<Func<T, object>>> columns)
        {
            Columns = columns ?? throw new ArgumentNullException(nameof(columns));
        }

        public IEnumerable<Expression<Func<T, object>>> Columns { get; }
    }
}