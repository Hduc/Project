using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using AutoMapper;

namespace WebApp.Web
{
    public static class MapperConfig
    {
        public static void RegisterMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // cfg.AddProfile<DepartmentProfile>();
                // cfg.AddProfile<DepartmentTypeProfile>();

            });
            var mapper = config.CreateMapper();
        }

    }
}