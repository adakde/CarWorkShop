using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.Entities
{
    public class CarWorkShop
    {
        public required int ID { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public CarWorkShopContanct ContactDetails { get; set; } = default!;

        public string EncodedName { get; private set; } = default!;

        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");
    }
}
