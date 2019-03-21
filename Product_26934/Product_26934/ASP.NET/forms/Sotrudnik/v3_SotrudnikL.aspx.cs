﻿/*flexberryautogenerated="false"*/
namespace IIS.Product_26934
{
    using System;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Windows.Forms;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
    using ICSSoft.STORMNET.Business;
    using Resources;
    using ClosedXML.Report;
    using ClosedXML.Excel;
    using System.Linq;
    using System.Collections.Generic;
    using GemBox.Spreadsheet;
    using GemBox.Spreadsheet.Charts;

    public partial class v3_СотрудникL : BaseListForm<Сотрудник>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public v3_СотрудникL() : base(Сотрудник.Views.v3_СотрудникL)
        {
            EditPage = v3_СотрудникE.FormPath;
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Sotrudnik/v3_SotrudnikL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        protected class statusUptimeClass
        {
            public List<string> Status = new List<string>();
            public List<TimeSpan> uptime = new List<TimeSpan>();
        }

        protected class statusTimeInHour
        {
            public string Должность;
            public double среднееВремяРаботы;
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
            // *** Start programmer edit section *** (PostLoad)

            ExternalLangDef ldef = ICSSoft.STORMNET.Windows.Forms.ExternalLangDef.LanguageDef;
            LoadingCustomizationStruct lcsСервер = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), "v3_СотрудникE");
            lcsСервер.LoadingTypes = new[] { typeof(Сотрудник) };
            View view = Information.GetView("v3_ИсторияРуководителейE", typeof(ИсторияРуководителей));
            var dvd = new ICSSoft.STORMNET.Windows.Forms.DetailVariableDef
            {
                ConnectMasterPorp = nameof(ИсторияРуководителей.ИсторияСотрудника),
                OwnerConnectProp = new[] { SQLWhereLanguageDef.StormMainObjectKey },
                View = view,
                Type = ldef.GetObjectType("Details")
            };
            lcsСервер.LimitFunction = ldef.GetFunction(ldef.funcExist,
                                                        dvd,
                                                        ldef.GetFunction(ldef.funcEQ,
                                                                        new VariableDef(ldef.StringType, "Руководитель.Agent.Login"),
                                                                        User.Identity.Name));
            DataObject[] dobjsСервер = DataServiceProvider.DataService.LoadObjects(lcsСервер);
            WebObjectListView1.LimitFunction = lcsСервер.LimitFunction;


            // *** End programmer edit section *** (PostLoad)
        }


        protected void AuditBtn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("~/flexberry/AuditEntitiesList/");
        }


    }
}
