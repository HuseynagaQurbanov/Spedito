using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.SettingRepository
{
    public interface ISettingRepository
    {
        IEnumerable<Setting> GetSettings();
    }

    public class SettingRepository : ISettingRepository
    {
        private readonly SpeditoDbContext _context;
        public SettingRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Setting> GetSettings()
        {
            return _context.Setting.Where(s => s.Status).ToList();
        }
    }
}
