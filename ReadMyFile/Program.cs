namespace ReadMyFile
{
    class Program
    {
        public static void Main()
        {
            string filePath = "C:/Users/ТехноСПБ/Desktop/BinaryFile.bin";

            // при запуске проверим, что файл существует
            if (File.Exists(filePath))
            {
                // строковая переменная, в которую будем считывать данные
                string stringValue;

                // считываем, после использования высвобождаем задействованный ресурс BinaryReader
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    stringValue = reader.ReadString();
                }

                // Вывод
                Console.WriteLine("Из файла считано:");
                Console.WriteLine(stringValue);
            }
            
            
        }
    }
}    