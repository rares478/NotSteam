#region Assembly System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Windows.Forms.dll
// Decompiled with ICSharpCode.Decompiler 6.1.0.5902
#endregion

using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System;
using Microsoft.VisualStudio.PlatformUI;


namespace NotSteam
{
    //
    // Summary:
    //     Provides methods to manage a collection of System.Drawing.Image objects. This
    //     class cannot be inherited.
    [Designer("System.Windows.Forms.Design.ImageListDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [ToolboxItemFilter("System.Windows.Forms")]
    [DefaultProperty("Images")]
    [TypeConverter(typeof(something.ImageListConverter))]
    [DesignerSerializer("System.Windows.Forms.Design.ImageListCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [something.SRDescription("DescriptionImageList")]
    public class ImageListMine : Component
    {
        internal class Indexer
        {
            private string key = string.Empty;

            private int index = -1;

            private bool useIntegerIndex = true;

            private ImageListMine imageList;

            public virtual ImageListMine ImageList
            {
                get
                {
                    return imageList;
                }
                set
                {
                    imageList = value;
                }
            }

            public virtual string Key
            {
                get
                {
                    return key;
                }
                set
                {
                    index = -1;
                    key = ((value == null) ? string.Empty : value);
                    useIntegerIndex = false;
                }
            }

            public virtual int Index
            {
                get
                {
                    return index;
                }
                set
                {
                    key = string.Empty;
                    index = value;
                    useIntegerIndex = true;
                }
            }

            public virtual int ActualIndex
            {
                get
                {
                    if (useIntegerIndex)
                    {
                        return Index;
                    }

                    if (ImageList != null)
                    {
                        return ImageList.Images.IndexOfKey(Key);
                    }

                    return -1;
                }
            }
        }

        internal class NativeImageList : IDisposable
        {
            private IntPtr himl;

            internal IntPtr Handle => himl;

            internal NativeImageList(IntPtr himl)
            {
                this.himl = himl;
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            public void Dispose(bool disposing)
            {
                if (himl != IntPtr.Zero)
                {
                    something.SafeNativeMethods.ImageList_Destroy(new HandleRef(null, himl));
                    himl = IntPtr.Zero;
                }
            }

            ~NativeImageList()
            {
                Dispose(disposing: false);
            }
        }

        private class Original
        {
            internal object image;

            internal OriginalOptions options;

            internal Color customTransparentColor = Color.Transparent;

            internal int nImages = 1;

            internal Original(object image, OriginalOptions options)
                : this(image, options, Color.Transparent)
            {
            }

            internal Original(object image, OriginalOptions options, int nImages)
                : this(image, options, Color.Transparent)
            {
                this.nImages = nImages;
            }

            internal Original(object image, OriginalOptions options, Color customTransparentColor)
            {
                if (!(image is Icon) && !(image is Image))
                {
                    throw new InvalidOperationException(something.SR.GetString("ImageListEntryType"));
                }

                this.image = image;
                this.options = options;
                this.customTransparentColor = customTransparentColor;
                _ = (options & OriginalOptions.CustomTransparentColor);
            }
        }

        [Flags]
        private enum OriginalOptions
        {
            Default = 0x0,
            ImageStrip = 0x1,
            CustomTransparentColor = 0x2,
            OwnsImage = 0x4
        }

        //
        // Summary:
        //     Encapsulates the collection of System.Drawing.Image objects in an System.Windows.Forms.ImageList.
        [Editor("System.Windows.Forms.Design.ImageCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public sealed class ImageCollectionMine : IList, ICollection, IEnumerable
        {
            internal class ImageInfo
            {
                private string name;

                public string Name
                {
                    get
                    {
                        return name;
                    }
                    set
                    {
                        name = value;
                    }
                }
            }

            private ImageListMine owner;

            private ArrayList imageInfoCollection = new ArrayList();

            private int lastAccessedIndex = -1;

            //
            // Summary:
            //     Gets the collection of keys associated with the images in the System.Windows.Forms.ImageList.ImageCollection.
            //
            // Returns:
            //     A System.Collections.Specialized.StringCollection containing the names of the
            //     images in the System.Windows.Forms.ImageList.ImageCollection.
            public StringCollection Keys
            {
                get
                {
                    StringCollection stringCollection = new StringCollection();
                    for (int i = 0; i < imageInfoCollection.Count; i++)
                    {
                        ImageInfo imageInfo = imageInfoCollection[i] as ImageInfo;
                        if (imageInfo != null && imageInfo.Name != null && imageInfo.Name.Length != 0)
                        {
                            stringCollection.Add(imageInfo.Name);
                        }
                        else
                        {
                            stringCollection.Add(string.Empty);
                        }
                    }

                    return stringCollection;
                }
            }

            //
            // Summary:
            //     Gets the number of images currently in the list.
            //
            // Returns:
            //     The number of images in the list. The default is 0.
            [Browsable(false)]
            public int Count
            {
                get
                {
                    if (owner.HandleCreated)
                    {
                        return something.SafeNativeMethods.ImageList_GetImageCount(new HandleRef(owner, owner.Handle));
                    }

                    int num = 0;
                    foreach (Original original in owner.originals)
                    {
                        if (original != null)
                        {
                            num += original.nImages;
                        }
                    }

                    return num;
                }
            }

            //
            // Summary:
            //     Gets an object that can be used to synchronize access to the collection.
            //
            // Returns:
            //     The object used to synchronize the System.Windows.Forms.ImageList.ImageCollection.
            object ICollection.SyncRoot => this;

            //
            // Summary:
            //     Gets a value indicating whether access to the collection is synchronized (thread
            //     safe).
            //
            // Returns:
            //     false in all cases.
            bool ICollection.IsSynchronized => false;

            //
            // Summary:
            //     Gets a value indicating whether the System.Windows.Forms.ImageList.ImageCollection
            //     has a fixed size.
            //
            // Returns:
            //     false in all cases.
            bool IList.IsFixedSize => false;

            //
            // Summary:
            //     Gets a value indicating whether the list is read-only.
            //
            // Returns:
            //     Always false.
            public bool IsReadOnly => false;

            //
            // Summary:
            //     Gets a value indicating whether the System.Windows.Forms.ImageList has any images.
            //
            // Returns:
            //     true if there are no images in the list; otherwise, false. The default is false.
            public bool Empty => Count == 0;

            //
            // Summary:
            //     Gets or sets an System.Drawing.Image at the specified index within the collection.
            //
            // Parameters:
            //   index:
            //     The index of the image to get or set.
            //
            // Returns:
            //     The image in the list specified by index.
            //
            // Exceptions:
            //   T:System.ArgumentOutOfRangeException:
            //     The index is less than 0 or greater than or equal to System.Windows.Forms.ImageList.ImageCollection.Count.
            //
            //   T:System.ArgumentException:
            //     image is not a System.Drawing.Bitmap.
            //
            //   T:System.ArgumentNullException:
            //     The image to be assigned is null or not a System.Drawing.Bitmap.
            //
            //   T:System.InvalidOperationException:
            //     The image cannot be added to the list.
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public Image this[int index]
            {
                get
                {
                    if (index < 0 || index >= Count)
                    {
                        throw new ArgumentOutOfRangeException("index", something.SR.GetString("InvalidArgument", "index", index.ToString(CultureInfo.CurrentCulture)));
                    }

                    return owner.GetBitmap(index);
                }
                set
                {
                    if (index < 0 || index >= Count)
                    {
                        throw new ArgumentOutOfRangeException("index", something.SR.GetString("InvalidArgument", "index", index.ToString(CultureInfo.CurrentCulture)));
                    }

                    if (value == null)
                    {
                        throw new ArgumentNullException("value");
                    }

                    if (!(value is Bitmap))
                    {
                        throw new ArgumentException(something.SR.GetString("ImageListBitmap"));
                    }

                    Bitmap bitmap = (Bitmap)value;
                    bool flag = false;
                    if (owner.UseTransparentColor)
                    {
                        Bitmap bitmap2 = bitmap;
                        bitmap = (Bitmap)bitmap.Clone();
                        bitmap.MakeTransparent(owner.transparentColor);
                        flag = true;
                    }

                    try
                    {
                        IntPtr intPtr = ControlPaint.CreateHBitmapTransparencyMask(bitmap);
                        IntPtr handle = ControlPaint.CreateHBitmapColorMask(bitmap, intPtr);
                        bool flag2 = something.SafeNativeMethods.ImageList_Replace(new HandleRef(owner, owner.Handle), index, new HandleRef(null, handle), new HandleRef(null, intPtr));
                        something.SafeNativeMethods.DeleteObject(new HandleRef(null, handle));
                        something.SafeNativeMethods.DeleteObject(new HandleRef(null, intPtr));
                        if (!flag2)
                        {
                            throw new InvalidOperationException(something.SR.GetString("ImageListReplaceFailed"));
                        }
                    }
                    finally
                    {
                        if (flag)
                        {
                            bitmap.Dispose();
                        }
                    }
                }
            }

            //
            // Summary:
            //     Gets or sets an image in an existing System.Windows.Forms.ImageList.ImageCollection.
            //
            // Parameters:
            //   index:
            //     The zero-based index of the image to get or set.
            //
            // Returns:
            //     The image in the list specified by the index.
            //
            // Exceptions:
            //   T:System.ArgumentOutOfRangeException:
            //     The index is less than 0 or greater than or equal to System.Windows.Forms.ImageList.ImageCollection.Count.
            //
            //   T:System.Exception:
            //     The attempt to replace the image failed.
            //
            //   T:System.ArgumentNullException:
            //     The image to be assigned is null or not a bitmap.
            object IList.this[int index]
            {
                get
                {
                    return this[index];
                }
                set
                {
                    if (value is Image)
                    {
                        this[index] = (Image)value;
                        return;
                    }

                    throw new ArgumentException(something.SR.GetString("ImageListBadImage"), "value");
                }
            }

            //
            // Summary:
            //     Gets an System.Drawing.Image with the specified key from the collection.
            //
            // Parameters:
            //   key:
            //     The name of the image to retrieve from the collection.
            //
            // Returns:
            //     The System.Drawing.Image with the specified key.
            public Image this[string key]
            {
                get
                {
                    if (key == null || key.Length == 0)
                    {
                        return null;
                    }

                    int index = IndexOfKey(key);
                    if (IsValidIndex(index))
                    {
                        return this[index];
                    }

                    return null;
                }
            }

            internal ImageCollectionMine(ImageListMine owner)
            {
                this.owner = owner;
            }

            internal void ResetKeys()
            {
                if (imageInfoCollection != null)
                {
                    imageInfoCollection.Clear();
                }

                for (int i = 0; i < Count; i++)
                {
                    imageInfoCollection.Add(new ImageInfo());
                }
            }

            [Conditional("DEBUG")]
            private void AssertInvariant()
            {
            }

            //
            // Summary:
            //     Adds an image with the specified key to the end of the collection.
            //
            // Parameters:
            //   key:
            //     The name of the image.
            //
            //   image:
            //     The System.Drawing.Image to add to the collection.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     image is null.
            public void Add(string key, Image image)
            {
                ImageInfo imageInfo = new ImageInfo();
                imageInfo.Name = key;
                Original original = new Original(image, OriginalOptions.Default);
                Add(original, imageInfo);
            }

            //
            // Summary:
            //     Adds an icon with the specified key to the end of the collection.
            //
            // Parameters:
            //   key:
            //     The name of the icon.
            //
            //   icon:
            //     The System.Drawing.Icon to add to the collection.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     icon is null.
            public void Add(string key, Icon icon)
            {
                ImageInfo imageInfo = new ImageInfo();
                imageInfo.Name = key;
                Original original = new Original(icon, OriginalOptions.Default);
                Add(original, imageInfo);
            }

            //
            // Summary:
            //     Adds the specified image to the System.Windows.Forms.ImageList.
            //
            // Parameters:
            //   value:
            //     The image to add to the list.
            //
            // Returns:
            //     The index of the newly added image, or -1 if the image could not be added.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     value is null.
            //
            //   T:System.ArgumentException:
            //     value is not a System.Drawing.Bitmap.
            int IList.Add(object value)
            {
                if (value is Image)
                {
                    Add((Image)value);
                    return Count - 1;
                }

                throw new ArgumentException(something.SR.GetString("ImageListBadImage"), "value");
            }

            //
            // Summary:
            //     Adds the specified icon to the System.Windows.Forms.ImageList.
            //
            // Parameters:
            //   value:
            //     An System.Drawing.Icon to add to the list.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     value is null -or- value is not an System.Drawing.Icon.
            public void Add(Icon value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                Add(new Original(value.Clone(), OriginalOptions.OwnsImage), null);
            }

            //
            // Summary:
            //     Adds the specified image to the System.Windows.Forms.ImageList.
            //
            // Parameters:
            //   value:
            //     A System.Drawing.Bitmap of the image to add to the list.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     The image being added is null.
            //
            //   T:System.ArgumentException:
            //     The image being added is not a System.Drawing.Bitmap.
            public void Add(Image value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                Original original = new Original(value, OriginalOptions.Default);
                Add(original, null);
            }

            //
            // Summary:
            //     Adds the specified image to the System.Windows.Forms.ImageList, using the specified
            //     color to generate the mask.
            //
            // Parameters:
            //   value:
            //     A System.Drawing.Bitmap of the image to add to the list.
            //
            //   transparentColor:
            //     The System.Drawing.Color to mask this image.
            //
            // Returns:
            //     The index of the newly added image, or -1 if the image cannot be added.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     The image being added is null.
            //
            //   T:System.ArgumentException:
            //     The image being added is not a System.Drawing.Bitmap.
            public int Add(Image value, Color transparentColor)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                Original original = new Original(value, OriginalOptions.CustomTransparentColor, transparentColor);
                return Add(original, null);
            }

            private int Add(Original original, ImageInfo imageInfo)
            {
                if (original == null || original.image == null)
                {
                    throw new ArgumentNullException("original");
                }

                int result = -1;
                if (original.image is Bitmap)
                {
                    if (owner.originals != null)
                    {
                        result = owner.originals.Add(original);
                    }

                    if (owner.HandleCreated)
                    {
                        bool ownsBitmap = false;
                        Bitmap bitmap = owner.CreateBitmap(original, out ownsBitmap);
                        result = owner.AddToHandle(original, bitmap);
                        if (ownsBitmap)
                        {
                            bitmap.Dispose();
                        }
                    }
                }
                else
                {
                    if (!(original.image is Icon))
                    {
                        throw new ArgumentException(something.SR.GetString("ImageListBitmap"));
                    }

                    if (owner.originals != null)
                    {
                        result = owner.originals.Add(original);
                    }

                    if (owner.HandleCreated)
                    {
                        result = owner.AddIconToHandle(original, (Icon)original.image);
                    }
                }

                if ((original.options & OriginalOptions.ImageStrip) != 0)
                {
                    for (int i = 0; i < original.nImages; i++)
                    {
                        imageInfoCollection.Add(new ImageInfo());
                    }
                }
                else
                {
                    if (imageInfo == null)
                    {
                        imageInfo = new ImageInfo();
                    }

                    imageInfoCollection.Add(imageInfo);
                }

                if (!owner.inAddRange)
                {
                    owner.OnChangeHandle(new EventArgs());
                }

                return result;
            }

            //
            // Summary:
            //     Adds an array of images to the collection.
            //
            // Parameters:
            //   images:
            //     The array of System.Drawing.Image objects to add to the collection.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     images is null.
            public void AddRange(Image[] images)
            {
                if (images == null)
                {
                    throw new ArgumentNullException("images");
                }

                owner.inAddRange = true;
                foreach (Image value in images)
                {
                    Add(value);
                }

                owner.inAddRange = false;
                owner.OnChangeHandle(new EventArgs());
            }

            //
            // Summary:
            //     Adds an image strip for the specified image to the System.Windows.Forms.ImageList.
            //
            // Parameters:
            //   value:
            //     A System.Drawing.Bitmap with the images to add.
            //
            // Returns:
            //     The index of the newly added image, or -1 if the image cannot be added.
            //
            // Exceptions:
            //   T:System.ArgumentException:
            //     The image being added is null. -or- The image being added is not a System.Drawing.Bitmap.
            //
            //   T:System.InvalidOperationException:
            //     The image cannot be added. -or- The width of image strip being added is 0, or
            //     the width is not equal to the existing image width. -or- The image strip height
            //     is not equal to existing image height.
            public int AddStrip(Image value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value.Width == 0 || value.Width % owner.ImageSize.Width != 0)
                {
                    throw new ArgumentException(something.SR.GetString("ImageListStripBadWidth"), "value");
                }

                if (value.Height != owner.ImageSize.Height)
                {
                    throw new ArgumentException(something.SR.GetString("ImageListImageTooShort"), "value");
                }

                int nImages = value.Width / owner.ImageSize.Width;
                Original original = new Original(value, OriginalOptions.ImageStrip, nImages);
                return Add(original, null);
            }

            //
            // Summary:
            //     Removes all the images and masks from the System.Windows.Forms.ImageList.
            public void Clear()
            {
                if (owner.originals != null)
                {
                    owner.originals.Clear();
                }

                imageInfoCollection.Clear();
                if (owner.HandleCreated)
                {
                    something.SafeNativeMethods.ImageList_Remove(new HandleRef(owner, owner.Handle), -1);
                }

                owner.OnChangeHandle(new EventArgs());
            }

            //
            // Summary:
            //     Not supported. The System.Collections.IList.Contains(System.Object) method indicates
            //     whether a specified object is contained in the list.
            //
            // Parameters:
            //   image:
            //     The System.Drawing.Image to find in the list.
            //
            // Returns:
            //     true if the image is found in the list; otherwise, false.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     This method is not supported.
            [EditorBrowsable(EditorBrowsableState.Never)]
            public bool Contains(Image image)
            {
                throw new NotSupportedException();
            }

            //
            // Summary:
            //     Implements the System.Collections.IList.Contains(System.Object) method. Throws
            //     a System.NotSupportedException in all cases.
            //
            // Parameters:
            //   image:
            //     The image to locate in the System.Windows.Forms.ImageList.ImageCollection.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     In all cases.
            bool IList.Contains(object image)
            {
                if (image is Image)
                {
                    return Contains((Image)image);
                }

                return false;
            }

            //
            // Summary:
            //     Determines if the collection contains an image with the specified key.
            //
            // Parameters:
            //   key:
            //     The key of the image to search for.
            //
            // Returns:
            //     true to indicate an image with the specified key is contained in the collection;
            //     otherwise, false.
            public bool ContainsKey(string key)
            {
                return IsValidIndex(IndexOfKey(key));
            }

            //
            // Summary:
            //     Not supported. The System.Collections.IList.IndexOf(System.Object) method returns
            //     the index of a specified object in the list.
            //
            // Parameters:
            //   image:
            //     The System.Drawing.Image to find in the list.
            //
            // Returns:
            //     The index of the image in the list.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     This method is not supported.
            [EditorBrowsable(EditorBrowsableState.Never)]
            public int IndexOf(Image image)
            {
                throw new NotSupportedException();
            }

            //
            // Summary:
            //     Implements the System.Collections.IList.IndexOf(System.Object) method. Throws
            //     a System.NotSupportedException in all cases.
            //
            // Parameters:
            //   image:
            //     The image to find in the list.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     In all cases.
            int IList.IndexOf(object image)
            {
                if (image is Image)
                {
                    return IndexOf((Image)image);
                }

                return -1;
            }

            //
            // Summary:
            //     Determines the index of the first occurrence of an image with the specified key
            //     in the collection.
            //
            // Parameters:
            //   key:
            //     The key of the image to retrieve the index for.
            //
            // Returns:
            //     The zero-based index of the first occurrence of an image with the specified key
            //     in the collection, if found; otherwise, -1.
            public int IndexOfKey(string key)
            {
                if (key == null || key.Length == 0)
                {
                    return -1;
                }

                if (IsValidIndex(lastAccessedIndex) && imageInfoCollection[lastAccessedIndex] != null && something.WindowsFormsUtils.SafeCompareStrings(((ImageInfo)imageInfoCollection[lastAccessedIndex]).Name, key, ignoreCase: true))
                {
                    return lastAccessedIndex;
                }

                for (int i = 0; i < Count; i++)
                {
                    if (imageInfoCollection[i] != null && something.WindowsFormsUtils.SafeCompareStrings(((ImageInfo)imageInfoCollection[i]).Name, key, ignoreCase: true))
                    {
                        lastAccessedIndex = i;
                        return i;
                    }
                }

                lastAccessedIndex = -1;
                return -1;
            }

            //
            // Summary:
            //     Implements the System.Collections.IList.Insert(System.Int32,System.Object) method.
            //     Throws a System.NotSupportedException in all cases.
            //
            // Parameters:
            //   index:
            //     The zero-based index at which value should be inserted.
            //
            //   value:
            //     The object to insert into the collection.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     In all cases.
            void IList.Insert(int index, object value)
            {
                throw new NotSupportedException();
            }

            private bool IsValidIndex(int index)
            {
                if (index >= 0)
                {
                    return index < Count;
                }

                return false;
            }

            //
            // Summary:
            //     Copies the items in this collection to a compatible one-dimensional array, starting
            //     at the specified index of the target array.
            //
            // Parameters:
            //   dest:
            //     The one-dimensional System.Array that is the destination of the elements copied
            //     from the collection. The array must have zero-based indexing.
            //
            //   index:
            //     The zero-based index in the System.Array at which copying begins.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     dest is null.
            //
            //   T:System.ArgumentOutOfRangeException:
            //     index is less than 0.
            //
            //   T:System.ArgumentException:
            //     dest is multidimensional. -or- The number of elements in the System.Windows.Forms.ComboBox.ObjectCollection
            //     is greater than the available space from index to the end of the destination
            //     array.
            //
            //   T:System.InvalidCastException:
            //     The type of the System.Windows.Forms.ComboBox.ObjectCollection cannot be cast
            //     automatically to the type of the destination array.
            void ICollection.CopyTo(Array dest, int index)
            {
                for (int i = 0; i < Count; i++)
                {
                    dest.SetValue(owner.GetBitmap(i), index++);
                }
            }

            //
            // Summary:
            //     Returns an enumerator that can be used to iterate through the item collection.
            //
            // Returns:
            //     An System.Collections.IEnumerator that represents the item collection.
            public IEnumerator GetEnumerator()
            {
                Image[] array = new Image[Count];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = owner.GetBitmap(i);
                }

                return array.GetEnumerator();
            }

            //
            // Summary:
            //     Not supported. The System.Collections.IList.Remove(System.Object) method removes
            //     a specified object from the list.
            //
            // Parameters:
            //   image:
            //     The System.Drawing.Image to remove from the list.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     This method is not supported.
            [EditorBrowsable(EditorBrowsableState.Never)]
            public void Remove(Image image)
            {
                throw new NotSupportedException();
            }

            //
            // Summary:
            //     Implements the System.Collections.IList.Remove(System.Object). Throws a System.NotSupportedException
            //     in all cases.
            //
            // Parameters:
            //   image:
            //     The object to add to the System.Windows.Forms.ImageList.ImageCollection.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     In all cases.
            void IList.Remove(object image)
            {
                if (image is Image)
                {
                    Remove((Image)image);
                    owner.OnChangeHandle(new EventArgs());
                }
            }

            //
            // Summary:
            //     Removes an image from the list.
            //
            // Parameters:
            //   index:
            //     The index of the image to remove.
            //
            // Exceptions:
            //   T:System.InvalidOperationException:
            //     The image cannot be removed.
            //
            //   T:System.ArgumentOutOfRangeException:
            //     The index value was less than 0. -or- The index value is greater than or equal
            //     to the System.Windows.Forms.ImageList.ImageCollection.Count of images.
            public void RemoveAt(int index)
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index", something.SR.GetString("InvalidArgument", "index", index.ToString(CultureInfo.CurrentCulture)));
                }

                if (!something.SafeNativeMethods.ImageList_Remove(new HandleRef(owner, owner.Handle), index))
                {
                    throw new InvalidOperationException(something.SR.GetString("ImageListRemoveFailed"));
                }

                if (imageInfoCollection != null && index >= 0 && index < imageInfoCollection.Count)
                {
                    imageInfoCollection.RemoveAt(index);
                    owner.OnChangeHandle(new EventArgs());
                }
            }

            //
            // Summary:
            //     Removes the image with the specified key from the collection.
            //
            // Parameters:
            //   key:
            //     The key of the image to remove from the collection.
            public void RemoveByKey(string key)
            {
                int index = IndexOfKey(key);
                if (IsValidIndex(index))
                {
                    RemoveAt(index);
                }
            }

            //
            // Summary:
            //     Sets the key for an image in the collection.
            //
            // Parameters:
            //   index:
            //     The zero-based index of an image in the collection.
            //
            //   name:
            //     The name of the image to be set as the image key.
            //
            // Exceptions:
            //   T:System.IndexOutOfRangeException:
            //     The specified index is less than 0 or greater than or equal to System.Windows.Forms.ImageList.ImageCollection.Count.
            public void SetKeyName(int index, string name)
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                if (imageInfoCollection[index] == null)
                {
                    imageInfoCollection[index] = new ImageInfo();
                }

                ((ImageInfo)imageInfoCollection[index]).Name = name;
            }
        }

        private static Color fakeTransparencyColor = Color.FromArgb(13, 11, 12);

        private static Size DefaultImageSize = new Size(16, 16);

        private const int INITIAL_CAPACITY = 4;

        private const int GROWBY = 4;

        private const int MAX_DIMENSION = 1024;

        private static int maxImageWidth = 1024;

        private static int maxImageHeight = 1024;

        private static bool isScalingInitialized;

        private NativeImageList nativeImageList;

        private ColorDepth colorDepth = ColorDepth.Depth8Bit;

        private Color transparentColor = Color.Transparent;

        private Size imageSize = DefaultImageSize;

        private ImageCollectionMine imageCollection;

        private object userData;

        private IList originals = new ArrayList();

        private EventHandler recreateHandler;

        private EventHandler changeHandler;

        private bool inAddRange;

        //
        // Summary:
        //     Gets the color depth of the image list.
        //
        // Returns:
        //     The number of available colors for the image. In the .NET Framework version 1.0,
        //     the default is System.Windows.Forms.ColorDepth.Depth4Bit. In the .NET Framework
        //     version 1.1 or later, the default is System.Windows.Forms.ColorDepth.Depth8Bit.
        //
        // Exceptions:
        //   T:System.ComponentModel.InvalidEnumArgumentException:
        //     The color depth is not a valid System.Windows.Forms.ColorDepth enumeration value.
        [something.SRCategory("CatAppearance")]
        [something.SRDescription("ImageListColorDepthDescr")]
        public ColorDepth ColorDepth
        {
            get
            {
                return colorDepth;
            }
            set
            {
                if (!something.ClientUtils.IsEnumValid_NotSequential(value, (int)value, 4, 8, 16, 24, 32))
                {
                    throw new InvalidEnumArgumentException("value", (int)value, typeof(ColorDepth));
                }

                if (colorDepth != value)
                {
                    colorDepth = value;
                    PerformRecreateHandle("ColorDepth");
                }
            }
        }

        //
        // Summary:
        //     Gets the handle of the image list object.
        //
        // Returns:
        //     The handle for the image list. The default is null.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     Creating the handle for the System.Windows.Forms.ImageList failed.
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [something.SRDescription("ImageListHandleDescr")]
        public IntPtr Handle
        {
            get
            {
                if (nativeImageList == null)
                {
                    CreateHandle();
                }

                return nativeImageList.Handle;
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether the underlying Win32 handle has been created.
        //
        // Returns:
        //     true if the System.Windows.Forms.ImageList.Handle has been created; otherwise,
        //     false. The default is false.
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [something.SRDescription("ImageListHandleCreatedDescr")]
        public bool HandleCreated => nativeImageList != null;

        //
        // Summary:
        //     Gets the System.Windows.Forms.ImageList.ImageCollection for this image list.
        //
        // Returns:
        //     The collection of images.
        [something.SRCategory("CatAppearance")]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [something.SRDescription("ImageListImagesDescr")]
        [MergableProperty(false)]
        public ImageCollectionMine Images
        {
            get
            {
                if (imageCollection == null)
                {
                    imageCollection = new ImageCollectionMine(this);
                }

                return imageCollection;
            }
        }

        //
        // Summary:
        //     Gets or sets the size of the images in the image list.
        //
        // Returns:
        //     The System.Drawing.Size that defines the height and width, in pixels, of the
        //     images in the list. The default size is 16 by 16. The maximum size is 256 by
        //     256.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The value assigned is equal to System.Drawing.Size.IsEmpty. -or- The value of
        //     the height or width is less than or equal to 0. -or- The value of the height
        //     or width is greater than 256.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The new size has a dimension less than 0 or greater than 256.
        [something.SRCategory("CatBehavior")]
        [Localizable(true)]
        [something.SRDescription("ImageListSizeDescr")]
        public Size ImageSize
        {
            get
            {
                return imageSize;
            }
            set
            {
                if (value.IsEmpty)
                {
                    throw new ArgumentException(something.SR.GetString("InvalidArgument", "ImageSize", "Size.Empty"));
                }

                if (value.Width <= 0 || value.Width > maxImageWidth)
                {
                    throw new ArgumentOutOfRangeException("ImageSize", something.SR.GetString("InvalidBoundArgument", "ImageSize.Width", value.Width.ToString(CultureInfo.CurrentCulture), 1.ToString(CultureInfo.CurrentCulture), maxImageWidth.ToString()));
                }

                if (value.Height <= 0 || value.Height > maxImageHeight)
                {
                    throw new ArgumentOutOfRangeException("ImageSize", something.SR.GetString("InvalidBoundArgument", "ImageSize.Height", value.Height.ToString(CultureInfo.CurrentCulture), 1.ToString(CultureInfo.CurrentCulture), maxImageHeight.ToString()));
                }

                if (imageSize.Width != value.Width || imageSize.Height != value.Height)
                {
                    imageSize = new Size(value.Width, value.Height);
                    PerformRecreateHandle("ImageSize");
                }
            }
        }

        //
        // Summary:
        //     Gets the System.Windows.Forms.ImageListStreamer associated with this image list.
        //
        // Returns:
        //     null if the image list is empty; otherwise, a System.Windows.Forms.ImageListStreamer
        //     for this System.Windows.Forms.ImageList.
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DefaultValue(null)]
        [something.SRDescription("ImageListImageStreamDescr")]
        public something.ImageListStreamer ImageStream
        {
            get
            {
                if (Images.Empty)
                {
                    return null;
                }

                return new something.ImageListStreamer(this);
            }
            set
            {
                if (value != null)
                {
                    NativeImageList nativeImageList = value.GetNativeImageList();
                    if (nativeImageList == null || nativeImageList == this.nativeImageList)
                    {
                        return;
                    }

                    bool handleCreated = HandleCreated;
                    DestroyHandle();
                    originals = null;
                    this.nativeImageList = new NativeImageList(something.SafeNativeMethods.ImageList_Duplicate(new HandleRef(nativeImageList, nativeImageList.Handle)));
                    if (something.SafeNativeMethods.ImageList_GetIconSize(new HandleRef(this, this.nativeImageList.Handle), out int x, out int y))
                    {
                        imageSize = new Size(x, y);
                    }

                    something.NativeMethods.IMAGEINFO iMAGEINFO = new something.NativeMethods.IMAGEINFO();
                    if (something.SafeNativeMethods.ImageList_GetImageInfo(new HandleRef(this, this.nativeImageList.Handle), 0, iMAGEINFO))
                    {
                        something.NativeMethods.BITMAP bITMAP = new something.NativeMethods.BITMAP();
                        something.UnsafeNativeMethods.GetObject(new HandleRef(null, iMAGEINFO.hbmImage), Marshal.SizeOf((object)bITMAP), bITMAP);
                        switch (bITMAP.bmBitsPixel)
                        {
                            case 4:
                                colorDepth = ColorDepth.Depth4Bit;
                                break;
                            case 8:
                                colorDepth = ColorDepth.Depth8Bit;
                                break;
                            case 16:
                                colorDepth = ColorDepth.Depth16Bit;
                                break;
                            case 24:
                                colorDepth = ColorDepth.Depth24Bit;
                                break;
                            case 32:
                                colorDepth = ColorDepth.Depth32Bit;
                                break;
                        }
                    }

                    Images.ResetKeys();
                    if (handleCreated)
                    {
                        OnRecreateHandle(new EventArgs());
                    }
                }
                else
                {
                    DestroyHandle();
                    Images.Clear();
                }
            }
        }

        //
        // Summary:
        //     Gets or sets an object that contains additional data about the System.Windows.Forms.ImageList.
        //
        // Returns:
        //     An System.Object that contains additional data about the System.Windows.Forms.ImageList.
        [something.SRCategory("CatData")]
        [Localizable(false)]
        [Bindable(true)]
        [something.SRDescription("ControlTagDescr")]
        [DefaultValue(null)]
        [TypeConverter(typeof(StringConverter))]
        public object Tag
        {
            get
            {
                return userData;
            }
            set
            {
                userData = value;
            }
        }

        //
        // Summary:
        //     Gets or sets the color to treat as transparent.
        //
        // Returns:
        //     One of the System.Drawing.Color values. The default is Transparent.
        [something.SRCategory("CatBehavior")]
        [something.SRDescription("ImageListTransparentColorDescr")]
        public Color TransparentColor
        {
            get
            {
                return transparentColor;
            }
            set
            {
                transparentColor = value;
            }
        }

        private bool UseTransparentColor => TransparentColor.A > 0;

        //
        // Summary:
        //     Occurs when the System.Windows.Forms.ImageList.Handle is recreated.
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [something.SRDescription("ImageListOnRecreateHandleDescr")]
        public event EventHandler RecreateHandle
        {
            add
            {
                recreateHandler = (EventHandler)Delegate.Combine(recreateHandler, value);
            }
            remove
            {
                recreateHandler = (EventHandler)Delegate.Remove(recreateHandler, value);
            }
        }

        internal event EventHandler ChangeHandle
        {
            add
            {
                changeHandler = (EventHandler)Delegate.Combine(changeHandler, value);
            }
            remove
            {
                changeHandler = (EventHandler)Delegate.Remove(changeHandler, value);
            }
        }

        //
        // Summary:
        //     Initializes a new instance of the System.Windows.Forms.ImageList class with default
        //     values for System.Windows.Forms.ImageList.ColorDepth, System.Windows.Forms.ImageList.ImageSize,
        //     and System.Windows.Forms.ImageList.TransparentColor.
        public ImageListMine()
        {
            if (!isScalingInitialized)
            {
                if (DpiHelper.IsScalingRequired)
                {
                    maxImageWidth = DpiHelper.LogicalToDeviceUnitsX(1024);
                    maxImageHeight = DpiHelper.LogicalToDeviceUnitsY(1024);
                }

                isScalingInitialized = true;
            }
        }

        //
        // Summary:
        //     Initializes a new instance of the System.Windows.Forms.ImageList class, associating
        //     it with a container.
        //
        // Parameters:
        //   container:
        //     An object implementing System.ComponentModel.IContainer to associate with this
        //     instance of System.Windows.Forms.ImageList.
        public ImageListMine(IContainer container)
            : this()
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            container.Add(this);
        }

        private bool ShouldSerializeColorDepth()
        {
            return Images.Count == 0;
        }

        private void ResetColorDepth()
        {
            ColorDepth = ColorDepth.Depth8Bit;
        }

        private bool ShouldSerializeImageSize()
        {
            return Images.Count == 0;
        }

        private Bitmap CreateBitmap(Original original, out bool ownsBitmap)
        {
            Color customTransparentColor = transparentColor;
            ownsBitmap = false;
            if ((original.options & OriginalOptions.CustomTransparentColor) != 0)
            {
                customTransparentColor = original.customTransparentColor;
            }

            Bitmap bitmap;
            if (original.image is Bitmap)
            {
                bitmap = (Bitmap)original.image;
            }
            else if (original.image is Icon)
            {
                bitmap = ((Icon)original.image).ToBitmap();
                ownsBitmap = true;
            }
            else
            {
                bitmap = new Bitmap((Image)original.image);
                ownsBitmap = true;
            }

            if (customTransparentColor.A > 0)
            {
                Bitmap bitmap2 = bitmap;
                bitmap = (Bitmap)bitmap.Clone();
                bitmap.MakeTransparent(customTransparentColor);
                if (ownsBitmap)
                {
                    bitmap2.Dispose();
                }

                ownsBitmap = true;
            }

            Size size = bitmap.Size;
            if ((original.options & OriginalOptions.ImageStrip) != 0)
            {
                if (size.Width == 0 || size.Width % imageSize.Width != 0)
                {
                    throw new ArgumentException(something.SR.GetString("ImageListStripBadWidth"), "original");
                }

                if (size.Height != imageSize.Height)
                {
                    throw new ArgumentException(something.SR.GetString("ImageListImageTooShort"), "original");
                }
            }
            else if (!size.Equals(ImageSize))
            {
                Bitmap bitmap3 = bitmap;
                bitmap = new Bitmap(bitmap3, ImageSize);
                if (ownsBitmap)
                {
                    bitmap3.Dispose();
                }

                ownsBitmap = true;
            }

            return bitmap;
        }

        private int AddIconToHandle(Original original, Icon icon)
        {
            try
            {
                int num = something.SafeNativeMethods.ImageList_ReplaceIcon(new HandleRef(this, Handle), -1, new HandleRef(icon, icon.Handle));
                if (num == -1)
                {
                    throw new InvalidOperationException(something.SR.GetString("ImageListAddFailed"));
                }

                return num;
            }
            finally
            {
                if ((original.options & OriginalOptions.OwnsImage) != 0)
                {
                    icon.Dispose();
                }
            }
        }

        private int AddToHandle(Original original, Bitmap bitmap)
        {
            IntPtr intPtr = ControlPaint.CreateHBitmapTransparencyMask(bitmap);
            IntPtr handle = ControlPaint.CreateHBitmapColorMask(bitmap, intPtr);
            int num = something.SafeNativeMethods.ImageList_Add(new HandleRef(this, Handle), new HandleRef(null, handle), new HandleRef(null, intPtr));
            something.SafeNativeMethods.DeleteObject(new HandleRef(null, handle));
            something.SafeNativeMethods.DeleteObject(new HandleRef(null, intPtr));
            if (num == -1)
            {
                throw new InvalidOperationException(something.SR.GetString("ImageListAddFailed"));
            }

            return num;
        }

        private void CreateHandle()
        {
            int num = 1;
            switch (colorDepth)
            {
                case ColorDepth.Depth4Bit:
                    num |= 4;
                    break;
                case ColorDepth.Depth8Bit:
                    num |= 8;
                    break;
                case ColorDepth.Depth16Bit:
                    num |= 0x10;
                    break;
                case ColorDepth.Depth24Bit:
                    num |= 0x18;
                    break;
                case ColorDepth.Depth32Bit:
                    num |= 0x20;
                    break;
            }

            IntPtr userCookie = something.UnsafeNativeMethods.ThemingScope.Activate();
            try
            {
                something.SafeNativeMethods.InitCommonControls();
                nativeImageList = new NativeImageList(something.SafeNativeMethods.ImageList_Create(imageSize.Width, imageSize.Height, num, 4, 4));
            }
            finally
            {
                something.UnsafeNativeMethods.ThemingScope.Deactivate(userCookie);
            }

            if (Handle == IntPtr.Zero)
            {
                throw new InvalidOperationException(something.SR.GetString("ImageListCreateFailed"));
            }

            something.SafeNativeMethods.ImageList_SetBkColor(new HandleRef(this, Handle), -1);
            for (int i = 0; i < originals.Count; i++)
            {
                Original original = (Original)originals[i];
                if (original.image is Icon)
                {
                    AddIconToHandle(original, (Icon)original.image);
                    continue;
                }

                bool ownsBitmap = false;
                Bitmap bitmap = CreateBitmap(original, out ownsBitmap);
                AddToHandle(original, bitmap);
                if (ownsBitmap)
                {
                    bitmap.Dispose();
                }
            }

            originals = null;
        }

        private void DestroyHandle()
        {
            if (HandleCreated)
            {
                nativeImageList.Dispose();
                nativeImageList = null;
                originals = new ArrayList();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (originals != null)
                {
                    foreach (Original original in originals)
                    {
                        if ((original.options & OriginalOptions.OwnsImage) != 0)
                        {
                            ((IDisposable)original.image).Dispose();
                        }
                    }
                }

                DestroyHandle();
            }

            base.Dispose(disposing);
        }

        //
        // Summary:
        //     Draws the image indicated by the specified index on the specified System.Drawing.Graphics
        //     at the given location.
        //
        // Parameters:
        //   g:
        //     The System.Drawing.Graphics to draw on.
        //
        //   pt:
        //     The location defined by a System.Drawing.Point at which to draw the image.
        //
        //   index:
        //     The index of the image in the System.Windows.Forms.ImageList to draw.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The index is less than 0. -or- The index is greater than or equal to the count
        //     of images in the image list.
        public void Draw(Graphics g, Point pt, int index)
        {
            Draw(g, pt.X, pt.Y, index);
        }

        //
        // Summary:
        //     Draws the image indicated by the given index on the specified System.Drawing.Graphics
        //     at the specified location.
        //
        // Parameters:
        //   g:
        //     The System.Drawing.Graphics to draw on.
        //
        //   x:
        //     The horizontal position at which to draw the image.
        //
        //   y:
        //     The vertical position at which to draw the image.
        //
        //   index:
        //     The index of the image in the System.Windows.Forms.ImageList to draw.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The index is less than 0. -or- The index is greater than or equal to the count
        //     of images in the image list.
        public void Draw(Graphics g, int x, int y, int index)
        {
            Draw(g, x, y, imageSize.Width, imageSize.Height, index);
        }

        //
        // Summary:
        //     Draws the image indicated by the given index on the specified System.Drawing.Graphics
        //     using the specified location and size.
        //
        // Parameters:
        //   g:
        //     The System.Drawing.Graphics to draw on.
        //
        //   x:
        //     The horizontal position at which to draw the image.
        //
        //   y:
        //     The vertical position at which to draw the image.
        //
        //   width:
        //     The width, in pixels, of the destination image.
        //
        //   height:
        //     The height, in pixels, of the destination image.
        //
        //   index:
        //     The index of the image in the System.Windows.Forms.ImageList to draw.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The index is less than 0. -or- The index is greater than or equal to the count
        //     of images in the image list.
        public void Draw(Graphics g, int x, int y, int width, int height, int index)
        {
            if (index < 0 || index >= Images.Count)
            {
                throw new ArgumentOutOfRangeException("index", something.SR.GetString("InvalidArgument", "index", index.ToString(CultureInfo.CurrentCulture)));
            }

            IntPtr hdc = g.GetHdc();
            try
            {
                something.SafeNativeMethods.ImageList_DrawEx(new HandleRef(this, Handle), index, new HandleRef(g, hdc), x, y, width, height, -1, -1, 1);
            }
            finally
            {
                g.ReleaseHdcInternal(hdc);
            }
        }

        private void CopyBitmapData(BitmapData sourceData, BitmapData targetData)
        {
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < targetData.Height; i++)
            {
                IntPtr handle;
                IntPtr handle2;
                if (IntPtr.Size == 4)
                {
                    handle = new IntPtr(sourceData.Scan0.ToInt32() + num);
                    handle2 = new IntPtr(targetData.Scan0.ToInt32() + num2);
                }
                else
                {
                    handle = new IntPtr(sourceData.Scan0.ToInt64() + num);
                    handle2 = new IntPtr(targetData.Scan0.ToInt64() + num2);
                }

                something.UnsafeNativeMethods.CopyMemory(new HandleRef(this, handle2), new HandleRef(this, handle), Math.Abs(targetData.Stride));
                num += sourceData.Stride;
                num2 += targetData.Stride;
            }
        }

        private unsafe static bool BitmapHasAlpha(BitmapData bmpData)
        {
            if (bmpData.PixelFormat != PixelFormat.Format32bppArgb && bmpData.PixelFormat != PixelFormat.Format32bppRgb)
            {
                return false;
            }

            bool result = false;
            for (int i = 0; i < bmpData.Height; i++)
            {
                int num = i * bmpData.Stride;
                int num2 = 3;
                while (num2 < bmpData.Width * 4)
                {
                    byte* ptr = (byte*)bmpData.Scan0.ToPointer() + num + num2;
                    if (*ptr == 0)
                    {
                        num2 += 4;
                        continue;
                    }

                    goto IL_0049;
                }

                continue;
            IL_0049:
                result = true;
                break;
            }

            return result;
        }

        private Bitmap GetBitmap(int index)
        {
            if (index < 0 || index >= Images.Count)
            {
                throw new ArgumentOutOfRangeException("index", something.SR.GetString("InvalidArgument", "index", index.ToString(CultureInfo.CurrentCulture)));
            }

            Bitmap bitmap = null;
            if (ColorDepth == ColorDepth.Depth32Bit)
            {
                something.NativeMethods.IMAGEINFO iMAGEINFO = new something.NativeMethods.IMAGEINFO();
                if (something.SafeNativeMethods.ImageList_GetImageInfo(new HandleRef(this, Handle), index, iMAGEINFO))
                {
                    Bitmap bitmap2 = null;
                    BitmapData bitmapData = null;
                    BitmapData bitmapData2 = null;
                    something.IntSecurity.ObjectFromWin32Handle.Assert();
                    try
                    {
                        bitmap2 = Image.FromHbitmap(iMAGEINFO.hbmImage);
                        bitmapData = bitmap2.LockBits(new Rectangle(iMAGEINFO.rcImage_left, iMAGEINFO.rcImage_top, iMAGEINFO.rcImage_right - iMAGEINFO.rcImage_left, iMAGEINFO.rcImage_bottom - iMAGEINFO.rcImage_top), ImageLockMode.ReadOnly, bitmap2.PixelFormat);
                        int num = bitmapData.Stride * imageSize.Height * index;
                        if (BitmapHasAlpha(bitmapData))
                        {
                            bitmap = new Bitmap(imageSize.Width, imageSize.Height, PixelFormat.Format32bppArgb);
                            bitmapData2 = bitmap.LockBits(new Rectangle(0, 0, imageSize.Width, imageSize.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
                            CopyBitmapData(bitmapData, bitmapData2);
                        }
                    }
                    finally
                    {
                        CodeAccessPermission.RevertAssert();
                        if (bitmap2 != null)
                        {
                            if (bitmapData != null)
                            {
                                bitmap2.UnlockBits(bitmapData);
                            }

                            bitmap2.Dispose();
                        }

                        if (bitmap != null && bitmapData2 != null)
                        {
                            bitmap.UnlockBits(bitmapData2);
                        }
                    }
                }
            }

            if (bitmap == null)
            {
                bitmap = new Bitmap(imageSize.Width, imageSize.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                try
                {
                    IntPtr hdc = graphics.GetHdc();
                    try
                    {
                        something.SafeNativeMethods.ImageList_DrawEx(new HandleRef(this, Handle), index, new HandleRef(graphics, hdc), 0, 0, imageSize.Width, imageSize.Height, -1, -1, 1);
                    }
                    finally
                    {
                        graphics.ReleaseHdcInternal(hdc);
                    }
                }
                finally
                {
                    graphics.Dispose();
                }
            }

            bitmap.MakeTransparent(fakeTransparencyColor);
            return bitmap;
        }

        private void OnRecreateHandle(EventArgs eventargs)
        {
            if (recreateHandler != null)
            {
                recreateHandler(this, eventargs);
            }
        }

        private void OnChangeHandle(EventArgs eventargs)
        {
            if (changeHandler != null)
            {
                changeHandler(this, eventargs);
            }
        }

        private void PerformRecreateHandle(string reason)
        {
            if (HandleCreated)
            {
                if (originals == null || Images.Empty)
                {
                    originals = new ArrayList();
                }

                if (originals == null)
                {
                    throw new InvalidOperationException(something.SR.GetString("ImageListCantRecreate", reason));
                }

                DestroyHandle();
                CreateHandle();
                OnRecreateHandle(new EventArgs());
            }
        }

        private void ResetImageSize()
        {
            ImageSize = DefaultImageSize;
        }

        private void ResetTransparentColor()
        {
            TransparentColor = Color.LightGray;
        }

        private bool ShouldSerializeTransparentColor()
        {
            return !TransparentColor.Equals(Color.LightGray);
        }

        //
        // Summary:
        //     Returns a string that represents the current System.Windows.Forms.ImageList.
        //
        // Returns:
        //     A string that represents the current System.Windows.Forms.ImageList.
        public override string ToString()
        {
            string text = base.ToString();
            if (Images != null)
            {
                return text + " Images.Count: " + Images.Count.ToString(CultureInfo.CurrentCulture) + ", ImageSize: " + ImageSize.ToString();
            }

            return text;
        }
    }
}
#if false // Decompilation log
'15' items in cache
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
