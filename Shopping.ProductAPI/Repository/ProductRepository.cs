using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shopping.ProductAPI.Data.ValueObjects;
using Shopping.ProductAPI.Migrations;
using Shopping.ProductAPI.Model;
using Shopping.ProductAPI.Model.Context;

namespace Shopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SQLContext _context;
        private IMapper _mapper;

      
        public ProductRepository(SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List < Product > products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product produtc = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
            return _mapper.Map<ProductVO>(produtc); 
        }
        public async Task<ProductVO> Create(ProductVO vo)
        {
            Product produtc =  _mapper.Map<Product>(vo);
            _context.Products.Add(produtc);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(produtc);
        }
        public async Task<ProductVO> Update(ProductVO vo)
        {
            Product produtc = _mapper.Map<Product>(vo);
            _context.Products.Update(produtc);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(produtc);

        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product produtc = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
                if (produtc.Id <= 0) return false;                
                _context.Products.Remove(produtc);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }   
        }
    }
}
