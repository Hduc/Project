﻿using AutoMapper;

namespace WebApp.Business.RepositoryBase
{
    public interface IComplexMapping : IMapping
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapperConfigurationExpression"></param>
        void CreateMap(IMapperConfigurationExpression mapperConfigurationExpression);
    }
}