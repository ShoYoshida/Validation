
namespace Validation.Data
{
    public class MyData
    {
        public string Job { get; set; }
        public string Age { get; set; }
        public string Remarks { get; set; }

        public static MyData SetData(string[] lineData)
        {
            MyData data = new MyData();
            data.Job = lineData[0];
            data.Age = lineData[1];
            data.Remarks = lineData[2];

            return data;
        }
    }
}
