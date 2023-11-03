using System;

class Exercice1
{
	public int LengthOfLastWord(string s) 
	{
		if (0 == s.Length)
			return 0;
		
		int  lastIndex = s.LastIndexOf(" ");
		
		if (-1 == lastIndex)
			return s.Length;
		
		if ( lastIndex != s.Length -1)
			return s.Substring(lastIndex+1).Length;
		
		return s.Length - 1;
	}
    
}
