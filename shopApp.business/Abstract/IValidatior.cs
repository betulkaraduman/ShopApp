namespace shopApp.business.Abstract
{
    public interface IValidatior<T> where T:class
    {
         string ErrorMessage{get;set;}
         bool Validate(T entity);
    }
}