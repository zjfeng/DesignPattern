using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式
{
    internal abstract class Beverage
    {
        public readonly decimal[] SizeCost = new decimal[] { 0.1M, 0.15M, 0.2M };
        public List<string> Description { get; set; } = new List<string>();
        public Size Size { get; set; }
        public abstract decimal Cost();

        public List<string> CountAndFormatStrings(List<string> arr)
        {
            // 使用Dictionary统计每个字符串出现的次数
            Dictionary<string, int> countDict = new Dictionary<string, int>();
            foreach (string str in arr)
            {
                if (Enum.GetNames(typeof(Size)).Contains(str) && countDict.ContainsKey(str))
                {
                    continue;
                }
                if (countDict.ContainsKey(str))
                {
                    countDict[str]++;
                }
                else
                {
                    countDict[str] = 1;
                }
            }

            // 格式化输出结果
            List<string> result = new List<string>();
            foreach (var pair in countDict)
            {
                if (pair.Value > 1)
                {
                    result.Add($"{pair.Key}*{pair.Value}");
                }
                else
                {
                    result.Add(pair.Key);
                }
            }

            return result;
        }
    }

    public enum Size
    {
        S,M,L
    }

    

}
