using Manufaktura.Orm.SortModes;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Orm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm
{
    public abstract class Repository
    {
        public abstract TEntity Load<TEntity>(object id) where TEntity : Entity, new();
        public abstract List<TEntity> LoadAll<TEntity>(int offset, int limit) where TEntity : Entity, new();
        public List<TEntity> LoadAll<TEntity>() where TEntity : Entity, new()
        {
            return LoadAll<TEntity>(0, 0);
        }
        public abstract List<TEntity> LoadAllByQuery<TEntity>(int offset, int limit, SqlPredicate predicate, SpecialColumn[] specialColumns, SortMode[] sortModes) where TEntity : Entity, new();
        public List<TEntity> LoadAllByQuery<TEntity>(SqlPredicate predicate, SpecialColumn[] specialColumns, SortMode[] sortModes) where TEntity : Entity, new()
        {
            return LoadAllByQuery<TEntity>(0, 0, predicate, specialColumns, sortModes);
        }
        public abstract Entity Save(Entity entity);
    }
}