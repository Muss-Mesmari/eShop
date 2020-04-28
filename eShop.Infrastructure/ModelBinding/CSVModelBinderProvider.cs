using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.ModelBinding
{
    // This filter for binding that date that is coming .CSV files
    // check the startup.cs class, in the ConfigureServices method
    public class CSVModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(List<Event>))
            {
                return new CSVModelBinder();
            }

            return null;
        }
    }
}
