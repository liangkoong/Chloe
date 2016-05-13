﻿using Chloe.Utility;
using System.Reflection;

namespace Chloe.DbExpressions
{
    public class DbGreaterThanExpression : DbBinaryExpression
    {
        internal DbGreaterThanExpression(DbExpression left, DbExpression right)
            : this(left, right, null)
        {

        }
        internal DbGreaterThanExpression(DbExpression left, DbExpression right, MethodInfo method)
            : base(DbExpressionType.GreaterThan, UtilConstants.TypeOfBoolean, left, right, method)
        {

        }

        public override T Accept<T>(DbExpressionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}