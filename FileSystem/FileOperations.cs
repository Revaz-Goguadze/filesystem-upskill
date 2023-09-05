using System.IO;

[assembly: CLSCompliant(false)]

namespace FileSystem
{
    public static class FileOperations
    {
        public static void CreatingFileAndReturnFilePath(string filePath)
        {
            // TODO Implement the method.
            using (File.Create(filePath))
            {
            }
        }

        public static void WriteTextToFileReadAppendedText(string filePath, string msgToWrite)
        {
            try
            {
                // Append the message to the file. If the file doesn't exist, it will be created.
                File.AppendAllText(filePath, msgToWrite);

                // Read the contents of the file after appending the text.
                string appendedText = File.ReadAllText(filePath);

                Console.WriteLine("Appended Text:");
                Console.WriteLine(appendedText);
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during file operations.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static string ReadingFileContentAndValidateText(string filePath)
        {
            try
            {
                // Check if the file exists.
                if (File.Exists(filePath))
                {
                    // Read the contents of the file.
                    string fileContent = File.ReadAllText(filePath);

                    // You can add your validation logic here.
                    // For example, check if the file content contains specific text.
                    return fileContent;
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                    return null!; // Return null to indicate that the file doesn't exist.
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during file reading.
                Console.WriteLine($"Error: {ex.Message}");
                return null!; // Return null to indicate an error.
            }
        }

        public static void MoveFileFromOneFolderToNewFolderAndValidateFile(string filePath, string destinationPath)
        {
            try
            {
                // Check if the source file exists.
                if (File.Exists(filePath))
                {
                    // Create the destination directory if it doesn't exist.
                    Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);

                    // Move the file to the destination folder.
                    File.Move(filePath, destinationPath);

                    // Validate whether the file exists in the new location.
                    if (File.Exists(destinationPath))
                    {
                        Console.WriteLine($"File moved successfully to: {destinationPath}");
                    }
                    else
                    {
                        Console.WriteLine("File move operation failed.");
                    }
                }
                else
                {
                    Console.WriteLine("Source file does not exist.");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during file operations.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void CopyFileFromOneFolderToNewFolder(string filePath, string destinationPath)
        {
            try
            {
                // Check if the source file exists.
                if (File.Exists(filePath))
                {
                    // Create the destination directory if it doesn't exist.
                    Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);

                    // Copy the file to the destination folder.
                    File.Copy(filePath, destinationPath, true);

                    Console.WriteLine($"File copied successfully to: {destinationPath}");
                }
                else
                {
                    Console.WriteLine("Source file does not exist.");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during file operations.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteFileAndValidateFileExistOrNot(string filePath)
        {
            try
            {
                // Check if the file exists before attempting to delete it.
                if (File.Exists(filePath))
                {
                    // Delete the file.
                    File.Delete(filePath);

                    // Validate whether the file still exists.
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("File deletion failed.");
                    }
                    else
                    {
                        Console.WriteLine("File deleted successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during file deletion.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
