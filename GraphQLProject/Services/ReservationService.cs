using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class ReservationService :IReservation
    {
        private readonly GraphQLDbContext _dbcontext;
        public ReservationService(GraphQLDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _dbcontext.Reservations.Add(reservation);
            _dbcontext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _dbcontext.Reservations.ToList();
        }
    }
}
