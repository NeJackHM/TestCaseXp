﻿namespace SentEmailsJob.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}