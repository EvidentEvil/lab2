using System;
using System.Collections.Generic;

namespace Backend1.Models
{
    public class CalcModel
    {
        public int _firstInt { get; set; }
        public int _secondInt { get; set; }
        public string _action { get; set; }

        public Dictionary<string, string> calculate(int? firstInt, string action, int? secondInt)
        {
            string ans = "";
            int? tmp = 0;
            switch (action)
            {
                case "add":
                    tmp = firstInt + secondInt;
                    ans = tmp.ToString();
                    action = "+";
                    break;
                case "sub":
                    tmp = firstInt - secondInt;
                    ans = tmp.ToString();
                    action = "-";
                    break;
                case "mult":
                    tmp = firstInt * secondInt;
                    ans = tmp.ToString();
                    action = "*";
                    break;
                case "div":
                    if (secondInt == 0) {
                        ans = "error";
                    } else {
                        tmp = firstInt / secondInt;
                        ans = tmp.ToString();
                    }
                    action = "/";
                    break;
            }
            Dictionary<string, string> ansArray = new Dictionary<string, string>();
            ansArray.Add("action", action);
            ansArray.Add("answer", ans);

            return ansArray;
        }
    }
}
