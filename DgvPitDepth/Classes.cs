using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgvPitDepth
{
    public class FFSPvCsPtSp
    {
        public enum Location // Location (Same / Opposite side with designated part)
        {
            Same = 0,
            Opposite = 1
        }

        public Location CurrentLocation; // 현재 Location
        public int RowNum;               // 행의 개수
        public SortedList<int, object[]> Values = new SortedList<int, object[]>();
        public double MaxPitDepth = 0.0; // Maximum Pit depth for same side, Wmax-same
    }

    public static class Formula
    {
        public static FFSPvCsPtSp ffsPvCsPtSp = new FFSPvCsPtSp();

        public static FFSPvCsPtSp GetQFactor(FFSPvCsPtSp NewFFSPvCsPtSp)
        {
            // 입력값을 출력값에 대입한다.
            ffsPvCsPtSp = NewFFSPvCsPtSp;

            // Maximum Pit depth for same side, Wmax-same 값을 구한다.
            // Location이 Samed인 Pitting 깊이들 중 최대값을 구한다.
            for (int i = 0; i < ffsPvCsPtSp.Values.Count; i++)
            {
                if (ffsPvCsPtSp.Values[i][1].ToString() == "Same" )
                {
                    if (Convert.ToDouble(ffsPvCsPtSp.Values[i][0]) > ffsPvCsPtSp.MaxPitDepth)
                    {
                        ffsPvCsPtSp.MaxPitDepth = Convert.ToDouble(ffsPvCsPtSp.Values[i][0]);
                    } 
                }
            }
            // Minimum Thickness reading for PitwithMaximum Depth for same side 값을 구한다.
            // Maximum Pit depth for opposite side 값을 구한다.
            // Minimum Thickness reading for Pit with Maximum Depth 값을 구한다.
            // Norminal Thickness in the region of corrosion corrected for FCAml 값을 구한다.
            // Inside Diameter for shell corrected for FCAml 값을 구한다.
            // Remaining thickness ratio, Rwt-same 값을 구한다.
            // Remaining thickness ratio, Rwt-opposite 값을 구한다.
            // Q factor, Q-same 값을 구한다.
            // Q factor, Q-other 값을 구한다.
            return ffsPvCsPtSp;
        }
    }
}
