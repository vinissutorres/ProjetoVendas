﻿namespace ProjetoVendas.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string cellPhone { get; set; }
        public string zipCode { get; set; }
        public string Address { get; set; }
        public int houseNumber { get; set; } 
        public string Details { get; set; }
        public string Neighbourhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
