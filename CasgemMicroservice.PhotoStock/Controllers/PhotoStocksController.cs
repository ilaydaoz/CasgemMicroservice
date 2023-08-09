﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoStocksController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> SavePhoto(IFormFile formFile, CancellationToken cancellationToken)
        {
            if (formFile != null && formFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "www/photos", formFile.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                await formFile.CopyToAsync(stream, cancellationToken);
                var returnPath = formFile.FileName;
            }
            return NoContent();
        }
    }
}
