class TicketReservationSystem
{
    private Ticket head = null;

    public void AddReservation(int ticketID, string customerName, string movieName, string seatNumber)
    {
        Ticket newNode = new Ticket(ticketID, customerName, movieName, seatNumber);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            Ticket temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = head;
        }
        Console.WriteLine("Ticket Reserved Successfully!");
    }

    public void RemoveReservation(int ticketID)
    {
        if (head == null)
        {
            Console.WriteLine("No reservations found.");
            return;
        }

        Ticket temp = head, prev = null;
        do
        {
            if (temp.TicketID == ticketID)
            {
                if (prev == null) // Deleting head node
                {
                    Ticket last = head;
                    while (last.Next != head)
                        last = last.Next;

                    if (head.Next == head)
                    {
                        head = null;
                    }
                    else
                    {
                        head = head.Next;
                        last.Next = head;
                    }
                }
                else
                {
                    prev.Next = temp.Next;
                }
                Console.WriteLine("Ticket Cancelled Successfully!");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Ticket ID not found.");
    }

    public void DisplayReservations()
    {
        if (head == null)
        {
            Console.WriteLine("No reservations available.");
            return;
        }

        Ticket temp = head;
        Console.WriteLine("Current Reservations:");
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string searchKey)
    {
        if (head == null)
        {
            Console.WriteLine("No reservations available.");
            return;
        }

        Ticket temp = head;
        bool found = false;
        do
        {
            if (temp.CustomerName.Equals(searchKey, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(searchKey, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No matching ticket found.");
    }

    public void CountReservations()
    {
        if (head == null)
        {
            Console.WriteLine("Total Tickets: 0");
            return;
        }

        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine($"Total Tickets: {count}");
    }
}
