using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignallRHub.Models
{
    public class QRDetails
    {

        public int id { get; set; }

        public int DeviceCode { get; set; }
        public string QRNumber { get; set; }
        public string TransactionDateTime { get; set; }
        public string QRJson { get; set; }
        public string LoggedInUser { get; set; }
        public string StationCode { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string LogType { get; set; }
        public bool Sync { get; set; }
        public string TransactionType { get; set; }
        public string FareAmount { get; set; }
        public string Type { get; set; }  //qr
        public string DirectionCode { get; set; }
        public string RouteCode { get; set; }
        public string BusNumber { get; set; }
        public string DeviceType { get; set; }


        //public Guid SingleJourneyTicketID { get; set; }
        //public Guid POSID { get; set; }
        //public string QRNumber { get; set; }
        //public string StationCode { get; set; }
        //public string OrganizationCode { get; set; }
        //public bool IsScanned { get; set; }
        //public string ExpiryTime { get; set; }
        //public string EncryptedTicketID { get; set; }
        //public decimal FareAmount { get; set; }

        //public string StationINCode { get; set; }
        //public bool IsEnter { get; set; }
        //public Int64 ScanInByAppID { get; set; }
        //public string ScanInTime { get; set; }

        //public string StationOUTCode { get; set; }
        //public bool IsOut { get; set; }
        //public Int64 ScanOutByAppID { get; set; }
        //public string ScanOutTime { get; set; }











    }
}
