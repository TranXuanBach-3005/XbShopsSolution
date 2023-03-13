using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XbShopSolution.Application.Services.IService;
using XbShopSolution.Application.UnitOfWorks;
using XbShopSolution.Data.Entities;
using XbShopSolution.ViewModel.ViewModel.Products;

namespace XbShopSolution.Application.Services.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async Task<int> CreateProductAsync(ProductCreateViewModel model)
        {
            var product = _mapper.Map<Product>(model);
            if(model.ProductslImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption = "product image",
                        IsDefault =true,
                        FileSize = model.ProductslImage.Length,
                        CreateDated = DateTime.Now,
                        ImagePath =await _fileService.SaveImage(model.ProductslImage)
                    }
                };
            }
            await _unitOfWork.ProductRepository.CreateAsync(product);
            await _unitOfWork.SavesChangeAsync();
            return product.Id;
        }
    }
}
