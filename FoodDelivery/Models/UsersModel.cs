﻿namespace FoodDelivery.Models
{
    public class UsersModel
    {
        public short Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
    }
}
