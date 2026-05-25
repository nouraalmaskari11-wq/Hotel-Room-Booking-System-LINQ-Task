namespace Hotel_Room_Booking_System
{
    //Adding class Room
    public class Room
    {
        public int Id { get; set; }
        public string? RoomNumber { get; set; }
        public string? Type { get; set; }
        public double PricePerNight { get; set; }
        public bool IsBooked { get; set; }
        public int Floor { get; set; }



        static void Main(string[] args)
        {
            // Adding Sample Data
            List<Room> rooms = new List<Room>
              {
              new Room { Id = 1, RoomNumber = "101", Type = "Single", PricePerNight = 500, IsBooked = false, Floor = 1 },
              new Room { Id = 2, RoomNumber = "102", Type = "Double", PricePerNight = 800, IsBooked = true, Floor = 1 },
              new Room { Id = 3, RoomNumber = "201", Type = "Suite", PricePerNight = 1500, IsBooked = false, Floor = 2 },
              new Room { Id = 4, RoomNumber = "202", Type = "Single", PricePerNight = 550, IsBooked = true, Floor = 2 },
              new Room { Id = 5, RoomNumber = "301", Type = "Double", PricePerNight = 900, IsBooked = false, Floor = 3 },
              new Room { Id = 6, RoomNumber = "302", Type = "Suite", PricePerNight = 1700, IsBooked = true, Floor = 3 },
              new Room { Id = 7, RoomNumber = "401", Type = "Single", PricePerNight = 600, IsBooked = false, Floor = 4 },
              new Room { Id = 8, RoomNumber = "402", Type = "Double", PricePerNight = 950, IsBooked = false, Floor = 4 }
              };

            Console.WriteLine("========== Hotel Room Booking System ============");
            // 1. Get all available rooms by using where .can get avilable rooms by cheking the IsBooked ==false
            Console.WriteLine("1. All available rooms");
            var availableRooms = rooms.Where(s=>s.IsBooked==false).ToList();
            foreach ( var room in availableRooms)
            {
                Console.WriteLine($"Room Id: {room.Id} - RoomNumber: {room.RoomNumber} ");
            }
            Console.WriteLine();

            //2. Display only room numbers using select. select gets all rooms by spicifing it to room number 
            Console.WriteLine("2. Rooms Number");
            var roomNumber = rooms.Select(s=>s.RoomNumber).ToList();
            foreach ( var room in roomNumber)
            {
                Console.WriteLine($"RoomNumber: {room}");
            }
            Console.WriteLine();

            //3. Get the first available suite room using FirstOrDefault()  => it gets the first available suite room by Type=suite and Isbooked =false
            var firstAvailableRoomSuite = rooms.FirstOrDefault(s => s.Type == "Suite" && s.IsBooked== false);
            if (firstAvailableRoomSuite != null)
            {
                Console.WriteLine($"3. First available suite room : {firstAvailableRoomSuite.RoomNumber} ");
            }
            else { Console.WriteLine("No Suite Room is Available"); }
            Console.WriteLine();

            //4. Sort rooms by price using OrderBy() => its order all the rooms by it price
            Console.WriteLine("4. Rooms sorted by price");
            var sortByPrice = rooms.OrderBy(s => s.PricePerNight).ToList();
            foreach (var room in sortByPrice)
            {
                Console.WriteLine($"RoomNumber: {room.RoomNumber} - Room price: {room.PricePerNight}");
            }
            Console.WriteLine();

            //5. Count booked rooms using count() => IsBooked== true
            var bookedRoom = rooms.Count(s => s.IsBooked == true);
            Console.WriteLine($"5. Booked Rooms count: {bookedRoom} ");
            Console.WriteLine();

            //6. Calculate average room price using Average() => price
            var averageRoomPrice = rooms.Average(s => s.PricePerNight);
            Console.WriteLine($"6. Average Rooms Price: {averageRoomPrice}");
            Console.WriteLine();

            //7. Get the most expensive room using MAX() => PricePerNight
            var MaxPrice = rooms.Max(s => s.PricePerNight);
            var mostExpensiveRoom = rooms.Where(s => s.PricePerNight == MaxPrice);
            foreach (var room in mostExpensiveRoom)
            {
                Console.WriteLine($"7. Most Expensive Room: {room.RoomNumber} - {room.Type}");
            }
        }
    }
}
