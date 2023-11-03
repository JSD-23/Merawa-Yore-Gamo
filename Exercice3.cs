using System;
using System.Collections.Generic;

public class LRUCache
{
	private int capacite;
	Dictionary<int,int> cache;
	
    public LRUCache(int capacite)
    {
    	this.capacite = capacite;
    	cache = new Dictionary<int, int>(capacite);
    }

    public int Get(int cle)
    {
    	return cache[cle];
    }

    public void Put(int cle, int valeur)
    {
    	cache[cle] = valeur;
    }

    public void Free()
    {
    	foreach (KeyValuePair<int,int> kvp in cache)
    	{
    		cache.Remove(kvp.Key);
    	}
    }
}
