﻿
namespace ath_server.Models;
public class Shop
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<ProductInShop> Products { get; set; }

}