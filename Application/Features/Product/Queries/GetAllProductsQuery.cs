using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Domain.Entites.Product>>
    {
        internal class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Domain.Entites.Product>>
        {
            public async Task<IEnumerable<Domain.Entites.Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
               var list = new List<Domain.Entites.Product>();
                for (int i = 0; i < 50; i++)
                {
                    var pro = new Domain.Entites.Product();
                    pro.Name = "test name";
                    pro.Description = "test des";
                    pro.Rate = 50 + i;
                    list.Add(pro);
                }
                return list;
            }
        }
    }
}
