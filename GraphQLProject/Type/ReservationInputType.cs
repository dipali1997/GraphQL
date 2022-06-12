using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        //it takes input from user that's why here inputobjectgraphtype taken
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("phone");
            Field<IntGraphType>("totalPeople");
            Field<StringGraphType>("email");
            Field<StringGraphType>("date");
            Field<StringGraphType>("time");
        }
    }
}
