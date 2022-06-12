using GraphQL.Types;
using GraphQLProject.Mutations;
using GraphQLProject.Query;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GraphQLProject.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) :base(serviceProvider)  
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}

#region //syntax

//{
//    menuQuery{
//        menu{
//            id
//            name
//        }
//    }
//}
//https://graphql-dotnet.github.io/docs/getting-started/introduction/
//mutation addmenu($menu: MenuInputType){
//    menuMutation{
//        createMenu(menu: $menu){
//            id
//            name
//             imageUrl
//           }
//    }
//}

//{
//    "menu": 
//  {
//        "name" :"Tea",
//      "imageUrl": "tea.png"
//  }
//}

//query
//{
//    menuQuery{
//        menu{
//            id
//            name
//          imageUrl
//        }
//    }
//}


//mutation addsubmenu($submenu:SubMenuInputType){
//    subMenuMutation{
//        createSubMenu(submenu: $submenu){
//            id
//            name
//              price
//        menuId
//             description
//       imageUrl
//           }
//    }
//}


//{
//    "submenu":
//  {
//        "menuId": 1
//    ,"name": "Espreeso",
//    "description": "Espreeso coffee"
//    ,"imageUrl": "espreeso.png"
//    ,"price":220
//  }
//}



//query
//{
//    subMenuQuery{
//        submenus{
//            id
//            name
//          imageUrl
//      price
//          description
//        }
//    }
//}

//mutation addreservation($reservation:ReservationInputType){
//    reservationMutation{
//        createReservation(reservation: $reservation){
//            id
//            name
//            date
//        email
//        phone
//        time
//        totalPeople
//           }
//    }
//}




//{
//    "reservation": {
//        "name": "john",
//    "phone": "89898757675",
//    "totalPeople": 2,
//    "email": "zyah@yopmail.com",
//    "date": "2022/05/12",
//    "time": "11:00AM"


//  }
//}



//query
//{
//    reservationQuery{
//        reservations{
//            id
//            name
//        }
//    }
//}

//query
//{
//    menuQuery{
//        menu{
//            name
//            id
//         imageUrl
//    SubMenus{
//                id
//                name


//    }
//        }
//    }
//}

#endregion