using System;


namespace JoobTime
{
    class class_date
    {
        /// <summary>
        ///конвертирует дату в строку отформатированную для sql (yyyy-mm-dd)
        /// </summary>
        /// <param name="d1"></param>
        /// <returns></returns>
        public string convert(DateTime d1) 
        {
            string de1_2;
            if (Convert.ToInt32(d1.Day.ToString()) < 10)
            {
                de1_2 = d1.Year + "-" + d1.Month + "-0" + d1.Day;
                if (Convert.ToInt32(d1.Month.ToString()) < 10)
                    de1_2 = d1.Year + "-0" + d1.Month + "-0" + d1.Day;
            }
            else
            {
                de1_2 = d1.Year + "-" + d1.Month + "-" + d1.Day;
                if (Convert.ToInt32(d1.Month.ToString()) < 10)
                    de1_2 = d1.Year + "-0" + d1.Month + "-" + d1.Day;
            }
            return de1_2;
        }
    }
}
