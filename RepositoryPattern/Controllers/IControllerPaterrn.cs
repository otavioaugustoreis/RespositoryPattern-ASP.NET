using Microsoft.AspNetCore.Mvc;

namespace RepositoryPattern.Controllers
{
    public interface IControllerPaterrn<T>
    {
        public ActionResult<IEnumerable<T>> Get();
        public ActionResult<T> GetId(int id);
        public ActionResult<T> Post(T entidade);
        public ActionResult<T> Put(int id, T t);
        public ActionResult<T> Delete(int id);
    }
}
