using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class BaseManager<T> : lBaseManager<T> where T : class
    {
        public void Delete(T entidade)
        {
            using (ISession session = SessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao excluir entidade: " + ex.Message);
                    }
                }
            }
        }
        public IList<T> Query()
        {
            using (ISession session = SessionFactory.StartSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }

        public T ReturnById(int id)
        {
            using (ISession session = SessionFactory.StartSession())
            {
                return session.Get<T>(id);
            }
        }
        public T ReturnById(string id)
        {
            using (ISession session = SessionFactory.StartSession())
            {
                return session.Get<T>(id);
            }
        }

        public void Save(T entidade)
        {

            using (ISession session = SessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao inserir entidade: " + ex.Message);
                    }
                }
            }
        }

        public void SaveOrUpdate(T entidade)
        {
            using (ISession session = SessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(entidade);
                        session.Flush();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao inserir entidade: " + ex.Message);
                    }
                }
            }
        }

        public void Update(T entidade)
        {
            using (ISession session = SessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao atualizar  entidade: " + ex.Message);
                    }
                }
            }
        }
    }
}
