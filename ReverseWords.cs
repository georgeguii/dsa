namespace study_dsa;

public static class ReverseWords
{
    public static string Handler(string s)
    {
        var words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }

        return string.Join(" ", words);
    }

    private static string ReverseString(string word)
    {
        char[] charArray = word.ToCharArray();
        int left = 0, right = charArray.Length - 1;

        while (left < right)
        {
            (charArray[left], charArray[right]) = (charArray[right], charArray[left]);

            left++;
            right--;
        }

        return new string(charArray);
    }
}