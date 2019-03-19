using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Windows.Forms;
using ICSSoft.STORMNET.Web.Controls;
using ICSSoft.STORMNET.FunctionalLanguage;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
using ICSSoft.STORMNET.Business;
using Resources;
using ClosedXML.Report;
using ClosedXML.Excel;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.Charts;
using IIS.Product_26934.Models;
using System.Web.Http.Results;

namespace IIS.Product_26934.forms
{


    public class BarController : ApiController
    {
        public List<BarChartClass> PopulateSaleCategory()
        {
            var saleCategories = new List<BarChartClass>()
            {
               new BarChartClass(){Id=1, Category="Apparel", Amount=45000},
               new BarChartClass(){Id=2, Category="Baby Products", Amount=32000},
               new BarChartClass(){Id=3, Category="Beauty", Amount=51000},
               new BarChartClass(){Id=4, Category="Electronic", Amount=44000},
               new BarChartClass(){Id=5, Category="HealthCare", Amount=63000}

            };
            return saleCategories;
        }


        //public ActionResult Index()
        //{
        //    return View("~/Views/BarChart.cshtml");
        //}

        //[HttpGet]
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

        [HttpGet]
        public IHttpActionResult ResetPassword()
        {









            var должностьВремя = new statusUptimeClass(); //хранит для КАЖДОГО сотрудника свои должность и время работы
            var списокУникальныхДолжностей = new List<string>(); //список уникальных должностей, заполняется из базы
            var должностьВремяРаботыВЧасах = new List<statusTimeInHour>(); //итоговый массив, соответствие должности и среднему времени работы

            //var langdef = ExternalLangDef.LanguageDef;
            //var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), Сотрудник.Views.v3_СотрудникE);
            //var списокСотрудников = DataServiceProvider.DataService.LoadObjects(lcs).ToList();

            ExternalLangDef ldef = ICSSoft.STORMNET.Windows.Forms.ExternalLangDef.LanguageDef;
            LoadingCustomizationStruct lcsСервер = LoadingCustomizationStruct.GetSimpleStruct(typeof(Сотрудник), "v3_СотрудникE");
            lcsСервер.LoadingTypes = new[] { typeof(Сотрудник)
        };

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

                TimeSpan времяРаботыОдногоСотрудника = TimeSpan.Zero;
                var РабочиеПериоды = x.РабочийПериод.Cast<РабочийПериод>().ToList(); //Создаём переменную для рабочих периодов текущего сотрудника


                if (РабочиеПериоды.Count > 0)
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
                    if (должностьВремя.Status[i] == должность) //если сотрудник находится в должности
                    {
                        количествоСотрудниковВДолжности++; //увеличиваем счётчик
                        sum += должностьВремя.uptime[i].TotalHours; //увеличиваем суммарное значение
                    }
                }
                avg = sum / количествоСотрудниковВДолжности;

                statusTimeInHour temp = new statusTimeInHour();
                temp.Должность = должность;
                temp.среднееВремяРаботы = Math.Abs(avg);

                должностьВремяРаботыВЧасах.Add(temp); //для каждой должности записываем должность и среднее время в выходную структуру

            }


            var outputData = new object[должностьВремяРаботыВЧасах.Count + 1];
            outputData[0] = new object[] { "Должность", "Время" };
            int j = 0;
            foreach (var i in должностьВремяРаботыВЧасах)
            {
                j++;
                outputData[j] = new object[] { i.Должность, i.среднееВремяРаботы };
            }
            return Json(outputData);


            //var sales = PopulateSaleCategory();
            //var chartData = new object[sales.Count + 1];
            //chartData[0] = new object[] { "Category", "Amount" };
            //int j = 0;
            //foreach (var i in sales)
            //{
            //    j++;
            //    chartData[j] = new object[] { i.Category, i.Amount };
            //}
            //return Json(chartData);


            //ws.Cell(j+1, 1).Value = avg;
            //ws.Cell(j+1, 2).Value = (Status[j]);
            //ws.Columns().AdjustToContents();

            //int number = Status.Count+1; 

            //for (int i = 0; i < должностьВремяРаботыВЧасах.Count; i++)
            //{
            //    var chart = worksheet.Charts.Add(ChartType.Bar, "D2", "M25");
            //    chart.SelectData(worksheet.Cells.GetSubrangeAbsolute(0, 0, 5, 1), true);
            //    worksheet.Cells[i + 1, 0].Value = Convert.ToDouble(должностьВремяРаботыВЧасах[i].среднееВремяРаботы);
            //    worksheet.Cells[i + 1, 1].Value = (должностьВремяРаботыВЧасах[i].Должность);

            //    worksheet.Cells[0, 0].Value = "Время работы";
            //    worksheet.Cells[0, 1].Value = "Должность";

            //}

            //workbook.Save("D://SKarimov/insetrtedData.xlsx");
            ////wb.SaveAs("D://SKarimov/insetrtedData.xlsx");


        }
    }
}