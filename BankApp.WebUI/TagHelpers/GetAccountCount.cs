using BankApp.WebUI.Data.Context;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.WebUI.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount :TagHelper
    {
        public int AppUserId { get; set; }

        private readonly BankContext _bankcontext;

        public GetAccountCount(BankContext bankcontext)
        {
            _bankcontext = bankcontext;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _bankcontext.Accounts.Count(x=>x.ApplicationUserId==AppUserId);
            var html = $"<span class='badge bg-danger'>{accountCount} </span>";
            output.Content.SetHtmlContent(html); 
        }
    }
}
