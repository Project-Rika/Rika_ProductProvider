using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Rika_ProductProvier.Infrastructure.Repositories;

namespace Rika_ProductProvider.Functions;

public class GetAll
{
    private readonly ILogger<GetAll> _logger;
    private readonly ProductRepository _productRepository;

    public GetAll(ILogger<GetAll> logger, ProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }

    [Function("GetAll")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        try 
        {
            if (req.Method == "POST")
            {
                var body = await new StreamReader(req.Body).ReadToEndAsync();
                
                var filterCriteria = JsonConvert.DeserializeObject<FilterCriteria>(body);

                if (filterCriteria != null)
                {
                    var sortedProducts = await _productRepository.GetAllAsync(x => 
                        x.ProductName == filterCriteria.ProductName || 
                        x.ProductColorId == filterCriteria.ProductColor || 
                        x.ProductSizeId == filterCriteria.ProductSize ||
                        x.ProductCategoryId == filterCriteria.ProductCategory);
                    return new OkObjectResult(sortedProducts);
                }
            }

            var products = await _productRepository.GetAllAsync();
            return new OkObjectResult(products);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return new BadRequestObjectResult(ex.Message);
        }
    }

}

public class FilterCriteria
{
    public string? ProductName { get; set; }
    public int ProductColor { get; set; }
    public int ProductSize { get; set; }
    public int ProductCategory { get; set; }
}