using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cadastr.Models
{
    public class Cadastrentity
    {
        public virtual int ID { get; set; }
        public virtual DateTime created_at { get; set; }
        public virtual DateTime updated_at { get; set; }

        public virtual void Save()
        {
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
            Cadastr.Common.IRepository<Cadastrentity> repo = new Repositories.CadastrentityRepository();

            repo.Save(this);
        }

        public virtual void Update()
        {
            this.updated_at = DateTime.Now;
            Cadastr.Common.IRepository<Cadastrentity> repo = new Repositories.CadastrentityRepository();
            repo.Update(this);
        }

        public static List<Cadastrentity> GetAll()
        {
            Cadastr.Common.IRepository<Cadastrentity> repo = new Repositories.CadastrentityRepository();
            return (List<Cadastrentity>)repo.GetAll();
        }

        public static Cadastrentity GetById(int ID)
        {
            Cadastr.Common.IRepository<Cadastrentity> repo = new Repositories.CadastrentityRepository();
            return repo.GetById(ID);
        }
        public virtual void Delete()
        {
            Cadastr.Common.IRepository<Cadastrentity> repo = new Repositories.CadastrentityRepository();
            repo.Delete(this);
        }

    }
}