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
    /// Сотрудник проект.
    /// </summary>
    // *** Start programmer edit section *** (СотрудникПроект CustomAttributes)

    // *** End programmer edit section *** (СотрудникПроект CustomAttributes)
    [AutoAltered()]
    [Caption("Сотрудник проект")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "ДатаПодключения as \'Дата подключения\'",
            "ДатаВыхода as \'Дата выхода\'",
            "РольВПроекте as \'Роль в проекте\'",
            "Примечания as \'Примечания\'",
            "Проект as \'Проект\'",
            "Проект.Название as \'Название\'"}, Hidden=new string[] {
            "Проект.Название"})]
    [MasterViewDefineAttribute("AuditView", "Проект", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("v3_СотрудникПроектE", new string[] {
            "ДатаПодключения as \'Дата подключения\'",
            "ДатаВыхода as \'Дата выхода\'",
            "РольВПроекте as \'Роль в проекте\'",
            "Примечания as \'Примечания\'",
            "Проект as \'Проект\'",
            "Проект.Название as \'Название\'"}, Hidden=new string[] {
            "Проект.Название"})]
    [MasterViewDefineAttribute("v3_СотрудникПроектE", "Проект", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    public class СотрудникПроект : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private System.DateTime fДатаПодключения;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fДатаВыхода;
        
        private string fРольВПроекте;
        
        private string fПримечания;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private IIS.Product_26934.Проект fПроект;
        
        private IIS.Product_26934.Сотрудник fПроектыСотрудника;
        
        // *** Start programmer edit section *** (СотрудникПроект CustomMembers)

        // *** End programmer edit section *** (СотрудникПроект CustomMembers)

        
        /// <summary>
        /// ДатаПодключения.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.ДатаПодключения CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.ДатаПодключения CustomAttributes)
        public virtual System.DateTime ДатаПодключения
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.ДатаПодключения Get start)

                // *** End programmer edit section *** (СотрудникПроект.ДатаПодключения Get start)
                System.DateTime result = this.fДатаПодключения;
                // *** Start programmer edit section *** (СотрудникПроект.ДатаПодключения Get end)

                // *** End programmer edit section *** (СотрудникПроект.ДатаПодключения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.ДатаПодключения Set start)

                // *** End programmer edit section *** (СотрудникПроект.ДатаПодключения Set start)
                this.fДатаПодключения = value;
                // *** Start programmer edit section *** (СотрудникПроект.ДатаПодключения Set end)

                // *** End programmer edit section *** (СотрудникПроект.ДатаПодключения Set end)
            }
        }
        
        /// <summary>
        /// ДатаВыхода.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.ДатаВыхода CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.ДатаВыхода CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ДатаВыхода
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.ДатаВыхода Get start)

                // *** End programmer edit section *** (СотрудникПроект.ДатаВыхода Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fДатаВыхода;
                // *** Start programmer edit section *** (СотрудникПроект.ДатаВыхода Get end)

                // *** End programmer edit section *** (СотрудникПроект.ДатаВыхода Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.ДатаВыхода Set start)

                // *** End programmer edit section *** (СотрудникПроект.ДатаВыхода Set start)
                this.fДатаВыхода = value;
                // *** Start programmer edit section *** (СотрудникПроект.ДатаВыхода Set end)

                // *** End programmer edit section *** (СотрудникПроект.ДатаВыхода Set end)
            }
        }
        
        /// <summary>
        /// РольВПроекте.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.РольВПроекте CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.РольВПроекте CustomAttributes)
        [StrLen(255)]
        public virtual string РольВПроекте
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.РольВПроекте Get start)

                // *** End programmer edit section *** (СотрудникПроект.РольВПроекте Get start)
                string result = this.fРольВПроекте;
                // *** Start programmer edit section *** (СотрудникПроект.РольВПроекте Get end)

                // *** End programmer edit section *** (СотрудникПроект.РольВПроекте Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.РольВПроекте Set start)

                // *** End programmer edit section *** (СотрудникПроект.РольВПроекте Set start)
                this.fРольВПроекте = value;
                // *** Start programmer edit section *** (СотрудникПроект.РольВПроекте Set end)

                // *** End programmer edit section *** (СотрудникПроект.РольВПроекте Set end)
            }
        }
        
        /// <summary>
        /// Примечания.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.Примечания CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.Примечания CustomAttributes)
        [StrLen(255)]
        public virtual string Примечания
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.Примечания Get start)

                // *** End programmer edit section *** (СотрудникПроект.Примечания Get start)
                string result = this.fПримечания;
                // *** Start programmer edit section *** (СотрудникПроект.Примечания Get end)

                // *** End programmer edit section *** (СотрудникПроект.Примечания Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.Примечания Set start)

                // *** End programmer edit section *** (СотрудникПроект.Примечания Set start)
                this.fПримечания = value;
                // *** Start programmer edit section *** (СотрудникПроект.Примечания Set end)

                // *** End programmer edit section *** (СотрудникПроект.Примечания Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.CreateTime CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.CreateTime Get start)

                // *** End programmer edit section *** (СотрудникПроект.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (СотрудникПроект.CreateTime Get end)

                // *** End programmer edit section *** (СотрудникПроект.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.CreateTime Set start)

                // *** End programmer edit section *** (СотрудникПроект.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (СотрудникПроект.CreateTime Set end)

                // *** End programmer edit section *** (СотрудникПроект.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.Creator CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.Creator Get start)

                // *** End programmer edit section *** (СотрудникПроект.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (СотрудникПроект.Creator Get end)

                // *** End programmer edit section *** (СотрудникПроект.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.Creator Set start)

                // *** End programmer edit section *** (СотрудникПроект.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (СотрудникПроект.Creator Set end)

                // *** End programmer edit section *** (СотрудникПроект.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.EditTime CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.EditTime Get start)

                // *** End programmer edit section *** (СотрудникПроект.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (СотрудникПроект.EditTime Get end)

                // *** End programmer edit section *** (СотрудникПроект.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.EditTime Set start)

                // *** End programmer edit section *** (СотрудникПроект.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (СотрудникПроект.EditTime Set end)

                // *** End programmer edit section *** (СотрудникПроект.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.Editor CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.Editor Get start)

                // *** End programmer edit section *** (СотрудникПроект.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (СотрудникПроект.Editor Get end)

                // *** End programmer edit section *** (СотрудникПроект.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.Editor Set start)

                // *** End programmer edit section *** (СотрудникПроект.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (СотрудникПроект.Editor Set end)

                // *** End programmer edit section *** (СотрудникПроект.Editor Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник проект.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.Проект CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.Проект CustomAttributes)
        [PropertyStorage(new string[] {
                "Проект"})]
        [NotNull()]
        public virtual IIS.Product_26934.Проект Проект
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.Проект Get start)

                // *** End programmer edit section *** (СотрудникПроект.Проект Get start)
                IIS.Product_26934.Проект result = this.fПроект;
                // *** Start programmer edit section *** (СотрудникПроект.Проект Get end)

                // *** End programmer edit section *** (СотрудникПроект.Проект Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.Проект Set start)

                // *** End programmer edit section *** (СотрудникПроект.Проект Set start)
                this.fПроект = value;
                // *** Start programmer edit section *** (СотрудникПроект.Проект Set end)

                // *** End programmer edit section *** (СотрудникПроект.Проект Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Product_26934.Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (СотрудникПроект.ПроектыСотрудника CustomAttributes)

        // *** End programmer edit section *** (СотрудникПроект.ПроектыСотрудника CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ПроектыСотрудника"})]
        public virtual IIS.Product_26934.Сотрудник ПроектыСотрудника
        {
            get
            {
                // *** Start programmer edit section *** (СотрудникПроект.ПроектыСотрудника Get start)

                // *** End programmer edit section *** (СотрудникПроект.ПроектыСотрудника Get start)
                IIS.Product_26934.Сотрудник result = this.fПроектыСотрудника;
                // *** Start programmer edit section *** (СотрудникПроект.ПроектыСотрудника Get end)

                // *** End programmer edit section *** (СотрудникПроект.ПроектыСотрудника Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СотрудникПроект.ПроектыСотрудника Set start)

                // *** End programmer edit section *** (СотрудникПроект.ПроектыСотрудника Set start)
                this.fПроектыСотрудника = value;
                // *** Start programmer edit section *** (СотрудникПроект.ПроектыСотрудника Set end)

                // *** End programmer edit section *** (СотрудникПроект.ПроектыСотрудника Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.Product_26934.СотрудникПроект));
                }
            }
            
            /// <summary>
            /// "v3_СотрудникПроектE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View v3_СотрудникПроектE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("v3_СотрудникПроектE", typeof(IIS.Product_26934.СотрудникПроект));
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
    /// Detail array of СотрудникПроект.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСотрудникПроект CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСотрудникПроект CustomAttributes)
    public class DetailArrayOfСотрудникПроект : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Product_26934.DetailArrayOfСотрудникПроект members)

        // *** End programmer edit section *** (IIS.Product_26934.DetailArrayOfСотрудникПроект members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type СотрудникПроект by index.
        /// </summary>
        /// <summary>
        /// Adds object with type СотрудникПроект.
        /// </summary>
        public DetailArrayOfСотрудникПроект(IIS.Product_26934.Сотрудник fСотрудник) : 
                base(typeof(СотрудникПроект), ((ICSSoft.STORMNET.DataObject)(fСотрудник)))
        {
        }
        
        public IIS.Product_26934.СотрудникПроект this[int index]
        {
            get
            {
                return ((IIS.Product_26934.СотрудникПроект)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Product_26934.СотрудникПроект dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
