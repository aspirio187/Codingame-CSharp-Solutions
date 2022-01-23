using System;
using System.Collections.Generic;
using System.Text;

namespace Codingame_Solutions
{
    public class Change
    {
        public long Bill10 { get; set; } = 0;
        public long Bill5 { get; set; } = 0;
        public long Coin2 { get; set; } = 0;
    }

    public static class OptimalChange
    {
        public static Change GetOptimalChange(long s)
        {
            Change change = new Change();

            if (s < 5 && s != 2) return change;

            long m = s % 10;
            if (m != 0 && m < 5 && m != 2)
                change.Bill10 = (s / 10) - 1;
            else
                change.Bill10 = s / 10;

            long x = (s - (change.Bill10 * 10)) % 2;
            if (x > 0) change.Bill5 = x;
            change.Coin2 = (s - (change.Bill10 * 10) - (change.Bill5 * 5)) / 2;

            return change;
        }
    }
}
