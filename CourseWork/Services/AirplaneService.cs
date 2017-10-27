using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace CourseWork.Services
{
    
    using Dal;

    class AirplaneService: BaseService
    {
        public static AirplaneService Get()
        {
            return new AirplaneService();
        }

        async public Task<List<Airplane>> GetAirplanes(Expression<Func<Airplane, bool>> predicate = null)
        {
            return await UseDb(async db =>
                predicate == null
                ? await db.Airplanes.ToListAsync()
                : await db.Airplanes.Where(predicate).ToListAsync());
        }

        async public Task AddAirplane(Airplane airplane)
        {
            await UseDb(async db => {
                db.Airplanes.Add(airplane);
                await db.SaveChangesAsync();
            });
        }
    }
}
