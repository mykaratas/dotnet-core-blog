namespace blog.data.models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    public class Post : CoreEntity
    {

        [
            Required,
            MaxLength(100)
        ]
        public string Title { get; set; }
        [Required]

        public string Content { get; set;}

        public DateTime CreatedDate { get; set; }

        public string FullName { get; set; }

        // Navigation Property
        public Guid CategoryId { get; set;}

        public virtual Category category { get; set; }

        public virtual ICollection<PostImage> PostImage { get; set; }
    }
}