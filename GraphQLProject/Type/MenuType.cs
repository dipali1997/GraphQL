using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.ImageUrl);
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context =>
            {
                return subMenuService.GetSubMenus(context.Source.Id);
            });
        }

    }
}

