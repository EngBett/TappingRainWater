using System;

namespace TappingRainWater
{
    public class Solution {
        public static int Trap(int[] height) {
            var l=0;
            var r=height.Length-1;
            var rightMax=height[r];
            var leftMax=height[l];
        
            var waterVolume=0;
        
            while(l<r){
                if(rightMax>leftMax){
                    l++;
                    var vol = leftMax - height[l];
                    waterVolume += vol<0?0:vol;
                    leftMax=Math.Max(leftMax,height[l]);
                }else{
                    r--;
                    var vol = rightMax - height[r];
                    waterVolume += vol<0?0:vol;
                    rightMax=Math.Max(rightMax,height[r]);
                }
            }
        
            return waterVolume;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var height = new[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            var expected = 6;
            var actual = Solution.Trap(height);

            Console.WriteLine(actual==expected);
        }
    }
}