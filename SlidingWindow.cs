namespace study_dsa;

public class SlidingWindow
{
    public static int Handler(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        
        int left = 0, right = 0;
        int maxLenght = 1;
        var dict = new Dictionary<char, int>();
        dict.Add(s[0], 1); 

        while (right < s.Length - 1)
        {
            right++;
            if (dict.ContainsKey(s[right]))
                dict[s[right]]++;
            else
                dict.Add(s[right], 1);

            while (dict[s[right]] > 2)
            {
                dict[s[left]]--;
                left++;
            }
            maxLenght = Math.Max(maxLenght, right - left + 1);
        }

        return maxLenght;
    }
}