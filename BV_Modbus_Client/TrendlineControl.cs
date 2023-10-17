using BV_Modbus_Client.BusinessLayer;
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
        public TrendlineControl()
        {
            InitializeComponent();
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


                    }
                }
            }

        private void RefreshPlotGrid()
        {
                var plotModel = new PlotModel();
            foreach (ValueFormat item in Fc.formatContainer.valueFormats)
            {
                var lineSeriesx = new LineSeries();
                for (int i = 0; i < item.valueHistory.Length; i++)
                {
                    lineSeriesx.Points.Add(new DataPoint(i, item.valueHistory.ElementAt((i+item.historyIndex)%item.valueHistory.Length)));
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
