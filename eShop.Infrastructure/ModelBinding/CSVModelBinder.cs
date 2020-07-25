using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.ModelBinding
{
    public class CSVModelBinder : IModelBinder
    {
        // This filter for binding that date that is coming .CSV files
        // check the startup.cs class, in the ConfigureServices method
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var rawCSV = bindingContext.ValueProvider.GetValue("csv").ToString();
            var orderListCSV = rawCSV.Split(Environment.NewLine.ToCharArray());

            var createEventsList = new List<Event>();
            foreach (var order in orderListCSV)
            {
                var eventValues = order.Split(",");

                var newEvent = new Event()
                {
                    Name = eventValues[0],
                    ShortDescription = eventValues[1],
                    LongDescription = eventValues[2],                 
                    ImageUrl = eventValues[5],
                    IsHighlightedEvent = bool.Parse(eventValues[6]),
                    InStock = bool.Parse(eventValues[7]),
                    CategoryId = int.Parse(eventValues[8])
                };
                createEventsList.Add(newEvent);
            }

            bindingContext.Result = ModelBindingResult.Success(createEventsList);
            return Task.CompletedTask;
        }
    }
}
