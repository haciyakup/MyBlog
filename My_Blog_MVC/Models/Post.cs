using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace My_Blog_MVC.Models
{
    public class Post
    {
 
        public int postId { get; set; }

        [DisplayName("Title")]
        public string postTitle { get; set; }

        [DisplayName("Content")]
        public string postContent { get; set; }

        public string createdBy { get; set; }
        
        public DateTime postDate { get; set; }

        [DisplayName("Preview")]
        public string preview { get; set; }

        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<FilePath> FilePaths { get; set; }
    }

    public class File
    {
        public int FileId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int postId { get; set; }
        public virtual Post post { get; set; }
    }

    public class FilePath
    {
        public int FilePathId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int postId { get; set; }
        public virtual Post post { get; set; }
    }

    public enum FileType
    {
        Image = 1, Photo
    }
}