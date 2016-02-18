namespace LigerShark.Farticus
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidFarticusPkgString = "1324ce08-8b25-440c-1234-07e1fa0cce4a";
        public const string guidFarticusCmdSetString = "7a332164-9846-4bc6-a00f-bc7e6132f29a";
        public const string guidImagesString = "24680110-4ff3-4a12-9819-981cf55f73f1";
        public static Guid guidFarticusPkg = new Guid(guidFarticusPkgString);
        public static Guid guidFarticusCmdSet = new Guid(guidFarticusCmdSetString);
        public static Guid guidImages = new Guid(guidImagesString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int MyMenuGroup = 0x1020;
        public const int cmdidRandomFart = 0x0100;
        public const int logo = 0x0001;
    }
}
