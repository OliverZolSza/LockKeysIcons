using IWshRuntimeLibrary;

namespace LockKeysIcons
{
    internal static class Tools
    {
        // Create LNK shortcut
        public static void CreateShortcut(
            string shortcutPath,
            string targetPath,
            string arguments = "",
            string workingDirectory = "",
            string description = "",
            string iconPath = "")
        {
            var shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

            shortcut.TargetPath = targetPath;
            shortcut.Arguments = arguments;
            shortcut.WorkingDirectory = workingDirectory;
            shortcut.Description = description;

            if (!string.IsNullOrEmpty(iconPath))
                shortcut.IconLocation = iconPath;

            shortcut.Save();
        }
    }
}
