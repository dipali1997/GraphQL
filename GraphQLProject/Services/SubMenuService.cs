using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class SubMenuService : ISubMenu
    {
        private readonly GraphQLDbContext _dbcontext;
        public SubMenuService(GraphQLDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public SubMenu AddSubMenu(SubMenu submenu)
        {
            _dbcontext.SubMenus.Add(submenu);
            _dbcontext.SaveChanges();
            return submenu;
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return _dbcontext.SubMenus.Where(m => m.MenuId == menuId).ToList();
        }

        public List<SubMenu> GetSubMenus()
        {
            return _dbcontext.SubMenus.ToList();
        }
    }
}
