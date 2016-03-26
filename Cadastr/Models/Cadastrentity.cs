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

        public virtual DateTime delivery_at { get; set; } // Дата выдачи
        public virtual string base_document { get; set; } // Документ основание
        public virtual string law_subject { get; set; } // Субъект права
        public virtual int law_object { get; set; } // Объект права: 1 - земельный участок, 2 - недвижимость

        public virtual string category_land { get; set; } //Категория земли
        public virtual double total_area { get; set; } // Общая площадь
        public virtual string address { get; set; }
        public virtual string law_type { get; set; } // Вид права
        public virtual int cadastr_number {get; set;} //Кадастровый номер
        public virtual string law_restriction { get; set; } // Ограничения права



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