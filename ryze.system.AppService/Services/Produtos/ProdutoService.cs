using AutoMapper;
using ryze.system.AppService.Interfaces.Produtos;
using ryze.system.AppService.Models.Produtos;
using ryze.system.Domain.Entities.Produtos;
using ryze.system.Domain.Interfaces.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryze.system.AppService.Services.Produtos
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        

        public async Task<ProdutoDto> GetProdutoById(Guid id)
        {
            var entity = await _produtoRepository.GetProdutoByIdAsync(id);

            return _mapper.Map<ProdutoDto>(entity); 
        }

        public async Task<IEnumerable<ProdutoDto>> GetProdutos()
        {
            var entity = await _produtoRepository.GetProdutosAsync();

            return _mapper.Map<IEnumerable<ProdutoDto>>(entity);
        }        

        public async Task Add(ProdutoDto produtoDto)
        {
            var entity = _mapper.Map<Produto>(produtoDto);

            await _produtoRepository.CreateAsync(entity);
        }

        public async Task Update(ProdutoDto produtoDto)
        {
            var entity = _mapper.Map<Produto>(produtoDto);

            await _produtoRepository.UpdateAsync(entity);
        }

        public async Task Remove(Guid id)
        {
            var entity = await _produtoRepository.GetProdutoByIdAsync(id);

            await _produtoRepository.RemoveAsync(entity);
        }
    }
}
