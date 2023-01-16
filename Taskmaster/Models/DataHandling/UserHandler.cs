namespace Taskmaster.Models.DataHandling
{
    public class UserHandler
    {
        public static void ClearUsers()
        {
            StateManagement.State.Employees.Clear();
        }
        
        public static void ReadCsv(string Path)
        {
            var data = File.ReadAllLines(Path);
            // check if there is a header and remove it
            if (data[0].Split(',')[0] == "id")
            {
                data = data.Skip(1).ToArray();
            }
            foreach (var line in data)
            {
                var ln = line.Split(",");
                var gender = ln[4] switch
                {
                    "Male" => Gender.Male,
                    "Female" => Gender.Female,
                    _ => Gender.None,
                };
                StateManagement.State.Employees.Add(new Employee(
                    Convert.ToInt32(ln[0]),
                    ln[1],
                    ln[2],
                    ln[3],
                    gender,
                    ln[5],
                    ln[6],
                    ln[7],
                    ln[8],
                    ln[9],
                    ln[10]
                    ));
            }
        }
        public static void WriteCsv(string Path)
        {
            var data = StateManagement.State.Employees.Select(x => x.ToString()).ToList();
            if (data.Count > 0)
            {
                File.WriteAllLines(Path, data);
            }
        }
    }
}
