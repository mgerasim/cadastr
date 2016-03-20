using Cadastr.Common;
using Cadastr.Models;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cadastr.Repositories
{
      public class CadastrentityRepository : IRepository<Cadastrentity>
        {
            #region IRepository<Cadastrentity> Members

            void IRepository<Cadastrentity>.Save(Cadastrentity entity)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(entity);
                        transaction.Commit();
                    }
                }
            }

            void IRepository<Cadastrentity>.Update(Cadastrentity entity)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Update(entity);
                        transaction.Commit();
                    }
                }
            }

            void IRepository<Cadastrentity>.Delete(Cadastrentity entity)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(entity);
                        transaction.Commit();
                    }
                }
            }

            Cadastrentity IRepository<Cadastrentity>.GetById(int id)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.CreateCriteria<Cadastrentity>().Add(Restrictions.Eq("ID", id)).UniqueResult<Cadastrentity>();
            }

            IList<Cadastrentity> IRepository<Cadastrentity>.GetAll()
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    ICriteria criteria = session.CreateCriteria(typeof(Cadastrentity));
                    criteria.AddOrder(Order.Desc("ID"));
                    return criteria.List<Cadastrentity>();
                }
            }

            #endregion
        }
    
}