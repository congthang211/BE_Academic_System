﻿using AutoMapper.Internal;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace TeduBlog.Api.Filter
{
    public class SwaggerNullableParameterFilter : IParameterFilter
    {
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            if (!parameter.Schema.Nullable &&
                 context.ApiParameterDescription.Type.IsNullableType()
                 || context.ApiParameterDescription.Type == null)
            {
                parameter.Schema.Nullable = true;
            }
        }
    }
}
