using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
            Field(p => p.Description);
            Field(p => p.MenuId);
            Field(p => p.ImageUrl);
        }
    }
    
}
