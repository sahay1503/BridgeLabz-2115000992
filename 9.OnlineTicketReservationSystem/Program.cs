using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddReservation(101, "Amit Sharma", "Pathaan", "A12");
        system.AddReservation(102, "Rohit Mehta", "Jawan", "B15");
        system.AddReservation(103, "Sneha Gupta", "Animal", "C22");

        system.DisplayReservations();

        system.RemoveReservation(102);
        system.DisplayReservations();

        system.SearchTicket("Pathaan");

        system.CountReservations();
    }
}
