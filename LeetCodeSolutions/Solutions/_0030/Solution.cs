namespace LeetCodeSolutions.Solutions._0030;

public class Solution
{
    /*
        don't get fooled! this is not a string search problem.
    
        the possible answers must in range [0, s.Length - words.Count * words[0].Length]
        just traverse every possible answer and judge it.
    */
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> res = new List<int>();

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        foreach(string word in words)
        {
            if(!wordsCount.ContainsKey(word))
            {
                wordsCount[word] = 0;
            }
            wordsCount[word]++;
        }

        for(int i = 0; i <= s.Length - words[0].Length * words.Length; ++i)
        {
            if (IsSubstringContainsAllWords(s, i, wordsCount, words.Length))
            {
                res.Add(i);
            }
        }

        return res;
    }

    private bool IsSubstringContainsAllWords(string s, int startIdx, Dictionary<string, int> wordsAppreanceDict, int wordsCount)
    {

        Dictionary<string, int> wordsAppreanceDictInSubstring = new Dictionary<string, int>();

        int wordLength = wordsAppreanceDict.First().Key.Length;
        for(int i = 0; i < wordsCount; ++i)
        {
            string word = s.Substring(startIdx + i * wordLength, wordLength);
            if(!wordsAppreanceDictInSubstring.ContainsKey(word))
            {
                wordsAppreanceDictInSubstring.Add(word, 0);
            }

            wordsAppreanceDictInSubstring[word]++;

            if (!wordsAppreanceDict.ContainsKey(word) || wordsAppreanceDictInSubstring[word] > wordsAppreanceDict[word])
            {
                return false;
            }
        }

        return true;
    }
}
