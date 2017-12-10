using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ArrivalDetails
    {
        public long ArrivalId { get; set; }
        public long? No20fdis { get; set; }
        public long? No20mdis { get; set; }
        public long? No40fdis { get; set; }
        public long? No40mdis { get; set; }
        public long? NootherDis { get; set; }
        public long? Dg20fdis { get; set; }
        public long? Dg20mdis { get; set; }
        public long? Dg40fdis { get; set; }
        public long? Dg40mdis { get; set; }
        public long? DgotherDis { get; set; }
        public long? Rf20fdis { get; set; }
        public long? Rf20mdis { get; set; }
        public long? Rf40fdis { get; set; }
        public long? Rf40mdis { get; set; }
        public long? RfotherDis { get; set; }
        public long? Og20fdis { get; set; }
        public long? Og20mdis { get; set; }
        public long? Og40fdis { get; set; }
        public long? Og40mdis { get; set; }
        public long? OgotherDis { get; set; }
        public string Dgimcodedis { get; set; }
        public long? No20fload { get; set; }
        public long? No20mload { get; set; }
        public long? No40fload { get; set; }
        public long? No40mload { get; set; }
        public long? NootherLoad { get; set; }
        public long? Dg20fload { get; set; }
        public long? Dg20mload { get; set; }
        public long? Dg40fload { get; set; }
        public long? Dg40mload { get; set; }
        public long? DgotherLoad { get; set; }
        public long? Rf20fload { get; set; }
        public long? Rf20mload { get; set; }
        public long? Rf40fload { get; set; }
        public long? Rf40mload { get; set; }
        public long? RfotherLoad { get; set; }
        public long? Og20fload { get; set; }
        public long? Og20mload { get; set; }
        public long? Og40fload { get; set; }
        public long? Og40mload { get; set; }
        public long? OgotherLoad { get; set; }
        public string Dgimcodeload { get; set; }
        public long? Imp20dis { get; set; }
        public long? Inttran20Dis { get; set; }
        public long? Exttran20Dis { get; set; }
        public long? Tranship20Dis { get; set; }
        public long? DirDelivery20Dis { get; set; }
        public long? Imp40dis { get; set; }
        public long? Inttran40Dis { get; set; }
        public long? Exttran40Dis { get; set; }
        public long? Tranship40Dis { get; set; }
        public long? DirDelivery40Dis { get; set; }
        public long? ExtTran20Load { get; set; }
        public long? Export20Load { get; set; }
        public long? Tranship20Load { get; set; }
        public long? Return20Load { get; set; }
        public long? Empty20Load { get; set; }
        public long? ExtTran40Load { get; set; }
        public long? Export40Load { get; set; }
        public long? Tranship40Load { get; set; }
        public long? Return40Load { get; set; }
        public long? Empty40Load { get; set; }
        public long? Fcl20 { get; set; }
        public long? Fcl40 { get; set; }
        public long? Lcl20 { get; set; }
        public long? Lcl40 { get; set; }
        public string Remarkdet { get; set; }

        public ArrivalNotice Arrival { get; set; }
    }
}
