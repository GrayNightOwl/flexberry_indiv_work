﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_26934
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class v3_ПроектL : BaseListForm<Проект>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public v3_ПроектL() : base(Проект.Views.v3_ПроектL)
        {
            EditPage = v3_ПроектE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Proekt/v3_ProektL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }


        protected void AuditBtn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //Response.Redirect("~/flexberry/AuditEntitiesList/");
            Response.Redirect("/BarController/");
        }


    }
}
