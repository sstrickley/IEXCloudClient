using System.Threading.Tasks;

namespace IEXCloudClient
{
    public interface IRequest<TResponse>
    {
        Task<TResponse> SendRequestAsync();
        void AddFilter(params string[] args);
    }
}
