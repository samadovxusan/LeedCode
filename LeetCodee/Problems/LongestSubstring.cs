namespace LeetCodee.Problems;

public static class LongestSubstring{
    public static int LengthOfLongestSubstring(string s)
    {
        int[] lastSeen = new int[128]; // ASCII uchun
        for (int i = 0; i < 128; i++)
            lastSeen[i] = -1;

        int maxLength = 0;
        int start = 0;

        for (int end = 0; end < s.Length; end++)
        {
            char c = s[end];
            if (lastSeen[c] >= start)
            {
                start = lastSeen[c] + 1;
            }

            lastSeen[c] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}