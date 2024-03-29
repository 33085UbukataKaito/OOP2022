﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 卒業制作 {


    public class Rootobject1 {
        public Datum[] data { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta {
        public string id { get; set; }
        public int totalCount { get; set; }
        public int status { get; set; }
    }

    public class Datum {
        public string description { get; set; }
        public int viewCounter { get; set; }
        public string contentId { get; set; }
        public string title { get; set; }
        public string thumbnailUrl { get; set; }
    }


    // メモ: 生成されたコードは、少なくとも .NET Framework 4.5または .NET Core/Standard 2.0 が必要な可能性があります。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class nicovideo_thumb_response {

        private nicovideo_thumb_responseThumb thumbField;

        private string statusField;

        /// <remarks/>
        public nicovideo_thumb_responseThumb thumb {
            get {
                return this.thumbField;
            }
            set {
                this.thumbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_thumb_responseThumb {

        private string video_idField;

        private string titleField;

        private string descriptionField;

        private string thumbnail_urlField;

        private System.DateTime first_retrieveField;

        private string lengthField;

        private string movie_typeField;

        private uint size_highField;

        private uint size_lowField;

        private uint view_counterField;

        private uint comment_numField;

        private uint mylist_counterField;

        private string last_res_bodyField;

        private string watch_urlField;

        private string thumb_typeField;

        private byte embeddableField;

        private byte no_live_playField;

        private nicovideo_thumb_responseThumbTags tagsField;

        private string genreField;

        private uint user_idField;

        private string user_nicknameField;

        private string user_icon_urlField;

        /// <remarks/>
        public string video_id {
            get {
                return this.video_idField;
            }
            set {
                this.video_idField = value;
            }
        }

        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string thumbnail_url {
            get {
                return this.thumbnail_urlField;
            }
            set {
                this.thumbnail_urlField = value;
            }
        }

        /// <remarks/>
        public System.DateTime first_retrieve {
            get {
                return this.first_retrieveField;
            }
            set {
                this.first_retrieveField = value;
            }
        }

        /// <remarks/>
        public string length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        public string movie_type {
            get {
                return this.movie_typeField;
            }
            set {
                this.movie_typeField = value;
            }
        }

        /// <remarks/>
        public uint size_high {
            get {
                return this.size_highField;
            }
            set {
                this.size_highField = value;
            }
        }

        /// <remarks/>
        public uint size_low {
            get {
                return this.size_lowField;
            }
            set {
                this.size_lowField = value;
            }
        }

        /// <remarks/>
        public uint view_counter {
            get {
                return this.view_counterField;
            }
            set {
                this.view_counterField = value;
            }
        }

        /// <remarks/>
        public uint comment_num {
            get {
                return this.comment_numField;
            }
            set {
                this.comment_numField = value;
            }
        }

        /// <remarks/>
        public uint mylist_counter {
            get {
                return this.mylist_counterField;
            }
            set {
                this.mylist_counterField = value;
            }
        }

        /// <remarks/>
        public string last_res_body {
            get {
                return this.last_res_bodyField;
            }
            set {
                this.last_res_bodyField = value;
            }
        }

        /// <remarks/>
        public string watch_url {
            get {
                return this.watch_urlField;
            }
            set {
                this.watch_urlField = value;
            }
        }

        /// <remarks/>
        public string thumb_type {
            get {
                return this.thumb_typeField;
            }
            set {
                this.thumb_typeField = value;
            }
        }

        /// <remarks/>
        public byte embeddable {
            get {
                return this.embeddableField;
            }
            set {
                this.embeddableField = value;
            }
        }

        /// <remarks/>
        public byte no_live_play {
            get {
                return this.no_live_playField;
            }
            set {
                this.no_live_playField = value;
            }
        }

        /// <remarks/>
        public nicovideo_thumb_responseThumbTags tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        public string genre {
            get {
                return this.genreField;
            }
            set {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public uint user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }

        /// <remarks/>
        public string user_nickname {
            get {
                return this.user_nicknameField;
            }
            set {
                this.user_nicknameField = value;
            }
        }

        /// <remarks/>
        public string user_icon_url {
            get {
                return this.user_icon_urlField;
            }
            set {
                this.user_icon_urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_thumb_responseThumbTags {

        private nicovideo_thumb_responseThumbTagsTag[] tagField;

        private string domainField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public nicovideo_thumb_responseThumbTagsTag[] tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_thumb_responseThumbTagsTag {

        private byte categoryField;

        private bool categoryFieldSpecified;

        private byte lockField;

        private bool lockFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool categorySpecified {
            get {
                return this.categoryFieldSpecified;
            }
            set {
                this.categoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte @lock {
            get {
                return this.lockField;
            }
            set {
                this.lockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lockSpecified {
            get {
                return this.lockFieldSpecified;
            }
            set {
                this.lockFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }




    //public class Rootobject1 {
    //    public Datum[] data { get; set; }
    //    public Meta meta { get; set; }
    //}

    //public class Meta {
    //    public string id { get; set; }
    //    public int totalCount { get; set; }
    //    public int status { get; set; }
    //}

    //public class Datum {
    //    public string contentId { get; set; }
    //    public string title { get; set; }
    //    public int viewCounter { get; set; }
    //}




    public class Rootobject2 {
        public Class1[] Property1 { get; set; }
    }

    public class Class1 {
        public string id { get; set; }
        public string title { get; set; }
        public DateTime registeredAt { get; set; }
        public Count count { get; set; }
        public Thumbnail thumbnail { get; set; }
    }

    public class Count {
        public int view { get; set; }
        public int comment { get; set; }
        public int mylist { get; set; }
        public int like { get; set; }
    }

    public class Thumbnail {
        public string url { get; set; }
        public string middleUrl { get; set; }
        public string largeUrl { get; set; }
    }




}
