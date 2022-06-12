using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            //this return a menu obj so in field menutype is passed Field<MenuType>
            Field<MenuType>("createMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
             resolve: context =>
             {
                 return menuService.AddMenu(context.GetArgument<Menu>("menu"));
             });
        }
    }
}
#region
//https://prnt.sc/lDOx89pbemhX
//here in this line variable menu is created 
//--  new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }
// and in below line variable menu is used 
//context.GetArgument<Menu>("menu")
#endregion