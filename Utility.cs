using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Customer_Feedback_System
{
    class Utility
    {
        public static string TxtReader(string filepath)
        {

            if (File.Exists(filepath))
            {
                string data;


                using (StreamReader rd = new StreamReader(filepath))
                {

                    data = rd.ReadToEnd();


                    if (data != "")
                    {
                        data = "[" + data + "]";
                    }
                }
                return data;
            }
            return null;
        }



        public static string[] ReadCriteri(string filename)
        {
            if (File.Exists(filename))
            {
                string data;
                using (StreamReader r = new StreamReader(filename))
                {
                    data = r.ReadToEnd();
                    data = data.Trim();
                }
                data = data.Trim().Substring(0, data.Trim().Length - 1);

                string[] criteri = data.Split(',');
                return criteri;
            }
            return null;
        }
        public static List<string> CsvReader(string filepath)
        {
            string data;
            List<string> datalst = new List<string>();
            using (StreamReader reader= new StreamReader(filepath))
            {


                while ((data = reader.ReadLine()) != null)
                {
                    if (data != "")
                    {
                        //Removing "," from the data
                        data = data.Trim().Substring(0, data.Trim().Length - 1);
                        datalst.Add(data);
                    }

                }
                reader.Close();
                return datalst;
            }

        }

        public static bool IsValid_Contact(string number)
        {
            Regex check = new Regex(@"^([0-9]+)");
            bool valid = false;
            valid = check.IsMatch(number);
            if (valid)
            {
                return valid;
            }
            else
            {
                return valid;
            }


        }
        public static bool TextWriter(String filename, string data, bool append = true, int count = 1)
        {
            bool sucess = false;
            if (!File.Exists(filename))
            {
                var file = File.Create(filename);
                file.Close();

            }


            using (StreamWriter wr = new StreamWriter(filename, append: append))
            {
                if (count != 0)
                {
                    //removing opening bracket "[" from data passed
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    //removing opening bracket "]" from data passed
                    data = data.Trim().Substring(0, data.Trim().Length - 1);
                }

                data = data.Trim();
                data = data + ",";


                wr.WriteLine(data);
                sucess = true;
            }
            return sucess;

        }
        public static DataTable ConvertToTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public static DataTable ConvertToDataTable(List<Review> data, bool sort = false)
        {
           
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(Review));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                
                if (prop.Name != "Criterias")
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
          
            if (sort)
            {
                List<Review> sortedlst = new List<Review>();
                for (int j = (data.Count) - 1; j > 0; j--)
                    for (int i = 0; i < j; i++)
                    {
                        foreach (PropertyDescriptor prop in properties)
                        {
                            if (prop.Name == "SubmittedDate")
                            {


                                //var v= String.Format("{0:MM/dd/yyyy}",prop.GetValue(data[i]));
                                //var x = String.Format("{0:MM/dd/yyyy}",prop.GetValue(data[i + 4]));
                                DateTime dateStr1 = DateTime.Parse(prop.GetValue(data[i]).ToString());
                                DateTime dateStr2 = DateTime.Parse(prop.GetValue(data[i + 1]).ToString());
                                if (dateStr1 < dateStr2)
                                {
                                    var swapdate = data[i];
                                    data[i] = data[i + 1];
                                    data[i + 1] = swapdate;

                                }

                                //MessageBox.Show(dateString);
                                //sortedlst.Add(data[i]);
                            }
                        }
                    }

            }
            if (data != null)
            {
                foreach (Review item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)

                        if (prop.Name != "Criterias")
                        {

                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;


                            foreach (var i in item.Criterias)
                            {

                                if (table.Columns.Contains(i.Key.ToString()) == false)
                                {
                                    table.Columns.Add(i.Key);
                                    if (i.Value != null)
                                    {
                                        row[i.Key] = i.Value;

                                    }

                                }
                                row[i.Key] = i.Value;

                            }
                        }

                    table.Rows.Add(row);


                }
            }
            return table;

        }
    }
         

   
}
