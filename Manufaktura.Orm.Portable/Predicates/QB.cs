/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Portable.Predicates
{
    public static class QB
    {
        public static LikePredicate Like(string parameterName, object parameterValue)
        {
            return new LikePredicate(parameterName, parameterValue);
        }

        public static EqualsPredicate Eq(string parameterName, object parameterValue)
        {
            return new EqualsPredicate(parameterName, parameterValue);
        }

        public static NotEqualsPredicate NEq(string parameterName, object parameterValue)
        {
            return new NotEqualsPredicate(parameterName, parameterValue);
        }

        public static GreaterThanPredicate Gr(string parameterName, object parameterValue)
        {
            return new GreaterThanPredicate(parameterName, parameterValue);
        }

        public static LesserThanPredicate Le(string parameterName, object parameterValue)
        {
            return new LesserThanPredicate(parameterName, parameterValue);
        }

        public static GreaterThanOrEqualPredicate GEq(string parameterName, object parameterValue)
        {
            return new GreaterThanOrEqualPredicate(parameterName, parameterValue);
        }

        public static LesserThanOrEqualPredicate LEq(string parameterName, object parameterValue)
        {
            return new LesserThanOrEqualPredicate(parameterName, parameterValue);
        }

        public static OrPredicate Or(params SqlPredicate[] predicates)
        {
            return new OrPredicate(predicates);
        }

        public static AndPredicate And(params SqlPredicate[] predicates)
        {
            return new AndPredicate(predicates);
        }

        
    }
}
