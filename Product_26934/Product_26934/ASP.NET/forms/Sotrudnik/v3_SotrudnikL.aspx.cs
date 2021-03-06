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

        protected void ReportBtn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {




            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY"); //часть, относящаяся к диаграмме
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("BarChart");
            
            var должностьВремя = new statusUptimeClass(); //хранит для КАЖДОГО сотрудника свои должность и время работы
            var списокУникальныхДолжностей = new List<string>(); //список уникальных должностей, заполняется из базы
            var должностьВремяРаботыВЧасах = new List<statusTimeInHour>(); //итоговый массив, соответствие должности и среднему времени работы
            
            //var langdef = ExternalLangDef.LanguageDef;
            //var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), Сотрудник.Views.v3_СотрудникE);
            //var списокСотрудников = DataServiceProvider.DataService.LoadObjects(lcs).ToList();

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
            var списокСотрудников = DataServiceProvider.DataService.LoadObjects(lcsСервер);



            foreach (Сотрудник x in списокСотрудников)
            {
                if (списокУникальныхДолжностей.Contains(x.Должность) == false) //если должности нет в списке, то добавим её
                {
                    списокУникальныхДолжностей.Add(x.Должность);
                }
                else { }

               TimeSpan времяРаботыОдногоСотрудника=TimeSpan.Zero;
               var РабочиеПериоды = x.РабочийПериод.Cast<РабочийПериод>().ToList(); //Создаём переменную для рабочих периодов текущего сотрудника


                if (РабочиеПериоды.Count>0)
                {
                    if (РабочиеПериоды[РабочиеПериоды.Count - 1].ДатаУвольнения == null) //если для последнего рабочего периода сотрудника дата увольнения не указана
                    {
                        времяРаботыОдногоСотрудника = (РабочиеПериоды[0].ДатаПриёма - (DateTime.Now));
                    }
                    else
                    {
                        времяРаботыОдногоСотрудника = (Convert.ToDateTime(РабочиеПериоды[РабочиеПериоды.Count - 1].ДатаУвольнения) - РабочиеПериоды[0].ДатаПриёма);
                    }

                    должностьВремя.Status.Add(x.Должность); //записываем в массив, хранящий всех сотрудников должность и соотв. время работы
                    должностьВремя.uptime.Add(времяРаботыОдногоСотрудника);
                }
                else
                {

                }

            }

            //var должностьВремяИтого = new statusUptimeClass();


            foreach (var должность in списокУникальныхДолжностей) //проходим по уникальным должностям
            {
                double sum = 0; //обнуляем значение суммы для должности
                double avg = 0; //обнуляем значение среднего для должности
                int количествоСотрудниковВДолжности = 0; //обнуляем количество сотрудников в данной должности

                for (int i = 0; i < должностьВремя.Status.Count; i++) //идём по всем записям нашей структуры
                {
                    if (должностьВремя.Status[i]==должность) //если сотрудник находится в должности
                    {
                        количествоСотрудниковВДолжности++; //увеличиваем счётчик
                        sum += должностьВремя.uptime[i].TotalHours; //увеличиваем суммарное значение
                    }
                }
                avg = sum / количествоСотрудниковВДолжности;

                statusTimeInHour temp = new statusTimeInHour();
                temp.Должность = должность;
                temp.среднееВремяРаботы = Math.Abs(avg);

                должностьВремяРаботыВЧасах.Add(temp); //для каждой должности записываем должность и среднее время выходную структуру
            }

            //ws.Cell(j+1, 1).Value = avg;
            //ws.Cell(j+1, 2).Value = (Status[j]);
            //ws.Columns().AdjustToContents();

            //int number = Status.Count+1; 

            for (int i = 0; i < должностьВремяРаботыВЧасах.Count;i++)
            {
                var chart = worksheet.Charts.Add(ChartType.Bar, "D2", "M25");
                chart.SelectData(worksheet.Cells.GetSubrangeAbsolute(0, 0, 5, 1), true);
                worksheet.Cells[i+1, 0].Value = Convert.ToDouble(должностьВремяРаботыВЧасах[i].среднееВремяРаботы);
                worksheet.Cells[i+1, 1].Value = (должностьВремяРаботыВЧасах[i].Должность);

                worksheet.Cells[0, 0].Value = "Время работы";
                worksheet.Cells[0, 1].Value = "Должность";

            }

        workbook.Save("D://SKarimov/insetrtedData.xlsx");
        //wb.SaveAs("D://SKarimov/insetrtedData.xlsx");
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
