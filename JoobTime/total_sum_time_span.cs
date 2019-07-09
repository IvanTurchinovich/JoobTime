using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JoobTime
{
    class total_sum_time_span
    {

        public TimeSpan ts = new TimeSpan(00, 00, 00);

        public void to_time_span(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView grid = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int summaryID = Convert.ToInt32((e.Item as DevExpress.XtraGrid.GridSummaryItem).Tag);
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                ts = new TimeSpan(00, 00, 00);
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                //int until = (grid.GetRowCellValue(e.RowHandle, "time_span"));
                ts += TimeSpan.Parse(grid.GetRowCellValue(e.RowHandle, "time_span").ToString());
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                e.TotalValue = ts.TotalHours;//.ToString().Substring(3)+ts.Minutes.ToString();
            }
        }
    }
}
