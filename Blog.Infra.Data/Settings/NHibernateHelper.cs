using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using Blog.Domain.Entities;

namespace Blog.Infra.Data.Settings
{
  public class NHibernateHelper
  {
    public static ISession OpenSession()
    {
      ISessionFactory sessionFactory = Fluently.Configure()
          .Database(MsSqlConfiguration.MsSql2008
            .ConnectionString(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\data\Blog\Samples\FluentNhibernateMVC\FluentNhibernateMVC\FluentNhibernateMVC\App_Data\FNhibernateDemo.mdf;Integrated Security=True")
                        .ShowSql()
          )
         .Mappings(m =>
                    m.FluentMappings
                        .AddFromAssemblyOf<Usuario>())
          .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                          .Create(false, false))
          .BuildSessionFactory();
      return sessionFactory.OpenSession();
    }
  }
}
