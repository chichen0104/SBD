﻿using System.Threading.Tasks;
using SBD.Domain.Models;

namespace SBD.Domain.Interface
{
    public interface ISBDService
    {
        //取得登機證資訊
        BoardingPass GetBoardingPassData(string scaneString);
        //取得假的登機證資訊
        BoardingPass CreateFakeBoardingPassData();
        //取得航班資訊
        Flight GetFlightDetail(string flightNumber);
        //取得航空公司規定的行李尺寸
        Task<int?> GetAirlineLuggageSize(string Airline);
        //取得航空公司規定的行李重量
        Task<int?> GetAirlineLuggageWeight(string Airline);
        //取得行李尺寸
        Task<LuggageSize> GetLuggageSize();
        //取得行李重量
        Task<int?> GetLuggageWieght();
        //列印行李條貼紙
        Task<bool?> PrintLuggageSticker();
        //列印收據
        Task<bool?> PrintReceipt();
        //列印優惠券
        Task<bool?> PrintCoupon();
    }
}