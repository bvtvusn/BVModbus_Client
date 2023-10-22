﻿using BV_Modbus_Client.BusinessLayer;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV_Modbus_Client
{
    public partial class TrendlineControl : UserControl
    {
        //internal FormatContainer Formats { get; set; }
        DateTime zeroDatetime;
        DateTime lowestTime;
        public TrendlineControl()
        {
            InitializeComponent();
             zeroDatetime = new DateTime();
             lowestTime = DateTime.Now;





            
        }

        
            //private BLL bll;
            private bool userEditActiveFlag;
            private bool refreshActiveFlag;
            private FcWrapperBase fc;

            internal FcWrapperBase Fc
            {
                get { return fc; }
                set
                {

                    //bool doRefresh = false;
                    if (Fc != null)
                    {
                        fc.RefreshDataEvent -= Bll_SelectedDataRecevivedEvent;
                    }

                    fc = value;
                    if (value != null)
                    {
                        //doRefresh = true;
                        fc.RefreshDataEvent += Bll_SelectedDataRecevivedEvent;
                        RefreshPlotGrid();
                    DrawCheckboxes();


                    }
                }
            }


        private void DrawCheckboxes()
        {
            chkPanel.Controls.Clear();
            // Simulate a Boolean array
            bool[] boolArray = new bool[Fc.formatContainer.valueFormats.Count];

            // Create checkboxes based on the array length
            for (int i = 0; i < boolArray.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "Checkbox " + (i + 1);
                checkBox.Checked = boolArray[i];
                checkBox.Top = i * 25; // Adjust the position based on your layout
                checkBox.Left = 10;    // Adjust the position based on your layout

                chkPanel.Controls.Add(checkBox); // Add the checkbox to the panel
            }
        }
        private void RefreshPlotGrid()
        {
            
            var plotModel = new PlotModel();
            foreach (ValueFormat item in Fc.formatContainer.valueFormats)
            {
                //int test = DateTime.Compare(DateTime.Now, zeroDatetime);

                //(DateTime,float)[] k = item.valueHistory.Where(a => 1 == DateTime.Compare(a.Item1, zeroDatetime)).ToArray();
                
                //if (k.Length > 0)
                //{
                //    lowestTime = k.Min(a=>a.Item1);
                //}
                var lineSeriesx = new LineSeries();
                for (int i = 0; i < item.valueHistory.Length; i++)
                {
                    (DateTime, float) xyPointTuple = item.valueHistory.ElementAt((i + item.historyIndex) % item.valueHistory.Length);

                    if (1 == DateTime.Compare( xyPointTuple.Item1, zeroDatetime))
                    {
                        
                        lineSeriesx.Points.Add(new DataPoint((xyPointTuple.Item1 - lowestTime).TotalSeconds, xyPointTuple.Item2));

                    }
                    //lineSeriesx.Points.Add(new DataPoint(i, item.valueHistory.ElementAt((i+item.historyIndex)%item.valueHistory.Length)));
                    //lineSeriesx.Points.AddRange(item.valueHistory);
                }
                plotModel.Series.Add(lineSeriesx);
            }
                

            plotView1.Model = plotModel;
        }

            private void Bll_SelectedDataRecevivedEvent(string obj)
            {
            RefreshPlotGrid();
                //throw new NotImplementedException();
            }
        }
    
}
