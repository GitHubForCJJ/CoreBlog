using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Abstractions.Entitys;
using Blog.Basedata;
using Blog.Services;
using Blog.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Blog.EntityFramework;

namespace Blog.WebApi.Controllers
{
    public class BlogController : Controller
    {
        private readonly IServiceProvider provider;
        private readonly ILogger<BlogController> logger;
        private readonly IBlogServices blogServices;
        private IRepository<Category, int> cat;

        public BlogController(ILogger<BlogController> logger, IServiceProvider provider, IRepository<Category, int> cat)
        {
            this.provider = provider;
            cat = cat;
            //var fac=provider.GetService(typeof(ILoggerFactory));
            blogServices = provider.GetService<IBlogServices>();
            this.logger = logger;
        }
        /// <summary>
        /// h5不加密获取list
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResponse GetListBlog([FromBody]BaseViewModel model)
        {
            try
            {
                var dicwhere = new Dictionary<string, object>() {
                        {nameof(Bloginfo.IsDeleted),0 },
                                    {nameof(Bloginfo.States),0 },
                    };
                if (model.KID > 0)
                {
                    dicwhere.Add(nameof(Bloginfo.Type), model.KID);
                }
                //var retlist = BlogHelper.GetJsonListPage_Bloginfo(model.Page, model.Limit, "CreateTime desc", dicwhere);
                //return new JsonResponse { Code = retlist.code.Toint(), Count = retlist.code.Toint() == 0 ? retlist.data.Count() : 0, Data = retlist.code.Toint() == 0 ? retlist.data : null };
                return new JsonResponse { Code = 1, Msg = "程序is  oK" };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "BlogController/GetListBlog");
                return new JsonResponse { Code = 1, Msg = "程序好像开小差了" + ex.Message };
            }
        }

        [HttpGet]
        public JsonResponse Cat()
        {
            try
            {
                var list = blogServices.CategoryRep.Query();
                return new JsonResponse { Code = 0, Data = list };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "BlogController/Cat");
                return new JsonResponse { Code = 1, Msg = "程序好像开小差了" + ex.Message };
            }
        }
    }
}