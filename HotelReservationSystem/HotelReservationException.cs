using System;
namespace HotelReservationSystem
{
    public class HotelReservationException : Exception 
    {
        public enum ExceptionType
        {
            INVALID_HOTEL_TYPE,
            INVALID_DATE,
            INVALID_CUSTOMER_TYPE
        }
        ExceptionType type;
        public HotelReservationException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}