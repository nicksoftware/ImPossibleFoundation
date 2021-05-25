using System;
using ImPossibleFoundation.Common.Mappings;
using ImPossibleFoundation.Dtos;

namespace ImPossibleFoundation.Blog.Queries.GetArticleDetail
{
    public class ArticleDetailVm : FullAuditedEntityDto<Guid>, IMapFrom<Article>
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Cover { get; set; }
        public int PostViews { get; set; }
        public double Rating { get; set; }
        public bool IsFeatured { get; set; }
        public bool Selected { get; set; }
    }
}