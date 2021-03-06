﻿using CinemaBooking.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaBooking.Domain.Interfaces
{
    public interface ISeatRepository
    {
        Task<ICollection<Seat>> GetSeatsForScreen(int screenId);

        Task<ICollection<Seat>> GetBookedSeats(int showTimeId, int movieId);
    }
}