using System.Threading.Tasks;
using InsolvencyRegisterCuzkServiceReference;

namespace PetrVala.InsolvencyRegisterChecker.ServiceLibrary
{
    public class ServiceFullWrapper
    {
        public async Task<getIsirWsCuzkDataResponse> GetIsirWsCuzkDataAsync(getIsirWsCuzkDataRequest request)
        {
            var client = new IsirWsCuzkPortTypeClient();
            return await client.getIsirWsCuzkDataAsync(request);
        }
    }
}