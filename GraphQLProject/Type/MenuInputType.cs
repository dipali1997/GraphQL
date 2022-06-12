using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        //it takes input from user that's why here inputobjectgraphtype taken
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
        }
    }
}
