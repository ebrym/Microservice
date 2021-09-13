using System.Collections.Generic;
using PlatformService.Models;
namespace PlatformService.Data
{
    public interface IPlatformRepo
    {        
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void Create(Platform plat);



    }

}