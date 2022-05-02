#region Assembly System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// location unknown
// Decompiled with ICSharpCode.Decompiler 6.1.0.5902
#endregion
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Drawing.Printing;

namespace NotSteam.something
{
    

    internal static class IntSecurity
    {
        private static readonly UIPermission AllWindows = new UIPermission(UIPermissionWindow.AllWindows);
        private static readonly UIPermission SafeSubWindows = new UIPermission(UIPermissionWindow.SafeSubWindows);

        public static readonly CodeAccessPermission UnmanagedCode = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);

        public static readonly CodeAccessPermission ObjectFromWin32Handle = UnmanagedCode;
        public static readonly CodeAccessPermission Win32HandleManipulation = UnmanagedCode;

        public static readonly PrintingPermission NoPrinting = new PrintingPermission(PrintingPermissionLevel.NoPrinting);
        public static readonly PrintingPermission SafePrinting = new PrintingPermission(PrintingPermissionLevel.SafePrinting);
        public static readonly PrintingPermission DefaultPrinting = new PrintingPermission(PrintingPermissionLevel.DefaultPrinting);
        public static readonly PrintingPermission AllPrinting = new PrintingPermission(PrintingPermissionLevel.AllPrinting);

        internal static void DemandReadFileIO(string fileName)
        {
            string full = fileName;

            full = UnsafeGetFullPath(fileName);

            new FileIOPermission(FileIOPermissionAccess.Read, full).Demand();
        }

        internal static void DemandWriteFileIO(string fileName)
        {
            string full = fileName;

            full = UnsafeGetFullPath(fileName);

            new FileIOPermission(FileIOPermissionAccess.Write, full).Demand();
        }

        internal static string UnsafeGetFullPath(string fileName)
        {
            string full = fileName;

            FileIOPermission fiop = new FileIOPermission(PermissionState.None);
            fiop.AllFiles = FileIOPermissionAccess.PathDiscovery;
            fiop.Assert();

            try
            {
                full = Path.GetFullPath(fileName);
            }
            finally
            {
                CodeAccessPermission.RevertAssert();
            }

            return full;
        }

        static PermissionSet allPrintingAndUnmanagedCode;
        public static PermissionSet AllPrintingAndUnmanagedCode
        {
            get
            {
                if (allPrintingAndUnmanagedCode == null)
                {
                    PermissionSet temp = new PermissionSet(PermissionState.None);
                    temp.SetPermission(IntSecurity.UnmanagedCode);
                    temp.SetPermission(IntSecurity.AllPrinting);
                    allPrintingAndUnmanagedCode = temp;
                }
                return allPrintingAndUnmanagedCode;
            }
        }

        internal static bool HasPermission(PrintingPermission permission)
        {
            try
            {
                permission.Demand();
                return true;
            }
            catch (SecurityException)
            {
                return false;
            }
        }
    }
} 
#if false // Decompilation log
'128' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll'
------------------
Resolve: 'System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Xml.dll'
#endif
