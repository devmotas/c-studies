
using VectorExercise;

Console.Write("How many rooms will be retented?");

int quantity = int.Parse(Console.ReadLine());

Console.WriteLine();

Booking[] booking = new Booking[quantity];
for (int i = 0; i < quantity; i++)
{
    Console.WriteLine($"Rent #{i + 1}");

    Console.Write("Name:");
    string name = Console.ReadLine();

    Console.Write("Email:");
    string email = Console.ReadLine();

    Console.Write("Room:");
    int room = int.Parse(Console.ReadLine());

    Console.WriteLine();

    booking[i] = new Booking
    {
        Name = name,
        Email = email,
        Room = room
    };
}
Console.WriteLine("Busy rooms:");


booking.OrderBy(x => x.Room).ToList().ForEach(x =>
Console.WriteLine($"{x.Room}: {x.ToString()}"));

