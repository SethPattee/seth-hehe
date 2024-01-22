using Hehe.classlib;
namespace Hehe.API.Services
{
    public class ApiService : IService
    {
        public Task<int> Add(int a, int b) => Task.FromResult(a + b);
    }
}
