#region Assembly System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Windows.Forms.dll
// Decompiled with ICSharpCode.Decompiler 6.1.0.5902
#endregion

using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System;
using System.Windows.Forms;

namespace NotSteam.something
{
    //
    // Summary:
    //     Provides the data portion of an System.Windows.Forms.ImageList.
    [Serializable]
    public sealed class ImageListStreamer : ISerializable, IDisposable
    {
        private static readonly byte[] HEADER_MAGIC = new byte[4]
        {
            77,
            83,
            70,
            116
        };

        private static object internalSyncObject = new object();

        private ImageListMine imageList;

        private ImageListMine.NativeImageList nativeImageList;

        internal ImageListStreamer(ImageListMine il)
        {
            imageList = il;
        }

        private ImageListStreamer(SerializationInfo info, StreamingContext context)
        {
            SerializationInfoEnumerator enumerator = info.GetEnumerator();
            if (enumerator == null)
            {
                return;
            }

            while (enumerator.MoveNext())
            {
                if (!string.Equals(enumerator.Name, "Data", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                byte[] array = (byte[])enumerator.Value;
                if (array == null)
                {
                    continue;
                }

                IntPtr userCookie = UnsafeNativeMethods.ThemingScope.Activate();
                try
                {
                    MemoryStream dataStream = new MemoryStream(Decompress(array));
                    lock (internalSyncObject)
                    {
                        SafeNativeMethods.InitCommonControls();
                        nativeImageList = new ImageListMine.NativeImageList(SafeNativeMethods.ImageList_Read(new UnsafeNativeMethods.ComStreamFromDataStream(dataStream)));
                    }
                }
                finally
                {
                    UnsafeNativeMethods.ThemingScope.Deactivate(userCookie);
                }

                if (nativeImageList.Handle == IntPtr.Zero)
                {
                    throw new InvalidOperationException(SR.GetString("ImageListStreamerLoadFailed"));
                }
            }
        }

        private byte[] Compress(byte[] input)
        {
            int num = 0;
            int i = 0;
            int num2 = 0;
            while (i < input.Length)
            {
                byte b = input[i++];
                byte b2 = 1;
                for (; i < input.Length && input[i] == b; i++)
                {
                    if (b2 >= byte.MaxValue)
                    {
                        break;
                    }

                    b2 = (byte)(b2 + 1);
                }

                num += 2;
            }

            byte[] array = new byte[num + HEADER_MAGIC.Length];
            Buffer.BlockCopy(HEADER_MAGIC, 0, array, 0, HEADER_MAGIC.Length);
            int num3 = HEADER_MAGIC.Length;
            i = 0;
            while (i < input.Length)
            {
                byte b3 = input[i++];
                byte b4 = 1;
                for (; i < input.Length && input[i] == b3; i++)
                {
                    if (b4 >= byte.MaxValue)
                    {
                        break;
                    }

                    b4 = (byte)(b4 + 1);
                }

                array[num3 + num2++] = b4;
                array[num3 + num2++] = b3;
            }

            return array;
        }

        private byte[] Decompress(byte[] input)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            if (input.Length < HEADER_MAGIC.Length)
            {
                return input;
            }

            for (num2 = 0; num2 < HEADER_MAGIC.Length; num2++)
            {
                if (input[num2] != HEADER_MAGIC[num2])
                {
                    return input;
                }
            }

            for (num2 = HEADER_MAGIC.Length; num2 < input.Length; num2 += 2)
            {
                num += input[num2];
            }

            byte[] array = new byte[num];
            num2 = HEADER_MAGIC.Length;
            while (num2 < input.Length)
            {
                byte b = input[num2++];
                byte b2 = input[num2++];
                int num4 = num3;
                int num5 = num3 + b;
                while (num4 < num5)
                {
                    array[num4++] = b2;
                }

                num3 += b;
            }

            return array;
        }

        //
        // Summary:
        //     Populates a System.Runtime.Serialization.SerializationInfo with the data needed
        //     to serialize the target object.
        //
        // Parameters:
        //   si:
        //     The System.Runtime.Serialization.SerializationInfo to populate with data.
        //
        //   context:
        //     The System.Runtime.Serialization.StreamingContext that is the destination for
        //     this serialization.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Runtime.Serialization.SerializationInfo cannot be populated with data
        //     because no data exists, or it is not in the correct format.
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public void GetObjectData(SerializationInfo si, StreamingContext context)
        {
            MemoryStream memoryStream = new MemoryStream();
            IntPtr intPtr = IntPtr.Zero;
            if (imageList != null)
            {
                intPtr = imageList.Handle;
            }
            else if (nativeImageList != null)
            {
                intPtr = nativeImageList.Handle;
            }

            if (intPtr == IntPtr.Zero || !WriteImageList(intPtr, memoryStream))
            {
                throw new InvalidOperationException(SR.GetString("ImageListStreamerSaveFailed"));
            }

            si.AddValue("Data", Compress(memoryStream.ToArray()));
        }

        internal ImageListMine.NativeImageList GetNativeImageList()
        {
            return nativeImageList;
        }

        private bool WriteImageList(IntPtr imagelistHandle, Stream stream)
        {
            try
            {
                int num = SafeNativeMethods.ImageList_WriteEx(new HandleRef(this, imagelistHandle), 1, new UnsafeNativeMethods.ComStreamFromDataStream(stream));
                return num == 0;
            }
            catch (EntryPointNotFoundException)
            {
            }

            return SafeNativeMethods.ImageList_Write(new HandleRef(this, imagelistHandle), new UnsafeNativeMethods.ComStreamFromDataStream(stream));
        }

        //
        // Summary:
        //     Releases all resources used by the current instance of the System.Windows.Forms.ImageListStreamer
        //     class.
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing && nativeImageList != null)
            {
                nativeImageList.Dispose();
                nativeImageList = null;
            }
        }
    }
}
#if false // Decompilation log
'121' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll'
------------------
Resolve: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Drawing.dll'
------------------
Resolve: 'System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Xml.dll'
------------------
Resolve: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.dll'
------------------
Resolve: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Core.dll'
------------------
Resolve: 'System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Deployment.dll'
------------------
Resolve: 'System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
#endif
