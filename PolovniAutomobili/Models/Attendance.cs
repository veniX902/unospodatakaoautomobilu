namespace PolovniAutomobili.Models
{
    public class Attendance
    {
        private static List<string> attendants = new List<string>();

        public static void AddAttendant(string attendantMarka)
        {
            if (attendants != null)
            {
                attendants.Add(attendantMarka);
            }
        }
        public static List<string> GetAttendants()
        {
            return attendants;
        }
    }
}
