using Microsoft.WindowsAzure.Mobile.Service;

namespace mosheMposService.DataObjects
{
    public class mPosInstallatCoode : EntityData
    {
        public string InstallationCode { get; set; } // iCode => the row
        public bool CodeStatus { get; set; }
        public int Designation { get; set; } //What is iCode for? 1-Activation 2-Updates 3-either
        public int Stage { get; set; }       // current processing stage for the iCode? 0-Waiting to be processed 1-Still processing 2-Auto completed 3-manual completed
        public int Event { get; set; }       // stage in a chain of processing (eg synchronization with Azure DB) 0-Waiting 1-Finished no errors 2-Finished with errors 3-iCode was superceded
        public int Counter { get; set; }     // number of times the iCode has been retrieved
        public int Repeatability { get; set; } // number of times the iCode may be retrieved 0-infinite 1<=the number indicated
        public int Restrictions { get; set; }  // 0-no restriction 1-only for new installations 2-must match TerminalID                    
        public int MerchantStatus { get; set; } // 0-remain anonymous 1-become/remain registered/known
        public int TerminalStatus { get; set; } // 0-become/remain inactive 1-remain active
        public string PrimaryTerminalNumber { get; set; } //blank if row data for multiple terminals
        public string PrimaryMerchantNumber { get; set; } //blank if row data for multiple merchants
        public string SecondaryTerminalNumber { get; set; } // ditto
        public string SecondaryMerchantNumber { get; set; } // ditto
        public string Country { get; set; }
        public string Currency { get; set; }
        public bool CurnSymbolInFront { get; set; }
        public string bucksGOMerchantNumber { get; set; }
        public string DestinationTransactionServer { get; set; }
        public string ProductListID { get; set; } // a filename that contains a xml list of products
        public string BankingListID { get; set; } // an identifier to retrieve banks information from mPosAllLists...may be blank
        public string ReportListID { get; set; }  // an identifier to retrieve report links from mPosAllLists...may be blank
        public string SupportListID { get; set; } // an identifier to retrieve support information from mPosAllLists...may be blank
        public string HelpListID { get; set; }    // an identifier to retrieve help file names from mPosAllLists...may be blank
    }

}