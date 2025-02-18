namespace FileIO
{
    public class FileIO
    {
        static string FilePath = @"D:\bacancy_training\5) .netcore-daily-task\day1\day1\file.txt";

        public static void WriteFile(string content)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(FilePath, true))
                {
                    streamWriter.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
