using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Com.Dropbox.Core.V2.Files;
using Square.Picasso;
using System.Linq;

namespace DropboxAuthorizeQs
{
    public class FilesAdapter : RecyclerView.Adapter
    {
        public event EventHandler<Metadata> MetadataSelected;

        Metadata[] mFiles;

        readonly Picasso mPicasso;

        public FilesAdapter(Picasso picasso)
        {
            mPicasso = picasso;
        }

        public void SetFiles(IList<Metadata> files)
        {
            mFiles = files.ToArray();
            NotifyDataSetChanged();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup viewGroup, int i)
        {
            var context = viewGroup.Context;
            var view = LayoutInflater.From(context)
                    .Inflate(Resource.Layout.files_item, viewGroup, false);

            var vh = new MetadataViewHolder(view, mPicasso);
            vh.MetadataSelected -= HandleMetadataSelected;
            vh.MetadataSelected += HandleMetadataSelected;

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int i)
        {
            var metadataViewHolder = (MetadataViewHolder)viewHolder;
            metadataViewHolder.Bind(mFiles[i]);
        }

        public override long GetItemId(int position)
        {
            return mFiles[position].PathLower.GetHashCode();
        }

        public override int ItemCount
        {
            get
            {
                return mFiles == null ? 0 : mFiles.Length;
            }
        }

        void HandleMetadataSelected(object sender, Metadata e)
        {
            MetadataSelected?.Invoke(this, e);
        }

        public class MetadataViewHolder : RecyclerView.ViewHolder, View.IOnClickListener
        {
            public event EventHandler<Metadata> MetadataSelected;

            readonly TextView mTextView;
            readonly ImageView mImageView;

            Metadata mItem;
            readonly Picasso mPicasso;

            public MetadataViewHolder(View itemView, Picasso picasso) : base(itemView)
            {
                this.mPicasso = picasso;

                mImageView = (ImageView)itemView.FindViewById(Resource.Id.image);
                mTextView = (TextView)itemView.FindViewById(Resource.Id.text);
                itemView.SetOnClickListener(this);
            }

            public void OnClick(View v)
            {
                MetadataSelected?.Invoke(this, mItem);
            }

            public void Bind(Metadata item)
            {
                mItem = item;
                mTextView.Text = mItem.Name;

                // Load based on file path
                // Prepending a magic scheme to get it to
                // be picked up by DropboxPicassoRequestHandler

                if (item is FileMetadata)
                {
                    MimeTypeMap mime = MimeTypeMap.Singleton;
                    String ext = item.Name.Substring(item.Name.IndexOf('.') + 1);
                    String type = mime.GetMimeTypeFromExtension(ext);
                    if (type != null && type.StartsWith("image/", StringComparison.Ordinal))
                    {
                        mPicasso.Load(FileThumbnailRequestHandler.BuildPicassoUri((FileMetadata)item))
                                .Placeholder(Resource.Drawable.ic_photo_grey_600_36dp)
                                .Error(Resource.Drawable.ic_photo_grey_600_36dp)
                                .Into(mImageView);
                    }
                    else
                    {
                        mPicasso.Load(Resource.Drawable.ic_insert_drive_file_blue_36dp)
                                .NoFade()
                                .Into(mImageView);
                    }
                }
                else if (item is FolderMetadata)
                {
                    mPicasso.Load(Resource.Drawable.ic_folder_blue_36dp)
                            .NoFade()
                            .Into(mImageView);
                }
            }
        }
    }
}
