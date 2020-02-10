using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC_2.WebMVC_Code2
{
    public static class Data
    {
        public static List<ItemData> Repo;
        public static void FillData()
        {
            Repo = new List<ItemData>()
            {
                new ItemData{Year=2020,Month=1,Day=1},
                new ItemData{Year=2020,Month=2,Day=2},
                new ItemData{Year=2020,Month=3,Day=3},
                new ItemData{Year=2019,Month=4,Day=4},
                new ItemData{Year=2019,Month=5,Day=5},
                new ItemData{Year=2019,Month=6,Day=6},
            };
        }
    }
    public class ItemData
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}