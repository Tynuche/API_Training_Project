using ConsoleApp1.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoleApp1
{
    public class CustomModelBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {           
         
            var modelName = bindingContext.ModelName;
            var values = bindingContext.ValueProvider.GetValue(modelName);
            var result = values.FirstValue;

            if(!int.TryParse(result, out var id))
            {
                return Task.CompletedTask;
            }

            var model = new CountryModel()
            {
                Id = id,
                Area = 400,
                Name = "India",
                Population = 500
            };

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;
        }
    }
}
