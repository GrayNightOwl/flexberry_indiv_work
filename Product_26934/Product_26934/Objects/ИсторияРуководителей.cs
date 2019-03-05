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
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// История руководителей.
    /// </summary>
    // *** Start programmer edit section *** (ИсторияРуководителей CustomAttributes)

    // *** End programmer edit section *** (ИсторияРуководителей CustomAttributes)
    [AutoAltered()]
    [Caption("История руководителей")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "НачальнаяДата as \'Начальная дата\'",
            "КонечнаяДата as \'Конечная дата\'",
            "Руководитель as \'Руководитель\'",
            "Руководитель.ФИО as \'ФИО\'"}, Hidden=new string[] {
            "Руководитель.ФИО"})]
    [MasterViewDefineAttribute("AuditView", "Руководитель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [View("v3_ИсторияРуководителейE", new string[] {
            "НачальнаяДата as \'Начальная дата\' on \'|Начальная Дата\\-Дата\'",
            "КонечнаяДата as \'Конечная дата\'",
            "Руководитель as \'Руководитель\'",
            "Руководитель.ФИО as \'ФИО\'",
            "ИсторияСотрудника.Agent",
            "ИсторияСотрудника"}, Hidden=new string[] {
            "Руководитель.ФИО",
            "ИсторияСотрудника.Agent",
            "ИсторияСотрудника"})]
    [MasterViewDefineAttribute("v3_ИсторияРуководителейE", "Руководитель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    public class ИсторияРуководителей : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fНачальнаяДата;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fКонечнаяДата;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private IIS.Product_26934.Сотрудник fРуководитель;
        
        private IIS.Product_26934.Сотрудник fИсторияСотрудника;
        
        // *** Start programmer edit section *** (ИсторияРуководителей CustomMembers)

        // *** End programmer edit section *** (ИсторияРуководителей CustomMembers)

        
        /// <summary>
        /// НачальнаяДата.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.НачальнаяДата CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.НачальнаяДата CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime НачальнаяДата
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.НачальнаяДата Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.НачальнаяДата Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fНачальнаяДата;
                // *** Start programmer edit section *** (ИсторияРуководителей.НачальнаяДата Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.НачальнаяДата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.НачальнаяДата Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.НачальнаяДата Set start)
                this.fНачальнаяДата = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.НачальнаяДата Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.НачальнаяДата Set end)
            }
        }
        
        /// <summary>
        /// КонечнаяДата.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.КонечнаяДата CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.КонечнаяДата CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime КонечнаяДата
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.КонечнаяДата Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.КонечнаяДата Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fКонечнаяДата;
                // *** Start programmer edit section *** (ИсторияРуководителей.КонечнаяДата Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.КонечнаяДата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.КонечнаяДата Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.КонечнаяДата Set start)
                this.fКонечнаяДата = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.КонечнаяДата Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.КонечнаяДата Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.CreateTime CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.CreateTime Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (ИсторияРуководителей.CreateTime Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.CreateTime Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.CreateTime Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.Creator CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.Creator Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (ИсторияРуководителей.Creator Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.Creator Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.Creator Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.EditTime CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.EditTime Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (ИсторияРуководителей.EditTime Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.EditTime Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.EditTime Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.Editor CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.Editor Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (ИсторияРуководителей.Editor Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.Editor Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.Editor Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.Editor Set end)
            }
        }
        
        /// <summary>
        /// История руководителей.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.Руководитель CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.Руководитель CustomAttributes)
        [PropertyStorage(new string[] {
                "Руководитель"})]
        public virtual IIS.Product_26934.Сотрудник Руководитель
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.Руководитель Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.Руководитель Get start)
                IIS.Product_26934.Сотрудник result = this.fРуководитель;
                // *** Start programmer edit section *** (ИсторияРуководителей.Руководитель Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.Руководитель Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.Руководитель Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.Руководитель Set start)
                this.fРуководитель = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.Руководитель Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.Руководитель Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Product_26934.Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника CustomAttributes)

        // *** End programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ИсторияСотрудника"})]
        public virtual IIS.Product_26934.Сотрудник ИсторияСотрудника
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Get start)

                // *** End programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Get start)
                IIS.Product_26934.Сотрудник result = this.fИсторияСотрудника;
                // *** Start programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Get end)

                // *** End programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Set start)

                // *** End programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Set start)
                this.fИсторияСотрудника = value;
                // *** Start programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Set end)

                // *** End programmer edit section *** (ИсторияРуководителей.ИсторияСотрудника Set end)
            }
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.Product_26934.ИсторияРуководителей));
                }
            }
            
            /// <summary>
            /// "v3_ИсторияРуководителейE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View v3_ИсторияРуководителейE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("v3_ИсторияРуководителейE", typeof(IIS.Product_26934.ИсторияРуководителей));
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
    
    /// <summary>
    /// Detail array of ИсторияРуководителей.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfИсторияРуководителей CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfИсторияРуководителей CustomAttributes)
    public class DetailArrayOfИсторияРуководителей : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Product_26934.DetailArrayOfИсторияРуководителей members)

        // *** End programmer edit section *** (IIS.Product_26934.DetailArrayOfИсторияРуководителей members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ИсторияРуководителей by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ИсторияРуководителей.
        /// </summary>
        public DetailArrayOfИсторияРуководителей(IIS.Product_26934.Сотрудник fСотрудник) : 
                base(typeof(ИсторияРуководителей), ((ICSSoft.STORMNET.DataObject)(fСотрудник)))
        {
        }
        
        public IIS.Product_26934.ИсторияРуководителей this[int index]
        {
            get
            {
                return ((IIS.Product_26934.ИсторияРуководителей)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Product_26934.ИсторияРуководителей dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
