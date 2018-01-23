using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace TouchPadSensorData
{
    class TouchPadSensorData
    {
        static void Main(string[] args)
        {
            //use relative path
            //this is path C:\Users\uidq4218\Documents\Visual Studio 2015\Projects\TouchPadSensorData\TouchPadSensorData\bin\Debug.
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Sample_Sensordata_Input.txt";
            //read the input file
            StreamReader sr = new StreamReader(file);
            //open the excel sheet 
            var workbook = System.Diagnostics.Process.Start(dir + @"\TPData.xlsx");

            //Close the input file
            sr.Close();
            //Close the excel sheet
            workbook.Close();

            //Dummy code starts here

        }
    }
}

