﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Colin.Lottery.Models;

namespace Colin.Lottery.StrategyService
{
    public interface IStrategyService
    {
        /// <summary>
        /// 开始数据分析（默认为北京赛车冠军定位胆）
        /// </summary>
        Task Start();

        /// <summary>
        /// 开始数据分析
        /// </summary>
        /// <param name="typeRules">彩种和玩法</param>
        void Start(Dictionary<LotteryType, List<int>> typeRules);
    }
}