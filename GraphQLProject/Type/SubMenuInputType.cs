using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class SubMenuInputType : InputObjectGraphType
    {
        //it takes input from user that's why here inputobjectgraphtype taken
        public SubMenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
            Field<StringGraphType>("description");
            Field<IntGraphType>("menuId");
            Field<FloatGraphType>("price");
        }
    }
}
