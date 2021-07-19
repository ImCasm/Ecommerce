using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Common.Specification
{
    public class Specification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; }

        public Specification()
        {
            Includes = new List<Expression<Func<T, object>>>();
        }

        public Specification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
            Includes = new List<Expression<Func<T, object>>>();
        }

        public void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
