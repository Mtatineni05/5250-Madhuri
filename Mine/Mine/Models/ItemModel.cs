using System;

namespace Mine.Models
{
    public class ItemModel
    {
        //The ID for an item
        public string Id { get; set; }
        //The Display text for an item
        public string Text { get; set; }
        //The description for an item
        public string Description { get; set; }
        //The Value of item +9 Damage
        public int Value { get; set; } = 0;
    }
}