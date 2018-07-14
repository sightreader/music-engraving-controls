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

using Manufaktura.Orm.Portable.Builder;
using Manufaktura.Orm.Portable.SortModes;
using Manufaktura.Orm.Portable.SpecialColumns;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Manufaktura.Orm.Builder
{
    public abstract class DialectProvider : IDisposable
    {
        public DbConnection Connection { get; protected set; }
        public bool IsDisposed { get; private set; }
       
        public abstract DbDataAdapter CreateDataAdapter();

        protected DialectProvider(DbConnection connection)
        {
            Connection = connection;
        }

        public abstract DbCommand GetSelectCommand<TEntity>(QueryBuilder query);
        public abstract DbCommand GetInsertCommand(object entity);
        public abstract DbCommand GetUpdateCommand(object entity);
        public abstract DbCommand GetDeleteCommand(object id);
        public abstract DbCommand GetUpdateSchemaCommand(Type entityType);


        public void Dispose()
        {
            if (Connection == null) return;
            if (IsDisposed) return;
            
            Connection.Close();
            Connection.Dispose();
            IsDisposed = true;
        }
    }
}