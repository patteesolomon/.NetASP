using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName 
{
    class Enchantments : ItemConfig
    {
    #region 
    #endregion

    public HashSet <object> Items = new HashSet<object> {};
    public HashSet <object> Weapons = new HashSet<object> {};
    public HashSet <object> Armors = new HashSet<object> {};

    private HashSet <object> TemperNames = new HashSet<object> {};
    private HashSet <object> TarotSet = new HashSet<object> {}; 

    public object enchant;
    public object entableItem;

    public HashSet <object> TemperNames1 = {get => TemperNames; set => TemperNames = value;};
    public HashSet <object> TarotCards = {get => TarotSet; set => TarotSet = value;};

    public void TemperMake(string ItemTree, object entableItem)
    {
        public enchant;
		
	if (ItemTree != entableItem.ItemTree)
	{
	return null;
	}
        return entableItem = enchant(); // enchanted item; 
    }

    public String EnchantValidator(object enchant) // for Temper names
    {
	string EnchantCard;
	enchant en
	EnchantCard = en.Tname; // Temper
	// validate the TemperName
	if(TemperNames1.any() = EnchantCard)
	{
	return EnchantCard;
	}
        return null;
    }

    private String TarotSystem(object enchant) // Taro names 
    {
	string tName;
	// case combos for all stat modifications
	switch(enchant)
	case: 'test'
	{
	break;
	}
	default:
	{
	break;
	}
	else
        return tName;
    }

    public void Enchant(object enchant, String tName, String eName)
    {
	
    }
}