﻿namespace a
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int population { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }

        public override string ToString()
        {
            return $"ID {this.Id} {this.Name} {this.State} {this.population}"; 
        }
    }
}