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

        protected void ReportBtn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            var langdef = ExternalLangDef.LanguageDef;
            var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), Сотрудник.Views.v3_СотрудникL);
            lcs.LimitFunction = langdef.GetFunction(langdef.funcEQ, new VariableDef(langdef.StringType, Information.ExtractPropertyPath<Сотрудник>(x => x.Должность)), "Руководитель");
            var сотрудникиРуководители = DataServiceProvider.DataService.LoadObjects(lcs);
        }
        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
            // *** Start programmer edit section *** (PostLoad)

            //ExternalLangDef ldef = ICSSoft.STORMNET.Windows.Forms.ExternalLangDef.LanguageDef;
            //LoadingCustomizationStruct lcsСервер = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), "v3_СотрудникE");
            //lcsСервер.LoadingTypes = new[] { typeof(Сотрудник) };
            //View view = Information.GetView("v3_ИсторияРуководителейE", typeof(ИсторияРуководителей));
            //var dvd = new ICSSoft.STORMNET.Windows.Forms.DetailVariableDef
            //{
            //    ConnectMasterPorp = nameof(ИсторияРуководителей.ИсторияСотрудника),
            //    OwnerConnectProp = new[] { SQLWhereLanguageDef.StormMainObjectKey },
            //    View = view,
            //    Type = ldef.GetObjectType("Details")
            //};
            //lcsСервер.LimitFunction = ldef.GetFunction(ldef.funcExist,
            //                                            dvd,
            //                                            ldef.GetFunction(ldef.funcEQ,
            //                                                            new VariableDef(ldef.StringType, "Руководитель.ФИО"),
            //                                                            User.Identity.Name));
            //DataObject[] dobjsСервер = DataServiceProvider.DataService.LoadObjects(lcsСервер);
            //WebObjectListView1.LimitFunction = lcsСервер.LimitFunction;




            //// User.Identity.Name
            ////var langdef = ExternalLangDef.LanguageDef;
            //var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), Сотрудник.Views.v3_СотрудникE);
            ////lcs.LimitFunction = langdef.GetFunction(langdef.funcEQ,
            ////                new VariableDef(langdef.GuidType, Information.ExtractPropertyPath<Сотрудник>(x => x.)), "64F45BC3-339B-4FBA-A036-C5E9FE9EAE53");
            ////var кредиты = DataServiceProvider.DataService.LoadObjects(lcs);

            //var ld = SQLWhereLanguageDef.LanguageDef;
            //var onlyMenFunction = ld.GetFunction(ld.funcEQ, new VariableDef(ld.StringType,
            //    Information.ExtractPropertyPath<ИсторияРуководителей>(x => x.ИсторияСотрудника.ФИО)), User.Identity.Name);
            //var клиентыФамилияПетров = DataServiceProvider.DataService.LoadObjects(lcs);
            //WebObjectListView1.LimitFunction = onlyMenFunction;

            // *** End programmer edit section *** (PostLoad)
        }

    }
}
