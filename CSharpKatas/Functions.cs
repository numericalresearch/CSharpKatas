using System.Text;

namespace CSharpKatas;

public class Functions
{
    public static bool is_prime(int n)
    {
        switch (n)
        {
            case 0:
            case 1:
                return false;
            case 2:
            case 3:
            case 5:
            case 7:
                return true;
        }

        if (n % 2 == 0)
            return false;

        for (int d = 3; d <= n / 2; d += 2)
        {
            if (n % d == 0)
                return false;
        }

        return true;
    }
    
    // can I do a sieve of erasthotenes in LINQ 
    public static IEnumerable<int> PrimesBelow(int n)
    {
        // this works, but is horribly inefficient
        var x = Enumerable.Range(2, n).Where(x => x % 2 == 0).Where(is_prime);
        return x;
    }


    private static Dictionary<char, char> _toClose = new Dictionary<char, char>()
    {
        ['['] = ']',
        ['{'] = '}',
        ['('] = ')'
    };
    public static bool IsBalanced(string s)
    {
        var closeSymbols = new HashSet<char>(_toClose.Values);
        
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            char closingBracket;
            if (_toClose.TryGetValue(c, out closingBracket))
            {
                stack.Push(closingBracket);
            }
            else if (closeSymbols.Contains(c))
            {
                if (stack.Count == 0)
                    return false;

                if (c != stack.Peek())
                    return false;

                stack.Pop();
            }
        }
        
        return stack.Count == 0;
    }
}