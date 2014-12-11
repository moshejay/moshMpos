using Microsoft.WindowsAzure.Mobile.Service;

namespace mosheMposService.DataObjects
{
    public class mPosAllList : EntityData
    {
        public string Identifier { get; set; } // set in mPosInstallationCode
        public string ListType { get; set; }   // what type of list data is in this row
        public bool Active { get; set; }       // is this data usable - allows the same Identifier to be reused
        public int DisplayOrder { get; set; } // used to indicate the position in a display sequence for this data row
        public string MasterText { get; set; }   // bank name for banking, report name for reports, single line of text for support info, help file name
        public string DetailText { get; set; }   // a line of info for banking, complete url for running the report, blank for support, blank for help   
    }
}