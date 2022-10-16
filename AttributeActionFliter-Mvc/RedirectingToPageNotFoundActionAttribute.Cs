
    public class RedirectingToPageNotFoundActionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);


            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
            {
                controller = "Errors",
                action = "PageNotFound",
                area = ""
            }));

        }
    }