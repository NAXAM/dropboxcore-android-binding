using JavaList = Android.Runtime.JavaList;
using JNIEnv = Android.Runtime.JNIEnv;
using Extensions = Android.Runtime.Extensions;
using JniHandleOwnership = Android.Runtime.JniHandleOwnership;

namespace Com.Dropbox.Core.V1
{
    partial class DbxDelta
    {
        partial class Reader
        {
            public override unsafe Java.Lang.Object Read(FasterXml.Jackson.Core.JsonParser parser)
            {
                return ReadDbxDelta(parser);
            }
        }

        partial class Entry
        {
            partial class Reader
            {
                public override unsafe Java.Lang.Object Read(FasterXml.Jackson.Core.JsonParser parser)
                {
                    return ReadEntry(parser);
                }
            }
        }
    }


    partial class DbxDeltaC
    {
        partial class Reader
        {
            public override unsafe Java.Lang.Object Read(FasterXml.Jackson.Core.JsonParser parser)
            {
                return ReadDbxDeltaC(parser);
            }
        }

        partial class Entry
        {
            partial class Reader
            {
                public override unsafe Java.Lang.Object Read(FasterXml.Jackson.Core.JsonParser parser)
                {
                    return ReadEntry(parser);
                }
            }
        }
    }

    partial class DbxEntry
    {
        partial class WithChildrenC
        {
            partial class Reader
            {
                public override unsafe Java.Lang.Object Read(FasterXml.Jackson.Core.JsonParser parser)
                {
                    return ReadWithChildrenC(parser);
                }
            }
        }
        partial class WithChildrenC
        {
            partial class ReaderMaybeDeleted
            {
                public override unsafe Java.Lang.Object Read(FasterXml.Jackson.Core.JsonParser parser)
                {
                    return ReadWithChildrenC(parser);
                }
            }
        }
    }
}


namespace Com.Dropbox.Core.V2.Paper
{
    partial class DocsCreateUploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewDocsCreateUploaderException(error));
        }
    }
    partial class DocsUpdateUploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewDocsUpdateUploaderException(error));
        }
    }

}

namespace Com.Dropbox.Core.V2.Files
{
    partial class AlphaUploadUploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewAlphaUploadUploaderException(error));
        }
    }
    partial class UploadSessionAppendUploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewUploadSessionAppendUploaderException(error));
        }
    }
    partial class UploadSessionAppendV2Uploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewUploadSessionAppendV2UploaderException(error));
        }
    }
    partial class UploadSessionFinishUploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewUploadSessionFinishUploaderException(error));
        }
    }
    partial class UploadUploader
    {
        protected override unsafe Java.Lang.Object NewException(Core.DbxWrappedException error)
        {
            return Extensions.JavaCast<Java.Lang.Object>(NewUploadUploaderException(error));
        }
    }
}


namespace Com.Dropbox.Core.Util
{
    partial class Collector
    {
        partial class ArrayListCollector
        {
            public override unsafe Java.Lang.Object Finish()
            {
                var native_p0 = JavaList.ToLocalJniHandle(FinishArrayList());

                try
                {
                    return new JavaList(native_p0, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }
    }
}

namespace Com.Dropbox.Core.V2.Files
{
    partial class AlphaUploadBuilder
    {
        public override unsafe DbxUploader Start()
        {
            return StartUpload();
        }
    }
    partial class UploadBuilder
    {
        public override unsafe DbxUploader Start()
        {
            return StartUpload();
        }
    }
}