// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int mid;
        int h = n;
        int l = 1;
        while (h > l)
        {
            mid = l + (h - l) / 2;
            if (IsBadVersion(mid))
            {
                h = mid;

            }
            else
            {
                l = mid + 1;
            }

        }
        return h;
    }
}