using System.Threading.Tasks;

namespace IEXCloudClient
{
    public interface IRequest<TResponse>
    {
        Task<TResponse> SendRequestAsync();
    }
}
