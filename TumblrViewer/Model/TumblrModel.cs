using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumblrViewer.Model
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class tumblr
    {

        private tumblrTumblelog tumblelogField;

        private tumblrPosts postsField;

        private decimal versionField;

        /// <remarks/>
        public tumblrTumblelog tumblelog
        {
            get
            {
                return this.tumblelogField;
            }
            set
            {
                this.tumblelogField = value;
            }
        }

        /// <remarks/>
        public tumblrPosts posts
        {
            get
            {
                return this.postsField;
            }
            set
            {
                this.postsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class tumblrTumblelog
    {

        private string nameField;

        private string timezoneField;

        private string titleField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class tumblrPosts
    {

        private tumblrPostsPost[] postField;

        private byte startField;

        private ushort totalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("post")]
        public tumblrPostsPost[] post
        {
            get
            {
                return this.postField;
            }
            set
            {
                this.postField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class tumblrPostsPost
    {

        private string videosourceField;

        private string videocaptionField;

        private tumblrPostsPostVideoplayer[] videoplayerField;

        private string questionField;

        private string answerField;

        private string photocaptionField;

        private string photolinkurlField;

        private tumblrPostsPostPhotourl[] photourlField;

        private string[] tagField;

        private ulong idField;

        private string urlField;

        private string urlwithslugField;

        private string typeField;

        private string dategmtField;

        private string dateField;

        private uint unixtimestampField;

        private string formatField;

        private string reblogkeyField;

        private string slugField;

        private ushort widthField;

        private bool widthFieldSpecified;

        private ushort heightField;

        private bool heightFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("video-source")]
        public string videosource
        {
            get
            {
                return this.videosourceField;
            }
            set
            {
                this.videosourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("video-caption")]
        public string videocaption
        {
            get
            {
                return this.videocaptionField;
            }
            set
            {
                this.videocaptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("video-player")]
        public tumblrPostsPostVideoplayer[] videoplayer
        {
            get
            {
                return this.videoplayerField;
            }
            set
            {
                this.videoplayerField = value;
            }
        }

        /// <remarks/>
        public string question
        {
            get
            {
                return this.questionField;
            }
            set
            {
                this.questionField = value;
            }
        }

        /// <remarks/>
        public string answer
        {
            get
            {
                return this.answerField;
            }
            set
            {
                this.answerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("photo-caption")]
        public string photocaption
        {
            get
            {
                return this.photocaptionField;
            }
            set
            {
                this.photocaptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("photo-link-url")]
        public string photolinkurl
        {
            get
            {
                return this.photolinkurlField;
            }
            set
            {
                this.photolinkurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("photo-url")]
        public tumblrPostsPostPhotourl[] photourl
        {
            get
            {
                return this.photourlField;
            }
            set
            {
                this.photourlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public string[] tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("url-with-slug")]
        public string urlwithslug
        {
            get
            {
                return this.urlwithslugField;
            }
            set
            {
                this.urlwithslugField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("date-gmt")]
        public string dategmt
        {
            get
            {
                return this.dategmtField;
            }
            set
            {
                this.dategmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("unix-timestamp")]
        public uint unixtimestamp
        {
            get
            {
                return this.unixtimestampField;
            }
            set
            {
                this.unixtimestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("reblog-key")]
        public string reblogkey
        {
            get
            {
                return this.reblogkeyField;
            }
            set
            {
                this.reblogkeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string slug
        {
            get
            {
                return this.slugField;
            }
            set
            {
                this.slugField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class tumblrPostsPostVideoplayer
    {

        private ushort maxwidthField;

        private bool maxwidthFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("max-width")]
        public ushort maxwidth
        {
            get
            {
                return this.maxwidthField;
            }
            set
            {
                this.maxwidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxwidthSpecified
        {
            get
            {
                return this.maxwidthFieldSpecified;
            }
            set
            {
                this.maxwidthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class tumblrPostsPostPhotourl
    {

        private ushort maxwidthField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("max-width")]
        public ushort maxwidth
        {
            get
            {
                return this.maxwidthField;
            }
            set
            {
                this.maxwidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
