using NUnit.Framework;
using HotelReservationSystem;

namespace HotelReservationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddHotelTest()
        {
            Hotel hotel = new Hotel(HotelType.RIDGEWOOD);
            double expectedRate = 220;
            Assert.AreEqual(expectedRate,hotel.RATE);
        }
    }
}