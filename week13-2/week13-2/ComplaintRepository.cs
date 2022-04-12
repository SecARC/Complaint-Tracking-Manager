using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week13_2
{
    public class ComplaintRepository
    {
        public List<Complaint> filteredList { get; set; }
        public List<Complaint> items { get; set; }
        public string monthName { get; set; }
        public int c1 { get; set; }
        public int c2 { get; set; }
        public int c3 { get; set; }
        public int c4 { get; set; }
        public int c5 { get; set; }

        public List<Complaint> getData(string fileName)
        {
            items = new List<Complaint>();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {                       
                        string line = reader.ReadLine();
                        string[] arr = line.Split(',');

                        if (arr.Length == 6)
                        {
                            if (string.IsNullOrEmpty(arr[0]))
                                continue;

                            Complaint c = new Complaint()
                            {
                                monthName = arr[0],
                                c1 = Convert.ToInt32(arr[1]),
                                c2 = Convert.ToInt32(arr[2]),
                                c3 = Convert.ToInt32(arr[3]),
                                c4 = Convert.ToInt32(arr[4]),
                                c5 = Convert.ToInt32(arr[5])
                            };
                            items.Add(c);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file is not exists!");
            }
            return items;
        }
        public void saveData(string fileName, int c1, int c2, int c3, int c4, int c5, int c51)
        {
            try
            {
                if(fileName != "Select a month")
                {
                    using (StreamWriter sw = new StreamWriter($"{fileName}.csv"))
                    {
                        sw.WriteLine(fileName + "," + c1 + "," + c2 + "," + c3 + "," + c4 + "," + c5);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("File write error\n" + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("The file does not save!");
            }
        }
    }
}
