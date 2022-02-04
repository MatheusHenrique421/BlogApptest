using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Blog.Infra.Data.Settings;
using Blog.Domain.Entities;
using System.Linq;

using NHibernate;
using System;

namespace Blog.Mvc.Controllers
{
  public class UsuarioController : Controller
  {
    private readonly NHibernate.ISession _session;
    public UsuarioController(NHibernate.ISession session)
    {
      _session = session;
    }
    // GET: UsuarioController
    public ActionResult Index()
    {
      using (NHibernate.ISession session = NHibernateHelper.OpenSession())
      {
        var usuario = session.Query<Usuario>().ToList();
        return View(usuario);
      }
    }

    // GET: UsuarioController/Details/5
    public ActionResult Details(int id)
    {
      using (NHibernate.ISession session = NHibernateHelper.OpenSession())
      {
        var usuario = session.Get<Usuario>(id);
        return View(usuario);
      }
    }

    // GET: UsuarioController/Create
    public ActionResult Create()
    {
      return View();
    }
    // POST: UsuarioController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Usuario usuario)
    {
      try
      {
        using (NHibernate.ISession session = NHibernateHelper.OpenSession())
        {
          using (ITransaction transaction = session.BeginTransaction())
          {
            session.Save(usuario);
            transaction.Commit();
          }
        }

        return RedirectToAction("Index");
      }
      catch (Exception exception)
      {
        return View();
      }
    }

    // GET: UsuarioController/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }
    // POST: UsuarioController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: UsuarioController/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: UsuarioController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
  }
}
