using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.TagHelpers
{
    public class PaginationTagHelper : TagHelper
    {
        public int CurrentPage { get; set; }
        public int TotalRows { get; set; }
        public int RowPerPage { get; set; } = 5;
        public string OnClientClick { get; set; } = "";
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Build Pagination UL
            output.TagName = "ul";
            output.Attributes.SetAttribute("class", "pagination");

            // add First and Previous buttons  in pagination
            var first = AddPageLink("First", "1", OnClientClick, (CurrentPage == 1));
            var prev = AddPageLink("Prev", (CurrentPage - 1).ToString(), OnClientClick, (CurrentPage == 1));
            output.Content.AppendHtml(first);
            output.Content.AppendHtml(prev);

            //add  Numbered Pages in pagination
            int totalPages = (int)Math.Ceiling(TotalRows / (double)RowPerPage);
            for (int page = 1; page <= totalPages; page++)
            {
                var li = AddPageLink(page.ToString(), page.ToString(), OnClientClick, (page == CurrentPage));
                output.Content.AppendHtml(li);
            }

            // add Next and Last buttons  in pagination
            var next = AddPageLink("Next", (CurrentPage + 1).ToString(), OnClientClick, (CurrentPage == totalPages));
            var last = AddPageLink("Last", totalPages.ToString(), OnClientClick, (CurrentPage == totalPages));
            output.Content.AppendHtml(next);
            output.Content.AppendHtml(last);
                
            output.TagMode = TagMode.StartTagAndEndTag;
        }

        private TagBuilder AddPageLink(string text, string value, string onClientClick, bool isDisabled)
        {
            TagBuilder li = new TagBuilder("li");
            li.AddCssClass("page-item");

            TagBuilder anchor = new TagBuilder("a");
            anchor.AddCssClass("page-link");
            anchor.Attributes.Add("href", "#");
            anchor.Attributes.Add("data-page", value);
            anchor.InnerHtml.AppendHtml(text);
            if (isDisabled)
            {
                li.AddCssClass("disabled");
            }
            else
            {
                anchor.Attributes.Add("onClick", onClientClick);
            }
            li.InnerHtml.AppendHtml(anchor);
            return li;
        }
    }
}
