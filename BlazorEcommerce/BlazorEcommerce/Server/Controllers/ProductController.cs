using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id = 2,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
            Price = 7.99m
        },
        new Product
        {
            Id = 3,
            Title = "Nineteen Eighty-Four",
            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
            Price = 6.99m
        }
    };
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            //var result = await _productService.GetProductsAsync();
            return Ok(Products);
        }

        //private readonly IProductService _productService;

        //public ProductController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        //[HttpGet("admin"), Authorize(Roles = "Admin")]
        //public async Task<ActionResult<ServiceResponse<List<Product>>>> GetAdminProducts()
        //{
        //    var result = await _productService.GetAdminProducts();
        //    return Ok(result);
        //}

        //[HttpPost, Authorize(Roles = "Admin")]
        //public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct(Product product)
        //{
        //    var result = await _productService.CreateProduct(product);
        //    return Ok(result);
        //}

        //[HttpPut, Authorize(Roles = "Admin")]
        //public async Task<ActionResult<ServiceResponse<Product>>> UpdateProduct(Product product)
        //{
        //    var result = await _productService.UpdateProduct(product);
        //    return Ok(result);
        //}

        //[HttpDelete("{id}"), Authorize(Roles = "Admin")]
        //public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct(int id)
        //{
        //    var result = await _productService.DeleteProduct(id);
        //    return Ok(result);
        //}

        //[HttpGet]
        //public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        //{
        //    var result = await _productService.GetProductsAsync();
        //    return Ok(result);
        //}

        //[HttpGet("{productId}")]
        //public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        //{
        //    var result = await _productService.GetProductAsync(productId);
        //    return Ok(result);
        //}

        //[HttpGet("category/{categoryUrl}")]
        //public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
        //{
        //    var result = await _productService.GetProductsByCategory(categoryUrl);
        //    return Ok(result);
        //}

        //[HttpGet("search/{searchText}/{page}")]
        //public async Task<ActionResult<ServiceResponse<ProductSearchResult>>> SearchProducts(string searchText, int page = 1)
        //{
        //    var result = await _productService.SearchProducts(searchText, page);
        //    return Ok(result);
        //}

        //[HttpGet("searchsuggestions/{searchText}")]
        //public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductSearchSuggestions(string searchText)
        //{
        //    var result = await _productService.GetProductSearchSuggestions(searchText);
        //    return Ok(result);
        //}

        //[HttpGet("featured")]
        //public async Task<ActionResult<ServiceResponse<List<Product>>>> GetFeaturedProducts()
        //{
        //    var result = await _productService.GetFeaturedProducts();
        //    return Ok(result);
        //}
    }
}
