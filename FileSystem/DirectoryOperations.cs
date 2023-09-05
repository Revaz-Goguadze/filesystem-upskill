using System.IO;

namespace FileSystem
{
    public static class DirectoryOperations
    {
        public static void DirectoryIsCreatedOrNotValidateDirectory(string dirPath)
        {
            try
            {
                if (Directory.Exists(dirPath))
                {
                    Console.WriteLine($"Directory already exists at: {dirPath}");
                }
                else
                {
                    // Create the directory.
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine($"Directory created at: {dirPath}");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DirectoryIsDeletedOrNotValidateDirectory(string dirPath)
        {
            try
            {
                if (Directory.Exists(dirPath))
                {
                    // Delete the directory and its contents.
                    Directory.Delete(dirPath, true);

                    Console.WriteLine(Directory.Exists(dirPath)
                        ? "Directory deletion failed."
                        : $"Directory deleted successfully: {dirPath}");
                }
                else
                {
                    Console.WriteLine($"Directory does not exist at: {dirPath}");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DirectoryIsMovedToOtherDirectoryValidateDirectory(string sourceDirPath, string destinationDirPath)
        {
            try
            {
                if (Directory.Exists(sourceDirPath))
                {
                    // Create the destination directory if it doesn't exist.
                    Directory.CreateDirectory(destinationDirPath);

                    // Move the directory to the destination.
                    Directory.Move(sourceDirPath, destinationDirPath);

                    Console.WriteLine(Directory.Exists(destinationDirPath)
                        ? $"Directory moved successfully to: {destinationDirPath}"
                        : "Directory move operation failed.");
                }
                else
                {
                    Console.WriteLine($"Source directory does not exist at: {sourceDirPath}");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void SubDirectoryIsCreatedOrNotValidateSubDirectory(string dirPath, string subDirPath)
        {
            try
            {
                // Check if the subdirectory already exists.
                if (!Directory.Exists(subDirPath))
                {
                    // Create the subdirectory.
                    Directory.CreateDirectory(subDirPath);

                    Console.WriteLine($"Subdirectory '{subDirPath}' created successfully in '{dirPath}'.");
                }
                else
                {
                    Console.WriteLine($"Subdirectory '{subDirPath}' already exists in '{dirPath}'.");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during subdirectory creation.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteSubDirectoryValidateSubDirectoryDeletedOrNot(string subDirPath)
        {
            try
            {
                // Check if the subdirectory exists before attempting to delete it.
                if (Directory.Exists(subDirPath))
                {
                    // Delete the subdirectory, including its contents.
                    Directory.Delete(subDirPath, true);

                    // Validate whether the subdirectory was deleted.
                    Console.WriteLine(!Directory.Exists(subDirPath)
                        ? $"Subdirectory '{subDirPath}' deleted successfully."
                        : $"Subdirectory '{subDirPath}' deletion failed.");
                }
                else
                {
                    Console.WriteLine($"Subdirectory '{subDirPath}' does not exist.");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during subdirectory deletion.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MoveSubDirectoryValidateSubDirMovedOrNot(string sourcePath, string destinationPath)
        {
            try
            {
                // Check if the source subdirectory exists before moving it.
                if (Directory.Exists(sourcePath))
                {
                    // Move the subdirectory to the destination path.
                    Directory.Move(sourcePath, destinationPath);

                    // Validate whether the subdirectory was moved to the destination.
                    Console.WriteLine(Directory.Exists(destinationPath)
                        ? $"Subdirectory moved from '{sourcePath}' to '{destinationPath}'."
                        : $"Subdirectory move operation failed.");
                }
                else
                {
                    Console.WriteLine($"Source subdirectory '{sourcePath}' does not exist.");
                }
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                // Handle any exceptions that may occur during subdirectory move.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
