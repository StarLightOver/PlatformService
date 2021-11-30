using System.Threading.Tasks;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.SyncDataService.Http
{
    public interface ICommandDataClient
    {
        public Task SendPlatformToCommand(PlatformReadDto platformReadDto);
    }
}