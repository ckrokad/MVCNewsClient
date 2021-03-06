﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCNewsClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="News", Namespace="http://schemas.datacontract.org/2004/07/NewsService")]
    [System.SerializableAttribute()]
    public partial class News : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCNewsClient.ServiceReference1.Author authorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime datetimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] imagedataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string newsCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int newsIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVCNewsClient.ServiceReference1.Author author {
            get {
                return this.authorField;
            }
            set {
                if ((object.ReferenceEquals(this.authorField, value) != true)) {
                    this.authorField = value;
                    this.RaisePropertyChanged("author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime datetime {
            get {
                return this.datetimeField;
            }
            set {
                if ((this.datetimeField.Equals(value) != true)) {
                    this.datetimeField = value;
                    this.RaisePropertyChanged("datetime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] imagedata {
            get {
                return this.imagedataField;
            }
            set {
                if ((object.ReferenceEquals(this.imagedataField, value) != true)) {
                    this.imagedataField = value;
                    this.RaisePropertyChanged("imagedata");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string newsCity {
            get {
                return this.newsCityField;
            }
            set {
                if ((object.ReferenceEquals(this.newsCityField, value) != true)) {
                    this.newsCityField = value;
                    this.RaisePropertyChanged("newsCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int newsId {
            get {
                return this.newsIdField;
            }
            set {
                if ((this.newsIdField.Equals(value) != true)) {
                    this.newsIdField = value;
                    this.RaisePropertyChanged("newsId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tag {
            get {
                return this.tagField;
            }
            set {
                if ((object.ReferenceEquals(this.tagField, value) != true)) {
                    this.tagField = value;
                    this.RaisePropertyChanged("tag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/NewsService")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authorCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int authorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authorImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] imagedataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string authorCity {
            get {
                return this.authorCityField;
            }
            set {
                if ((object.ReferenceEquals(this.authorCityField, value) != true)) {
                    this.authorCityField = value;
                    this.RaisePropertyChanged("authorCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int authorId {
            get {
                return this.authorIdField;
            }
            set {
                if ((this.authorIdField.Equals(value) != true)) {
                    this.authorIdField = value;
                    this.RaisePropertyChanged("authorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string authorImage {
            get {
                return this.authorImageField;
            }
            set {
                if ((object.ReferenceEquals(this.authorImageField, value) != true)) {
                    this.authorImageField = value;
                    this.RaisePropertyChanged("authorImage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string authorName {
            get {
                return this.authorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.authorNameField, value) != true)) {
                    this.authorNameField = value;
                    this.RaisePropertyChanged("authorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] imagedata {
            get {
                return this.imagedataField;
            }
            set {
                if ((object.ReferenceEquals(this.imagedataField, value) != true)) {
                    this.imagedataField = value;
                    this.RaisePropertyChanged("imagedata");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.INewsService")]
    public interface INewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/uploadImage", ReplyAction="http://tempuri.org/INewsService/uploadImageResponse")]
        bool uploadImage(byte[] imagedata, string imagename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/uploadImage", ReplyAction="http://tempuri.org/INewsService/uploadImageResponse")]
        System.Threading.Tasks.Task<bool> uploadImageAsync(byte[] imagedata, string imagename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getImage", ReplyAction="http://tempuri.org/INewsService/getImageResponse")]
        byte[] getImage(string imagename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getImage", ReplyAction="http://tempuri.org/INewsService/getImageResponse")]
        System.Threading.Tasks.Task<byte[]> getImageAsync(string imagename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getAllNews", ReplyAction="http://tempuri.org/INewsService/getAllNewsResponse")]
        MVCNewsClient.ServiceReference1.News[] getAllNews(int authorId, string tag, string newsCity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getAllNews", ReplyAction="http://tempuri.org/INewsService/getAllNewsResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.News[]> getAllNewsAsync(int authorId, string tag, string newsCity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getNews", ReplyAction="http://tempuri.org/INewsService/getNewsResponse")]
        MVCNewsClient.ServiceReference1.News getNews(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getNews", ReplyAction="http://tempuri.org/INewsService/getNewsResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.News> getNewsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/addNews", ReplyAction="http://tempuri.org/INewsService/addNewsResponse")]
        int addNews(MVCNewsClient.ServiceReference1.News news);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/addNews", ReplyAction="http://tempuri.org/INewsService/addNewsResponse")]
        System.Threading.Tasks.Task<int> addNewsAsync(MVCNewsClient.ServiceReference1.News news);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/removeNews", ReplyAction="http://tempuri.org/INewsService/removeNewsResponse")]
        void removeNews(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/removeNews", ReplyAction="http://tempuri.org/INewsService/removeNewsResponse")]
        System.Threading.Tasks.Task removeNewsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/updateNews", ReplyAction="http://tempuri.org/INewsService/updateNewsResponse")]
        MVCNewsClient.ServiceReference1.News updateNews(MVCNewsClient.ServiceReference1.News news);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/updateNews", ReplyAction="http://tempuri.org/INewsService/updateNewsResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.News> updateNewsAsync(MVCNewsClient.ServiceReference1.News news);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getAllAuthor", ReplyAction="http://tempuri.org/INewsService/getAllAuthorResponse")]
        MVCNewsClient.ServiceReference1.Author[] getAllAuthor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getAllAuthor", ReplyAction="http://tempuri.org/INewsService/getAllAuthorResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author[]> getAllAuthorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/Login", ReplyAction="http://tempuri.org/INewsService/LoginResponse")]
        MVCNewsClient.ServiceReference1.Author Login(string authorname, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/Login", ReplyAction="http://tempuri.org/INewsService/LoginResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author> LoginAsync(string authorname, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getAuthor", ReplyAction="http://tempuri.org/INewsService/getAuthorResponse")]
        MVCNewsClient.ServiceReference1.Author getAuthor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/getAuthor", ReplyAction="http://tempuri.org/INewsService/getAuthorResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author> getAuthorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/addAuthor", ReplyAction="http://tempuri.org/INewsService/addAuthorResponse")]
        int addAuthor(MVCNewsClient.ServiceReference1.Author author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/addAuthor", ReplyAction="http://tempuri.org/INewsService/addAuthorResponse")]
        System.Threading.Tasks.Task<int> addAuthorAsync(MVCNewsClient.ServiceReference1.Author author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/removeAuthor", ReplyAction="http://tempuri.org/INewsService/removeAuthorResponse")]
        void removeAuthor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/removeAuthor", ReplyAction="http://tempuri.org/INewsService/removeAuthorResponse")]
        System.Threading.Tasks.Task removeAuthorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/updateAuthor", ReplyAction="http://tempuri.org/INewsService/updateAuthorResponse")]
        MVCNewsClient.ServiceReference1.Author updateAuthor(MVCNewsClient.ServiceReference1.Author author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/updateAuthor", ReplyAction="http://tempuri.org/INewsService/updateAuthorResponse")]
        System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author> updateAuthorAsync(MVCNewsClient.ServiceReference1.Author author);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceChannel : MVCNewsClient.ServiceReference1.INewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.ClientBase<MVCNewsClient.ServiceReference1.INewsService>, MVCNewsClient.ServiceReference1.INewsService {
        
        public NewsServiceClient() {
        }
        
        public NewsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool uploadImage(byte[] imagedata, string imagename) {
            return base.Channel.uploadImage(imagedata, imagename);
        }
        
        public System.Threading.Tasks.Task<bool> uploadImageAsync(byte[] imagedata, string imagename) {
            return base.Channel.uploadImageAsync(imagedata, imagename);
        }
        
        public byte[] getImage(string imagename) {
            return base.Channel.getImage(imagename);
        }
        
        public System.Threading.Tasks.Task<byte[]> getImageAsync(string imagename) {
            return base.Channel.getImageAsync(imagename);
        }
        
        public MVCNewsClient.ServiceReference1.News[] getAllNews(int authorId, string tag, string newsCity) {
            return base.Channel.getAllNews(authorId, tag, newsCity);
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.News[]> getAllNewsAsync(int authorId, string tag, string newsCity) {
            return base.Channel.getAllNewsAsync(authorId, tag, newsCity);
        }
        
        public MVCNewsClient.ServiceReference1.News getNews(int id) {
            return base.Channel.getNews(id);
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.News> getNewsAsync(int id) {
            return base.Channel.getNewsAsync(id);
        }
        
        public int addNews(MVCNewsClient.ServiceReference1.News news) {
            return base.Channel.addNews(news);
        }
        
        public System.Threading.Tasks.Task<int> addNewsAsync(MVCNewsClient.ServiceReference1.News news) {
            return base.Channel.addNewsAsync(news);
        }
        
        public void removeNews(int id) {
            base.Channel.removeNews(id);
        }
        
        public System.Threading.Tasks.Task removeNewsAsync(int id) {
            return base.Channel.removeNewsAsync(id);
        }
        
        public MVCNewsClient.ServiceReference1.News updateNews(MVCNewsClient.ServiceReference1.News news) {
            return base.Channel.updateNews(news);
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.News> updateNewsAsync(MVCNewsClient.ServiceReference1.News news) {
            return base.Channel.updateNewsAsync(news);
        }
        
        public MVCNewsClient.ServiceReference1.Author[] getAllAuthor() {
            return base.Channel.getAllAuthor();
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author[]> getAllAuthorAsync() {
            return base.Channel.getAllAuthorAsync();
        }
        
        public MVCNewsClient.ServiceReference1.Author Login(string authorname, string password) {
            return base.Channel.Login(authorname, password);
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author> LoginAsync(string authorname, string password) {
            return base.Channel.LoginAsync(authorname, password);
        }
        
        public MVCNewsClient.ServiceReference1.Author getAuthor(int id) {
            return base.Channel.getAuthor(id);
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author> getAuthorAsync(int id) {
            return base.Channel.getAuthorAsync(id);
        }
        
        public int addAuthor(MVCNewsClient.ServiceReference1.Author author) {
            return base.Channel.addAuthor(author);
        }
        
        public System.Threading.Tasks.Task<int> addAuthorAsync(MVCNewsClient.ServiceReference1.Author author) {
            return base.Channel.addAuthorAsync(author);
        }
        
        public void removeAuthor(int id) {
            base.Channel.removeAuthor(id);
        }
        
        public System.Threading.Tasks.Task removeAuthorAsync(int id) {
            return base.Channel.removeAuthorAsync(id);
        }
        
        public MVCNewsClient.ServiceReference1.Author updateAuthor(MVCNewsClient.ServiceReference1.Author author) {
            return base.Channel.updateAuthor(author);
        }
        
        public System.Threading.Tasks.Task<MVCNewsClient.ServiceReference1.Author> updateAuthorAsync(MVCNewsClient.ServiceReference1.Author author) {
            return base.Channel.updateAuthorAsync(author);
        }
    }
}
