using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class MenuService : IMenu
    {
        private readonly GraphQLDbContext _dbcontext;
        public MenuService(GraphQLDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public Menu AddMenu(Menu menu)
        {
            _dbcontext.Menus.Add(menu);
            _dbcontext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
            return _dbcontext.Menus.ToList();
        }
    }
}
