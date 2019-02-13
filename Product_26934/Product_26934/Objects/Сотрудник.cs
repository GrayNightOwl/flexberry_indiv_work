﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_26934
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудник.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудник CustomAttributes)

    // *** End programmer edit section *** (Сотрудник CustomAttributes)
    [BusinessServer("IIS.Product_26934.СотрудникБС, Product_26934.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "ФИО",
            "ДатаРождения",
            "Паспорт",
            "Адрес",
            "Должность",
            "CreateTime",
            "Creator",
            "EditTime",
            "Editor"})]
    [View("v3_СотрудникE", new string[] {
            "ФИО as \'ФИО\'",
            "ДатаРождения as \'Дата рождения\'",
            "Паспорт as \'Паспорт\'",
            "Адрес as \'Адрес\'",
            "Должность as \'Должность\'"})]
    [AssociatedDetailViewAttribute("v3_СотрудникE", "ИсторияОкладов", "v3_ИсторияОкладовE", true, "", "История окладов", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("v3_СотрудникE", "СписокАттестаций", "v3_СписокАттестацийE", true, "", "Список аттестаций", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("v3_СотрудникE", "РабочийПериод", "v3_РабочийПериодE", true, "", "Рабочий период", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("v3_СотрудникE", "ИсторияРуководителей", "v3_ИсторияРуководителейE", true, "", "История руководителей", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("v3_СотрудникE", "СотрудникПроект", "v3_СотрудникПроектE", true, "", "Сотрудник проект", true, new string[] {
            ""})]
    [View("v3_СотрудникL", new string[] {
            "ФИО as \'ФИО\'",
            "ДатаРождения as \'Дата рождения\'",
            "Паспорт as \'Паспорт\'",
            "Адрес as \'Адрес\'",
            "Должность as \'Должность\'",
            "CreateTime as \'Создание\'",
            "Creator as \'Создатель\'",
            "EditTime as \'Редактирование\'",
            "Editor as \'Редактор\'"})]
    public class Сотрудник : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fФИО;
        
        private System.DateTime fДатаРождения;
        
        private string fПаспорт;
        
        private string fАдрес;
        
        private string fДолжность;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private IIS.Product_26934.DetailArrayOfИсторияОкладов fИсторияОкладов;
        
        private IIS.Product_26934.DetailArrayOfСписокАттестаций fСписокАттестаций;
        
        private IIS.Product_26934.DetailArrayOfРабочийПериод fРабочийПериод;
        
        private IIS.Product_26934.DetailArrayOfИсторияРуководителей fИсторияРуководителей;
        
        private IIS.Product_26934.DetailArrayOfСотрудникПроект fСотрудникПроект;
        
        // *** Start programmer edit section *** (Сотрудник CustomMembers)

        // *** End programmer edit section *** (Сотрудник CustomMembers)

        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ФИО CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ФИО Get start)

                // *** End programmer edit section *** (Сотрудник.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Сотрудник.ФИО Get end)

                // *** End programmer edit section *** (Сотрудник.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ФИО Set start)

                // *** End programmer edit section *** (Сотрудник.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Сотрудник.ФИО Set end)

                // *** End programmer edit section *** (Сотрудник.ФИО Set end)
            }
        }
        
        /// <summary>
        /// ДатаРождения.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ДатаРождения CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ДатаРождения CustomAttributes)
        public virtual System.DateTime ДатаРождения
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Get start)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Get start)
                System.DateTime result = this.fДатаРождения;
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Get end)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Set start)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Set start)
                this.fДатаРождения = value;
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Set end)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Set end)
            }
        }
        
        /// <summary>
        /// Паспорт.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Паспорт CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Паспорт CustomAttributes)
        [StrLen(255)]
        public virtual string Паспорт
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Паспорт Get start)

                // *** End programmer edit section *** (Сотрудник.Паспорт Get start)
                string result = this.fПаспорт;
                // *** Start programmer edit section *** (Сотрудник.Паспорт Get end)

                // *** End programmer edit section *** (Сотрудник.Паспорт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Паспорт Set start)

                // *** End programmer edit section *** (Сотрудник.Паспорт Set start)
                this.fПаспорт = value;
                // *** Start programmer edit section *** (Сотрудник.Паспорт Set end)

                // *** End programmer edit section *** (Сотрудник.Паспорт Set end)
            }
        }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Адрес CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Адрес Get start)

                // *** End programmer edit section *** (Сотрудник.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Сотрудник.Адрес Get end)

                // *** End programmer edit section *** (Сотрудник.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Адрес Set start)

                // *** End programmer edit section *** (Сотрудник.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Сотрудник.Адрес Set end)

                // *** End programmer edit section *** (Сотрудник.Адрес Set end)
            }
        }
        
        /// <summary>
        /// Должность.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Должность CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Должность CustomAttributes)
        [StrLen(255)]
        public virtual string Должность
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Должность Get start)

                // *** End programmer edit section *** (Сотрудник.Должность Get start)
                string result = this.fДолжность;
                // *** Start programmer edit section *** (Сотрудник.Должность Get end)

                // *** End programmer edit section *** (Сотрудник.Должность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Должность Set start)

                // *** End programmer edit section *** (Сотрудник.Должность Set start)
                this.fДолжность = value;
                // *** Start programmer edit section *** (Сотрудник.Должность Set end)

                // *** End programmer edit section *** (Сотрудник.Должность Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.CreateTime CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.CreateTime Get start)

                // *** End programmer edit section *** (Сотрудник.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (Сотрудник.CreateTime Get end)

                // *** End programmer edit section *** (Сотрудник.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.CreateTime Set start)

                // *** End programmer edit section *** (Сотрудник.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (Сотрудник.CreateTime Set end)

                // *** End programmer edit section *** (Сотрудник.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Creator CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Creator Get start)

                // *** End programmer edit section *** (Сотрудник.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (Сотрудник.Creator Get end)

                // *** End programmer edit section *** (Сотрудник.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Creator Set start)

                // *** End programmer edit section *** (Сотрудник.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (Сотрудник.Creator Set end)

                // *** End programmer edit section *** (Сотрудник.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.EditTime CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.EditTime Get start)

                // *** End programmer edit section *** (Сотрудник.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (Сотрудник.EditTime Get end)

                // *** End programmer edit section *** (Сотрудник.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.EditTime Set start)

                // *** End programmer edit section *** (Сотрудник.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (Сотрудник.EditTime Set end)

                // *** End programmer edit section *** (Сотрудник.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Editor CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Editor Get start)

                // *** End programmer edit section *** (Сотрудник.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (Сотрудник.Editor Get end)

                // *** End programmer edit section *** (Сотрудник.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Editor Set start)

                // *** End programmer edit section *** (Сотрудник.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (Сотрудник.Editor Set end)

                // *** End programmer edit section *** (Сотрудник.Editor Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ИсторияОкладов CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ИсторияОкладов CustomAttributes)
        public virtual IIS.Product_26934.DetailArrayOfИсторияОкладов ИсторияОкладов
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ИсторияОкладов Get start)

                // *** End programmer edit section *** (Сотрудник.ИсторияОкладов Get start)
                if ((this.fИсторияОкладов == null))
                {
                    this.fИсторияОкладов = new IIS.Product_26934.DetailArrayOfИсторияОкладов(this);
                }
                IIS.Product_26934.DetailArrayOfИсторияОкладов result = this.fИсторияОкладов;
                // *** Start programmer edit section *** (Сотрудник.ИсторияОкладов Get end)

                // *** End programmer edit section *** (Сотрудник.ИсторияОкладов Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ИсторияОкладов Set start)

                // *** End programmer edit section *** (Сотрудник.ИсторияОкладов Set start)
                this.fИсторияОкладов = value;
                // *** Start programmer edit section *** (Сотрудник.ИсторияОкладов Set end)

                // *** End programmer edit section *** (Сотрудник.ИсторияОкладов Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.СписокАттестаций CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.СписокАттестаций CustomAttributes)
        public virtual IIS.Product_26934.DetailArrayOfСписокАттестаций СписокАттестаций
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.СписокАттестаций Get start)

                // *** End programmer edit section *** (Сотрудник.СписокАттестаций Get start)
                if ((this.fСписокАттестаций == null))
                {
                    this.fСписокАттестаций = new IIS.Product_26934.DetailArrayOfСписокАттестаций(this);
                }
                IIS.Product_26934.DetailArrayOfСписокАттестаций result = this.fСписокАттестаций;
                // *** Start programmer edit section *** (Сотрудник.СписокАттестаций Get end)

                // *** End programmer edit section *** (Сотрудник.СписокАттестаций Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.СписокАттестаций Set start)

                // *** End programmer edit section *** (Сотрудник.СписокАттестаций Set start)
                this.fСписокАттестаций = value;
                // *** Start programmer edit section *** (Сотрудник.СписокАттестаций Set end)

                // *** End programmer edit section *** (Сотрудник.СписокАттестаций Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.РабочийПериод CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.РабочийПериод CustomAttributes)
        public virtual IIS.Product_26934.DetailArrayOfРабочийПериод РабочийПериод
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.РабочийПериод Get start)

                // *** End programmer edit section *** (Сотрудник.РабочийПериод Get start)
                if ((this.fРабочийПериод == null))
                {
                    this.fРабочийПериод = new IIS.Product_26934.DetailArrayOfРабочийПериод(this);
                }
                IIS.Product_26934.DetailArrayOfРабочийПериод result = this.fРабочийПериод;
                // *** Start programmer edit section *** (Сотрудник.РабочийПериод Get end)

                // *** End programmer edit section *** (Сотрудник.РабочийПериод Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.РабочийПериод Set start)

                // *** End programmer edit section *** (Сотрудник.РабочийПериод Set start)
                this.fРабочийПериод = value;
                // *** Start programmer edit section *** (Сотрудник.РабочийПериод Set end)

                // *** End programmer edit section *** (Сотрудник.РабочийПериод Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ИсторияРуководителей CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ИсторияРуководителей CustomAttributes)
        public virtual IIS.Product_26934.DetailArrayOfИсторияРуководителей ИсторияРуководителей
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ИсторияРуководителей Get start)

                // *** End programmer edit section *** (Сотрудник.ИсторияРуководителей Get start)
                if ((this.fИсторияРуководителей == null))
                {
                    this.fИсторияРуководителей = new IIS.Product_26934.DetailArrayOfИсторияРуководителей(this);
                }
                IIS.Product_26934.DetailArrayOfИсторияРуководителей result = this.fИсторияРуководителей;
                // *** Start programmer edit section *** (Сотрудник.ИсторияРуководителей Get end)

                // *** End programmer edit section *** (Сотрудник.ИсторияРуководителей Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ИсторияРуководителей Set start)

                // *** End programmer edit section *** (Сотрудник.ИсторияРуководителей Set start)
                this.fИсторияРуководителей = value;
                // *** Start programmer edit section *** (Сотрудник.ИсторияРуководителей Set end)

                // *** End programmer edit section *** (Сотрудник.ИсторияРуководителей Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.СотрудникПроект CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.СотрудникПроект CustomAttributes)
        public virtual IIS.Product_26934.DetailArrayOfСотрудникПроект СотрудникПроект
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.СотрудникПроект Get start)

                // *** End programmer edit section *** (Сотрудник.СотрудникПроект Get start)
                if ((this.fСотрудникПроект == null))
                {
                    this.fСотрудникПроект = new IIS.Product_26934.DetailArrayOfСотрудникПроект(this);
                }
                IIS.Product_26934.DetailArrayOfСотрудникПроект result = this.fСотрудникПроект;
                // *** Start programmer edit section *** (Сотрудник.СотрудникПроект Get end)

                // *** End programmer edit section *** (Сотрудник.СотрудникПроект Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.СотрудникПроект Set start)

                // *** End programmer edit section *** (Сотрудник.СотрудникПроект Set start)
                this.fСотрудникПроект = value;
                // *** Start programmer edit section *** (Сотрудник.СотрудникПроект Set end)

                // *** End programmer edit section *** (Сотрудник.СотрудникПроект Set end)
            }
        }
        
        // *** Start programmer edit section *** (Сотрудник.УволитьСотрудника CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.УволитьСотрудника CustomAttributes)
        [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
        public virtual void УволитьСотрудника()
        {
            // *** Start programmer edit section *** (Сотрудник.УволитьСотрудника method implementation)
            return;
            // *** End programmer edit section *** (Сотрудник.УволитьСотрудника method implementation)
        }
        
        // *** Start programmer edit section *** (Сотрудник.СформироватьОтчёт CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.СформироватьОтчёт CustomAttributes)
        [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
        public virtual void СформироватьОтчёт()
        {
            // *** Start programmer edit section *** (Сотрудник.СформироватьОтчёт method implementation)
            return;
            // *** End programmer edit section *** (Сотрудник.СформироватьОтчёт method implementation)
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.Product_26934.Сотрудник));
                }
            }
            
            /// <summary>
            /// "v3_СотрудникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View v3_СотрудникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("v3_СотрудникE", typeof(IIS.Product_26934.Сотрудник));
                }
            }
            
            /// <summary>
            /// "v3_СотрудникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View v3_СотрудникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("v3_СотрудникL", typeof(IIS.Product_26934.Сотрудник));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
}
