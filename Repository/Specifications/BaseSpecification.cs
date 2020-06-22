using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>

    {
        public BaseSpecification()
        {
        }
        public System.Linq.Expressions.Expression<Func<T, bool>> Criteria { get; }
        public BaseSpecification(Expression<Func<T,bool>> criteria)
        {
            Criteria = criteria;    
        }

     

        public List<System.Linq.Expressions.Expression<Func<T, object>>> Includes { get; } =
            new List<Expression<Func<T, object>>>();


        protected void AddInclude(Expression<Func<T,object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
