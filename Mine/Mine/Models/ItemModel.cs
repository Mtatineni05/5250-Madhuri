using System;
using SQLite;

namespace Mine.Models
{
    public class ItemModel
    {
        //The ID for an item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        //The Display text for an item
        public string Text { get; set; }
        //The description for an item
        public string Description { get; set; }
        //The Value of item +9 Damage
        public int Value { get; set; } = 0;
    }
}