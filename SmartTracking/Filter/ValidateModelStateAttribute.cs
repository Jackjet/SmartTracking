using System.Web.Mvc;

namespace SmartTracking.Filter
{
    /// <summary>
    /// 默认模型字典验证过滤器
    /// </summary>
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.Controller.ViewData.ModelState.IsValid == false)
            {
                filterContext.Result = new EmptyResult();
            }

            base.OnActionExecuting(filterContext);
        }
    }
}