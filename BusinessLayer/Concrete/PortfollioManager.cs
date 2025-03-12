using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfollioManager : IPortfollioService
    {
        IPortfollioDal _portfollioDal;

        public PortfollioManager(IPortfollioDal portfollioDal)
        {
            _portfollioDal = portfollioDal;
        }

        public void TAdd(Portfollio t)
        {
            _portfollioDal.Insert(t);
        }

        public void TDelete(Portfollio t)
        {
            _portfollioDal.Delete(t);
        }

        public Portfollio TGetByID(int id)
        {
            return _portfollioDal.GetByID(id);
        }

        public List<Portfollio> TGetList()
        {
            return _portfollioDal.GetList();
        }

        public void TUpdate(Portfollio t)
        {
            _portfollioDal.Update(t);
        }
    }
}
