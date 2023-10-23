using System;
using System.Collections.Generic;

class Flight
{
    public string FlightNumber { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public int AvailableSeats { get; set; }
}

class Reservation
{
    public string PassengerName { get; set; }
    public string FlightNumber { get; set; }
}

class Program
{
    static List<Flight> flights = new List<Flight>();
    static List<Reservation> reservations = new List<Reservation>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Flight Reservation System");
            Console.WriteLine("1. Add Flight");
            Console.WriteLine("2. List Flights");
            Console.WriteLine("3. Make Reservation");
            Console.WriteLine("4. List Reservations");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddFlight();
                        break;
                    case 2:
                        ListFlights();
                        break;
                    case 3:
                        MakeReservation();
                        break;
                    case 4:
                        ListReservations();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void AddFlight()
    {
        Console.Write("Enter Flight Number: ");
        string flightNumber = Console.ReadLine();

        Console.Write("Enter Destination: ");
        string destination = Console.ReadLine();

        Console.Write("Enter Departure Time (yyyy-MM-dd HH:mm): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime departureTime))
        {
            Console.Write("Enter Available Seats: ");
            if (int.TryParse(Console.ReadLine(), out int availableSeats))
            {
                Flight flight = new Flight
                {
                    FlightNumber = flightNumber,
                    Destination = destination,
                    DepartureTime = departureTime,
                    AvailableSeats = availableSeats
                };
                flights.Add(flight);
                Console.WriteLine("Flight added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid number of seats.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date and time format.");
        }
    }

    static void ListFlights()
    {
        Console.WriteLine("List of Flights:");
        foreach (var flight in flights)
        {
            Console.WriteLine($"{flight.FlightNumber} to {flight.Destination}, Departure Time: {flight.DepartureTime}, Available Seats: {flight.AvailableSeats}");
        }
    }

    static void MakeReservation()
    {
        Console.Write("Enter Passenger Name: ");
        string passengerName = Console.ReadLine();

        Console.Write("Enter Flight Number for Reservation: ");
        string flightNumber = Console.ReadLine();

        Flight flight = flights.Find(f => f.FlightNumber == flightNumber);
        if (flight != null)
        {
            if (flight.AvailableSeats > 0)
            {
                Reservation reservation = new Reservation
                {
                    PassengerName = passengerName,
                    FlightNumber = flightNumber
                };
                reservations.Add(reservation);
                flight.AvailableSeats--;
                Console.WriteLine("Reservation successfully made.");
            }
            else
            {
                Console.WriteLine("No available seats for this flight.");
            }
        }
        else
        {
            Console.WriteLine("Flight not found.");
        }
    }

    static void ListReservations()
    {
        Console.WriteLine("List of Reservations:");
        foreach (var reservation in reservations)
        {
            Console.WriteLine($"Passenger: {reservation.PassengerName}, Flight Number: {reservation.FlightNumber}");
        }
    }
}