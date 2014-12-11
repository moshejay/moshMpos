using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using mosheMposService.DataObjects;
using mosheMposService.Models;

namespace mosheMposService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            Database.SetInitializer(new mosheMposInitializer());
        }
    }

    public class mosheMposInitializer : ClearDatabaseSchemaIfModelChanges<mosheMposContext>
    {
        protected override void Seed(mosheMposContext context)
        {
            List<TodoItem> todoItems = new List<TodoItem>
            {
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            };

            foreach (TodoItem todoItem in todoItems)
            {
                context.Set<TodoItem>().Add(todoItem);
            }

            List<mPosAllList> mposAllLists = new List<mPosAllList>
            {
                new mPosAllList {Id = "1", Identifier = "0-seed", ListType = "Seeds", Active = false, DisplayOrder = 0, MasterText = "master text", DetailText = "detailText"},
                new mPosAllList {Id = "2", Identifier = "1-seed", ListType = "Seeds", Active = false, DisplayOrder = 0, MasterText = "master text1", DetailText = "detailText1"},

            };

            foreach (mPosAllList mposAllList in mposAllLists)
            {
                context.Set<mPosAllList>().Add(mposAllList);
            }

            List<mPosInstallatCoode> mposInstallationCodes = new List<mPosInstallatCoode>
            {
                new mPosInstallatCoode {Id = "1", InstallationCode = "0-seed", CodeStatus = false, Designation = 1, Stage = 0, Event = 0, Counter = 0, Repeatability = 1, Restrictions = 2,MerchantStatus = 0, 
                    TerminalStatus = 1, PrimaryTerminalNumber ="ptn", PrimaryMerchantNumber = "pmn", SecondaryTerminalNumber = "stn", SecondaryMerchantNumber = "smn", Country = "NZ", Currency = "$", CurnSymbolInFront = true,
                    bucksGOMerchantNumber = "bgmn", DestinationTransactionServer = "dts", ProductListID = "plID", BankingListID = "blID", ReportListID = "rlID", SupportListID = "slID", HelpListID = "hlID" },
                new mPosInstallatCoode {Id = "2", InstallationCode = "1-seed", CodeStatus = false, Designation = 1, Stage = 0, Event = 0, Counter = 0, Repeatability = 1, Restrictions = 2,MerchantStatus = 0, 
                    TerminalStatus = 1, PrimaryTerminalNumber ="ptn-1", PrimaryMerchantNumber = "pmn-1", SecondaryTerminalNumber = "stn-1", SecondaryMerchantNumber = "smn-1", Country = "NZ", Currency = "$", CurnSymbolInFront = true,
                    bucksGOMerchantNumber = "bgmn-1", DestinationTransactionServer = "dts", ProductListID = "plID", BankingListID = "blID", ReportListID = "rlID", SupportListID = "slID", HelpListID = "hlID" },
            };

            foreach (mPosInstallatCoode mposInstallationCode in mposInstallationCodes)
            {
                context.Set<mPosInstallatCoode>().Add(mposInstallationCode);
            }
            base.Seed(context);
        }
    }
}

