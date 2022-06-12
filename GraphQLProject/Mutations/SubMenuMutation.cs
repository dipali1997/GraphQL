using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutations
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "submenu" }),
             resolve: context =>
             {
                 return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("submenu"));
             });
        }
    }
}
